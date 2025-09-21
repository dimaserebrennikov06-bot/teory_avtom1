using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teoryAvtom1
{
    public partial class Form1 : Form
    {
        private List<DetailType> availableDetails = new List<DetailType>();
        private GameState gameState = new GameState();
        private List<ProgressBar> boxProgressBars = new List<ProgressBar>();
        private List<Label> boxLabels = new List<Label>();
        private List<PictureBox> boxPictureBoxes = new List<PictureBox>();
        private List<PictureBox> detailIconPictureBoxes = new List<PictureBox>();
        private PictureBox currentDetailPictureBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            boxLabels.Add(labelBox1);
            boxLabels.Add(labelBox2);
            boxLabels.Add(labelBox3);
            boxLabels.Add(labelBox4);
            boxLabels.Add(labelBox5);
            boxLabels.Add(labelBox6);
            boxLabels.Add(labelBox7);
            boxLabels.Add(labelBox8);

            conveyorPictureBox.Image = LoadTransparentImage("Sprites/conveyor.png");
            generatorPictureBox.Image = LoadTransparentImage("Sprites/generator.png");

            conveyorPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            generatorPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            conveyorPictureBox.BackColor = Color.Transparent;
            generatorPictureBox.BackColor = Color.Transparent;

            currentDetailPictureBox = new PictureBox();
            currentDetailPictureBox.Size = new Size(40, 40);
            currentDetailPictureBox.BackColor = Color.Transparent;
            currentDetailPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            currentDetailPictureBox.Visible = false;
            this.Controls.Add(currentDetailPictureBox);
            currentDetailPictureBox.BringToFront();

            boxProgressBars.Add(progressBar1);
            boxProgressBars.Add(progressBar2);
            boxProgressBars.Add(progressBar3);
            boxProgressBars.Add(progressBar4);
            boxProgressBars.Add(progressBar5);
            boxProgressBars.Add(progressBar6);
            boxProgressBars.Add(progressBar7);
            boxProgressBars.Add(progressBar8);

            foreach (var pb in boxProgressBars)
            {
                pb.Maximum = 8;
                pb.Value = 0;
            }

            currentDetailLabel.Text = "Конвейер пуст";
        }

        private void InitializeAvailableDetails() // Те детали, что задали в настройках
        {
            availableDetails = new List<DetailType>();
            if (gameState.AllowedTypes != null)
            {
                availableDetails.AddRange(gameState.AllowedTypes);
            }
        }

        private void UpdateAvailableDetails() // Обновление нужного списка деталей
        {
            if (gameState.Boxes == null || gameState.AllowedTypes == null)
                return;

            var newAvailableDetails = new List<DetailType>();

            foreach (var detailType in gameState.AllowedTypes)
            {
                // ИСПРАВЛЕНО: используем TargetType вместо DetailType
                var box = gameState.Boxes.FirstOrDefault(b => b.TargetType == detailType);
                if (box != null && !box.IsFull)
                {
                    newAvailableDetails.Add(detailType);
                }
            }

            availableDetails = newAvailableDetails;

            if (availableDetails.Count == 0 && gameState.IsRunning)
            {
                gameState.IsRunning = false;
                gameTimer.Stop();
                MessageBox.Show("Все ящики заполнены! Поставка деталей прекращена.");
            }
        }

        private Image LoadTransparentImage(string path)
        {
            using (var bmpTemp = new Bitmap(path))
            {
                return new Bitmap(bmpTemp);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (gameState.AllowedTypes == null || gameState.AllowedColors == null ||
                gameState.AllowedTypes.Count != 4 || gameState.AllowedColors.Count != 2)
            {
                MessageBox.Show("Сначала выберите настройки через меню!\n(4 типа деталей и 2 цвета)");
                return;
            }

            InitializeAvailableDetails();
            gameState.CreateBoxes();
            gameState.IsRunning = true;

            if (availableDetails.Count > 0)
            {
                gameState.GenerateSingleDetail(availableDetails);
            }

            gameTimer.Start();
            UpdateUI();

            MessageBox.Show("Игра началась! Наблюдайте за процессом.");
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (gameState.IsRunning)
            {
                gameState.MoveConveyor();

                // Проверяем, если деталь дошла до конца
                if (gameState.CurrentDetailPosition >= gameState.ConveyorLength && gameState.CurrentDetail != null)
                {
                    // ИСПРАВЛЕНО: используем TargetType вместо DetailType 
                    var targetBox = gameState.Boxes.FirstOrDefault(b =>
                        b.TargetType == gameState.CurrentDetail.Type && b.IsActive);//проверяется только тип детали. Надо подключить проверку

                    if (targetBox != null && !targetBox.IsFull)
                    {
                        targetBox.CurrentCount++;

                        // Проверяем, не заполнился ли ящик
                        if (targetBox.IsFull)
                        {
                            UpdateAvailableDetails(); // Убираем эту деталь из генерации
                        }
                    }

                    // Генерируем новую деталь только из доступных
                    if (availableDetails.Count > 0)
                    {
                        gameState.GenerateSingleDetail(availableDetails);
                    }
                    else
                    {
                        gameState.CurrentDetail = null;
                    }
                }

                UpdateUI();

                // Проверяем конец игры
                if (!gameState.IsRunning)
                {
                    gameTimer.Stop();
                    MessageBox.Show("Все ящики заполнены! Игра окончена.");
                }
            }
        }

        private void UpdateUI()
        {
            // Обновляем движущуюся деталь
            if (gameState.CurrentDetail != null)
            {
                currentDetailLabel.Text = $"{gameState.CurrentDetail} | Позиция: {gameState.CurrentDetailPosition}%";

                if (conveyorPictureBox != null)
                {
                    int pixelPosition = (conveyorPictureBox.Width * gameState.CurrentDetailPosition) / 100;
                    currentDetailPictureBox.Left = conveyorPictureBox.Left + pixelPosition - currentDetailPictureBox.Width / 2;
                    currentDetailPictureBox.Top = conveyorPictureBox.Top + 20;
                    currentDetailPictureBox.Visible = true;

                    string detailPath = Path.Combine("Sprites",
                        $"detail_{gameState.CurrentDetail.Type}_{gameState.CurrentDetail.Color}.png");
                    if (File.Exists(detailPath))
                    {
                        currentDetailPictureBox.Image = Image.FromFile(detailPath);
                        currentDetailPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            else
            {
                currentDetailLabel.Text = "Конвейер пуст";
                currentDetailPictureBox.Visible = false;
            }

            // Обновляем ящики
            if (gameState.Boxes != null)
            {
                for (int i = 0; i < gameState.Boxes.Count && i < boxProgressBars.Count; i++)
                {
                    var box = gameState.Boxes[i];
                    boxProgressBars[i].Value = box.CurrentCount;

                    if (i < boxLabels.Count)
                    {
                        // ИСПРАВЛЕНО: используем DisplayName из вашего Box класса
                        boxLabels[i].Text = $"{box.DisplayName}\n{box.CurrentCount}/8";

                        if (box.IsFull)
                        {
                            boxLabels[i].ForeColor = Color.Green;
                            boxLabels[i].Font = new Font(boxLabels[i].Font, FontStyle.Bold);
                        }
                        else if (!box.IsActive)
                        {
                            boxLabels[i].ForeColor = Color.Gray;
                        }
                        else
                        {
                            boxLabels[i].ForeColor = Color.Black;
                        }
                    }
                }
            }
        }

        private void settingsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var detailsForm = new DetailSettingsForm();
            if (detailsForm.ShowDialog() == DialogResult.OK)
            {
                gameState.AllowedTypes = detailsForm.SelectedTypes;
                MessageBox.Show($"Выбраны типы: {string.Join(", ", gameState.AllowedTypes)}");
            }
        }

        private void settingsColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var colorsForm = new ColorSettingsForm();
            if (colorsForm.ShowDialog() == DialogResult.OK)
            {
                gameState.AllowedColors = colorsForm.SelectedColors;
                MessageBox.Show($"Выбраны цвета: {string.Join(", ", gameState.AllowedColors)}");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция 'Открыть' будет реализована позже.");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция 'Сохранить' будет реализована позже.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Конвейерный сортировщик деталей. Версия 1.0");
        }

        private void helpAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ФАВТ, 2 курс, Дмитрий Серебренников, 2025");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void spravkaToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void conveyorPictureBox_Click(object sender, EventArgs e) { }
        private void labelBox5_Click(object sender, EventArgs e) { }
        private void labelBox4_Click(object sender, EventArgs e) { }
    }

}

