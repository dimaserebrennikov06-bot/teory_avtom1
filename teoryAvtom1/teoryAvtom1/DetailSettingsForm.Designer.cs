namespace teoryAvtom1
{
    partial class DetailSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gearCheckBox = new System.Windows.Forms.CheckBox();
            this.squareCheckBox = new System.Windows.Forms.CheckBox();
            this.triangleCheckBox = new System.Windows.Forms.CheckBox();
            this.rhombusCheckBox = new System.Windows.Forms.CheckBox();
            this.washerCheckBox = new System.Windows.Forms.CheckBox();
            this.nutCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.counterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gearCheckBox
            // 
            this.gearCheckBox.AutoSize = true;
            this.gearCheckBox.Location = new System.Drawing.Point(121, 52);
            this.gearCheckBox.Name = "gearCheckBox";
            this.gearCheckBox.Size = new System.Drawing.Size(88, 17);
            this.gearCheckBox.TabIndex = 0;
            this.gearCheckBox.Text = "Шестеренка";
            this.gearCheckBox.UseVisualStyleBackColor = true;
            this.gearCheckBox.CheckedChanged += new System.EventHandler(this.gearCheckBox_CheckedChanged);
            // 
            // squareCheckBox
            // 
            this.squareCheckBox.AutoSize = true;
            this.squareCheckBox.Location = new System.Drawing.Point(121, 75);
            this.squareCheckBox.Name = "squareCheckBox";
            this.squareCheckBox.Size = new System.Drawing.Size(68, 17);
            this.squareCheckBox.TabIndex = 1;
            this.squareCheckBox.Text = "Квадрат";
            this.squareCheckBox.UseVisualStyleBackColor = true;
            this.squareCheckBox.CheckedChanged += new System.EventHandler(this.squareCheckBox_CheckedChanged);
            // 
            // triangleCheckBox
            // 
            this.triangleCheckBox.AutoSize = true;
            this.triangleCheckBox.Location = new System.Drawing.Point(121, 98);
            this.triangleCheckBox.Name = "triangleCheckBox";
            this.triangleCheckBox.Size = new System.Drawing.Size(91, 17);
            this.triangleCheckBox.TabIndex = 2;
            this.triangleCheckBox.Text = "Треугольник";
            this.triangleCheckBox.UseVisualStyleBackColor = true;
            this.triangleCheckBox.CheckedChanged += new System.EventHandler(this.triangleCheckBox_CheckedChanged);
            // 
            // rhombusCheckBox
            // 
            this.rhombusCheckBox.AutoSize = true;
            this.rhombusCheckBox.Location = new System.Drawing.Point(226, 52);
            this.rhombusCheckBox.Name = "rhombusCheckBox";
            this.rhombusCheckBox.Size = new System.Drawing.Size(53, 17);
            this.rhombusCheckBox.TabIndex = 3;
            this.rhombusCheckBox.Text = "Ромб";
            this.rhombusCheckBox.UseVisualStyleBackColor = true;
            this.rhombusCheckBox.CheckedChanged += new System.EventHandler(this.rhombusCheckBox_CheckedChanged);
            // 
            // washerCheckBox
            // 
            this.washerCheckBox.AutoSize = true;
            this.washerCheckBox.Location = new System.Drawing.Point(226, 75);
            this.washerCheckBox.Name = "washerCheckBox";
            this.washerCheckBox.Size = new System.Drawing.Size(59, 17);
            this.washerCheckBox.TabIndex = 4;
            this.washerCheckBox.Text = "Шайба";
            this.washerCheckBox.UseVisualStyleBackColor = true;
            this.washerCheckBox.CheckedChanged += new System.EventHandler(this.washerCheckBox_CheckedChanged);
            // 
            // nutCheckBox
            // 
            this.nutCheckBox.AutoSize = true;
            this.nutCheckBox.Location = new System.Drawing.Point(226, 98);
            this.nutCheckBox.Name = "nutCheckBox";
            this.nutCheckBox.Size = new System.Drawing.Size(56, 17);
            this.nutCheckBox.TabIndex = 5;
            this.nutCheckBox.Text = "Гайка";
            this.nutCheckBox.UseVisualStyleBackColor = true;
            this.nutCheckBox.CheckedChanged += new System.EventHandler(this.nutCheckBox_CheckedChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(114, 149);
            this.okButton.Name = "okButton";
            this.okButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(242, 149);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(64, 13);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(139, 13);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Text = "Выберите 4 типа деталей:";
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Location = new System.Drawing.Point(239, 13);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(75, 13);
            this.counterLabel.TabIndex = 9;
            this.counterLabel.Text = "Выбрано: 0/4";
            // 
            // DetailSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 200);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.nutCheckBox);
            this.Controls.Add(this.washerCheckBox);
            this.Controls.Add(this.rhombusCheckBox);
            this.Controls.Add(this.triangleCheckBox);
            this.Controls.Add(this.squareCheckBox);
            this.Controls.Add(this.gearCheckBox);
            this.Name = "DetailSettingsForm";
            this.Text = "DetailSettingsForm";
            this.Load += new System.EventHandler(this.DetailSettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox gearCheckBox;
        private System.Windows.Forms.CheckBox squareCheckBox;
        private System.Windows.Forms.CheckBox triangleCheckBox;
        private System.Windows.Forms.CheckBox rhombusCheckBox;
        private System.Windows.Forms.CheckBox washerCheckBox;
        private System.Windows.Forms.CheckBox nutCheckBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label counterLabel;
    }
}