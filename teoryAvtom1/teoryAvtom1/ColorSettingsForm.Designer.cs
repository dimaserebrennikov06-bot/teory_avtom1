namespace teoryAvtom1
{
    partial class ColorSettingsForm
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
            this.redCheckBox = new System.Windows.Forms.CheckBox();
            this.greenCheckBox = new System.Windows.Forms.CheckBox();
            this.blueCheckBox = new System.Windows.Forms.CheckBox();
            this.yellowCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.counterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // redCheckBox
            // 
            this.redCheckBox.AutoSize = true;
            this.redCheckBox.Location = new System.Drawing.Point(75, 38);
            this.redCheckBox.Name = "redCheckBox";
            this.redCheckBox.Size = new System.Drawing.Size(71, 17);
            this.redCheckBox.TabIndex = 0;
            this.redCheckBox.Text = "Красный";
            this.redCheckBox.UseVisualStyleBackColor = true;
            this.redCheckBox.CheckedChanged += new System.EventHandler(this.redCheckBox_CheckedChanged);
            // 
            // greenCheckBox
            // 
            this.greenCheckBox.AutoSize = true;
            this.greenCheckBox.Location = new System.Drawing.Point(75, 61);
            this.greenCheckBox.Name = "greenCheckBox";
            this.greenCheckBox.Size = new System.Drawing.Size(71, 17);
            this.greenCheckBox.TabIndex = 1;
            this.greenCheckBox.Text = "Зелёный";
            this.greenCheckBox.UseVisualStyleBackColor = true;
            this.greenCheckBox.CheckedChanged += new System.EventHandler(this.greenCheckBox_CheckedChanged);
            // 
            // blueCheckBox
            // 
            this.blueCheckBox.AutoSize = true;
            this.blueCheckBox.Location = new System.Drawing.Point(183, 38);
            this.blueCheckBox.Name = "blueCheckBox";
            this.blueCheckBox.Size = new System.Drawing.Size(57, 17);
            this.blueCheckBox.TabIndex = 2;
            this.blueCheckBox.Text = "Синий";
            this.blueCheckBox.UseVisualStyleBackColor = true;
            this.blueCheckBox.CheckedChanged += new System.EventHandler(this.blueCheckBox_CheckedChanged);
            // 
            // yellowCheckBox
            // 
            this.yellowCheckBox.AutoSize = true;
            this.yellowCheckBox.Location = new System.Drawing.Point(183, 61);
            this.yellowCheckBox.Name = "yellowCheckBox";
            this.yellowCheckBox.Size = new System.Drawing.Size(68, 17);
            this.yellowCheckBox.TabIndex = 3;
            this.yellowCheckBox.Text = "Жёлтый";
            this.yellowCheckBox.UseVisualStyleBackColor = true;
            this.yellowCheckBox.CheckedChanged += new System.EventHandler(this.yellowCheckBox_CheckedChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(75, 115);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(183, 115);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите 2 цвета:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Location = new System.Drawing.Point(207, 9);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(114, 13);
            this.counterLabel.TabIndex = 7;
            this.counterLabel.Text = "Цветов выбрано: 0/2";
            // 
            // ColorSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 184);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.yellowCheckBox);
            this.Controls.Add(this.blueCheckBox);
            this.Controls.Add(this.greenCheckBox);
            this.Controls.Add(this.redCheckBox);
            this.Name = "ColorSettingsForm";
            this.Text = "ColorSettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox redCheckBox;
        private System.Windows.Forms.CheckBox greenCheckBox;
        private System.Windows.Forms.CheckBox blueCheckBox;
        private System.Windows.Forms.CheckBox yellowCheckBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label counterLabel;
    }
}