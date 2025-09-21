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
    public partial class DetailSettingsForm : Form
    {
        // Свойство для выбранных типов деталей
        public List<DetailType> SelectedTypes { get; private set; } = new List<DetailType>();

        public DetailSettingsForm()
        {
            InitializeComponent();
        }

        private void DetailSettingsForm_Load(object sender, EventArgs e)
        {
            // Устанавливаем подсказку для пользователя
            infoLabel.Text = "Выберите 4 типа деталей:";

            // Обновляем счетчик выбранных элементов
            UpdateSelectionCounter();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SelectedTypes.Clear();

            // Собираем выбранные типы
            if (gearCheckBox.Checked) SelectedTypes.Add(DetailType.Gear);
            if (squareCheckBox.Checked) SelectedTypes.Add(DetailType.Square);
            if (triangleCheckBox.Checked) SelectedTypes.Add(DetailType.Triangle);
            if (rhombusCheckBox.Checked) SelectedTypes.Add(DetailType.Rhombus);
            if (washerCheckBox.Checked) SelectedTypes.Add(DetailType.Washer);
            if (nutCheckBox.Checked) SelectedTypes.Add(DetailType.Nut);

            // Проверяем что выбрано ровно 4 типа
            if (SelectedTypes.Count != 4)
            {
                MessageBox.Show("Выберите ровно 4 типа деталей!", "Ошибка",
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
        private void gearCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectionCounter();
        }

        private void squareCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectionCounter();
        }

        private void triangleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectionCounter();
        }

        private void rhombusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectionCounter();
        }

        private void washerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectionCounter();
        }

        private void nutCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectionCounter();
        }

        // Обновляет счетчик выбранных элементов
        private void UpdateSelectionCounter()
        {
            var checkedCount = 0;
            if (gearCheckBox.Checked) checkedCount++;
            if (squareCheckBox.Checked) checkedCount++;
            if (triangleCheckBox.Checked) checkedCount++;
            if (rhombusCheckBox.Checked) checkedCount++;
            if (washerCheckBox.Checked) checkedCount++;
            if (nutCheckBox.Checked) checkedCount++;

            // Проверяем лимит
            if (checkedCount > 4)
            {
                // Находим последний выбранный чекбокс и снимаем выделение
                var checkBoxes = new[] { gearCheckBox, squareCheckBox, triangleCheckBox, rhombusCheckBox, washerCheckBox, nutCheckBox };
                foreach (var cb in checkBoxes)
                {
                    if (cb.Checked)
                    {
                        cb.Checked = false;
                        MessageBox.Show("Можно выбрать только 4 типа деталей!", "Предупреждение",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                checkedCount = 3; // После снятия будет 3
            }

            // Обновляем текст счетчика
            counterLabel.Text = $"Выбрано: {checkedCount}/4";

            // Активируем кнопку OK только если выбрано ровно 4 элемента
            okButton.Enabled = (checkedCount == 4);

            // Меняем цвет счетчика
            counterLabel.ForeColor = checkedCount == 4 ? Color.Green : Color.Red;
        }
    }
}