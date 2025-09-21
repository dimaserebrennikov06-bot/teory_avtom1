using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teoryAvtom1
{
    public partial class ColorSettingsForm : Form
    {
        // Добавляем свойство для выбранных цветов
        public List<DetailColor> SelectedColors { get; private set; } = new List<DetailColor>();

        public ColorSettingsForm()
        {
            InitializeComponent();
        }

        private void ColorSettingsForm_Load(object sender, EventArgs e)
        {
            // Настраиваем цвета текста чекбоксов
            redCheckBox.ForeColor = Color.Red;
            greenCheckBox.ForeColor = Color.Green;
            blueCheckBox.ForeColor = Color.Blue;
            yellowCheckBox.ForeColor = Color.Gold;

            // Обновляем счетчик
            UpdateSelectionCounter();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SelectedColors.Clear();

            // Собираем выбранные цвета
            if (redCheckBox.Checked) SelectedColors.Add(DetailColor.Red);
            if (greenCheckBox.Checked) SelectedColors.Add(DetailColor.Green);
            if (blueCheckBox.Checked) SelectedColors.Add(DetailColor.Blue);
            if (yellowCheckBox.Checked) SelectedColors.Add(DetailColor.Yellow);

            // Проверяем что выбрано ровно 2 цвета
            if (SelectedColors.Count != 2)
            {
                MessageBox.Show("Выберите ровно 2 цвета!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Обработчики для каждого чекбокса
        private void redCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectionCounter();
        }

        private void greenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectionCounter();
        }

        private void blueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectionCounter();
        }

        private void yellowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectionCounter();
        }

        // Обновляет счетчик выбранных элементов
        private void UpdateSelectionCounter()
        {
            var checkedCount = 0;
            if (redCheckBox.Checked) checkedCount++;
            if (greenCheckBox.Checked) checkedCount++;
            if (blueCheckBox.Checked) checkedCount++;
            if (yellowCheckBox.Checked) checkedCount++;

            // Проверяем лимит
            if (checkedCount > 2)
            {
                // Находим последний выбранный чекбокс и снимаем выделение
                var checkBoxes = new[] { redCheckBox, greenCheckBox, blueCheckBox, yellowCheckBox };
                foreach (var cb in checkBoxes)
                {
                    if (cb.Checked)
                    {
                        cb.Checked = false;
                        MessageBox.Show("Можно выбрать только 2 цвета!", "Предупреждение",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                checkedCount = 1; // После снятия будет 1
            }

            // Обновляем текст счетчика
            counterLabel.Text = $"Выбрано: {checkedCount}/2";

            // Активируем кнопку OK только если выбрано ровно 2 элемента
            okButton.Enabled = (checkedCount == 2);

            // Меняем цвет счетчика
            counterLabel.ForeColor = checkedCount == 2 ? Color.Green : Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}