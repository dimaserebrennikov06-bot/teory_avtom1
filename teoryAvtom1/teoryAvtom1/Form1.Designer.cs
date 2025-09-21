namespace teoryAvtom1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spravkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.progressBar8 = new System.Windows.Forms.ProgressBar();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.currentDetailLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.conveyorPictureBox = new System.Windows.Forms.PictureBox();
            this.generatorPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.labelBox1 = new System.Windows.Forms.Label();
            this.labelBox2 = new System.Windows.Forms.Label();
            this.labelBox3 = new System.Windows.Forms.Label();
            this.labelBox4 = new System.Windows.Forms.Label();
            this.labelBox5 = new System.Windows.Forms.Label();
            this.labelBox6 = new System.Windows.Forms.Label();
            this.labelBox7 = new System.Windows.Forms.Label();
            this.labelBox8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conveyorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.spravkaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsColorsToolStripMenuItem,
            this.settingsDetailsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingsToolStripMenuItem.Text = "Настройки";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // settingsColorsToolStripMenuItem
            // 
            this.settingsColorsToolStripMenuItem.Name = "settingsColorsToolStripMenuItem";
            this.settingsColorsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.settingsColorsToolStripMenuItem.Text = "Выбор цвета";
            this.settingsColorsToolStripMenuItem.Click += new System.EventHandler(this.settingsColorsToolStripMenuItem_Click);
            // 
            // settingsDetailsToolStripMenuItem
            // 
            this.settingsDetailsToolStripMenuItem.Name = "settingsDetailsToolStripMenuItem";
            this.settingsDetailsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.settingsDetailsToolStripMenuItem.Text = "Выбор деталей";
            this.settingsDetailsToolStripMenuItem.Click += new System.EventHandler(this.settingsDetailsToolStripMenuItem_Click);
            // 
            // spravkaToolStripMenuItem
            // 
            this.spravkaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAboutToolStripMenuItem,
            this.helpAuthorToolStripMenuItem});
            this.spravkaToolStripMenuItem.Name = "spravkaToolStripMenuItem";
            this.spravkaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.spravkaToolStripMenuItem.Text = "Справка";
            this.spravkaToolStripMenuItem.Click += new System.EventHandler(this.spravkaToolStripMenuItem_Click);
            // 
            // helpAboutToolStripMenuItem
            // 
            this.helpAboutToolStripMenuItem.Name = "helpAboutToolStripMenuItem";
            this.helpAboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.helpAboutToolStripMenuItem.Text = "О программе";
            this.helpAboutToolStripMenuItem.Click += new System.EventHandler(this.helpAboutToolStripMenuItem_Click);
            // 
            // helpAuthorToolStripMenuItem
            // 
            this.helpAuthorToolStripMenuItem.Name = "helpAuthorToolStripMenuItem";
            this.helpAuthorToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.helpAuthorToolStripMenuItem.Text = "Об авторе";
            this.helpAuthorToolStripMenuItem.Click += new System.EventHandler(this.helpAuthorToolStripMenuItem_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(432, 27);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 229);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(77, 10);
            this.progressBar1.TabIndex = 12;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(88, 298);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(78, 10);
            this.progressBar2.TabIndex = 13;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(165, 229);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(78, 10);
            this.progressBar3.TabIndex = 14;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(244, 298);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(77, 10);
            this.progressBar4.TabIndex = 15;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(331, 229);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(77, 10);
            this.progressBar5.TabIndex = 16;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(418, 298);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(77, 10);
            this.progressBar6.TabIndex = 17;
            // 
            // progressBar7
            // 
            this.progressBar7.Location = new System.Drawing.Point(502, 229);
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(77, 10);
            this.progressBar7.TabIndex = 18;
            // 
            // progressBar8
            // 
            this.progressBar8.Location = new System.Drawing.Point(590, 298);
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.Size = new System.Drawing.Size(79, 10);
            this.progressBar8.TabIndex = 19;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 500;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // currentDetailLabel
            // 
            this.currentDetailLabel.AutoSize = true;
            this.currentDetailLabel.Location = new System.Drawing.Point(240, 32);
            this.currentDetailLabel.Name = "currentDetailLabel";
            this.currentDetailLabel.Size = new System.Drawing.Size(81, 13);
            this.currentDetailLabel.TabIndex = 20;
            this.currentDetailLabel.Text = "Конвейер пуст";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::teoryAvtom1.Properties.Resources.box_general;
            this.pictureBox1.Location = new System.Drawing.Point(12, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // conveyorPictureBox
            // 
            this.conveyorPictureBox.Image = global::teoryAvtom1.Properties.Resources.conveyor;
            this.conveyorPictureBox.Location = new System.Drawing.Point(12, 170);
            this.conveyorPictureBox.Name = "conveyorPictureBox";
            this.conveyorPictureBox.Size = new System.Drawing.Size(668, 167);
            this.conveyorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.conveyorPictureBox.TabIndex = 21;
            this.conveyorPictureBox.TabStop = false;
            this.conveyorPictureBox.Click += new System.EventHandler(this.conveyorPictureBox_Click);
            // 
            // generatorPictureBox
            // 
            this.generatorPictureBox.Image = global::teoryAvtom1.Properties.Resources.generator;
            this.generatorPictureBox.Location = new System.Drawing.Point(-9, 65);
            this.generatorPictureBox.Name = "generatorPictureBox";
            this.generatorPictureBox.Size = new System.Drawing.Size(166, 131);
            this.generatorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.generatorPictureBox.TabIndex = 22;
            this.generatorPictureBox.TabStop = false;
            this.generatorPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::teoryAvtom1.Properties.Resources.box_general;
            this.pictureBox2.Location = new System.Drawing.Point(321, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::teoryAvtom1.Properties.Resources.box_general;
            this.pictureBox3.Location = new System.Drawing.Point(407, 268);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::teoryAvtom1.Properties.Resources.box_general;
            this.pictureBox4.Location = new System.Drawing.Point(77, 268);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 81);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::teoryAvtom1.Properties.Resources.box_general;
            this.pictureBox5.Location = new System.Drawing.Point(234, 268);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 81);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::teoryAvtom1.Properties.Resources.box_general;
            this.pictureBox6.Location = new System.Drawing.Point(155, 202);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 81);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 28;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::teoryAvtom1.Properties.Resources.box_general;
            this.pictureBox7.Location = new System.Drawing.Point(492, 202);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 81);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 29;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::teoryAvtom1.Properties.Resources.box_general;
            this.pictureBox8.Location = new System.Drawing.Point(580, 268);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 81);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 30;
            this.pictureBox8.TabStop = false;
            // 
            // labelBox1
            // 
            this.labelBox1.AutoSize = true;
            this.labelBox1.Location = new System.Drawing.Point(45, 265);
            this.labelBox1.Name = "labelBox1";
            this.labelBox1.Size = new System.Drawing.Size(35, 13);
            this.labelBox1.TabIndex = 31;
            this.labelBox1.Text = "label1";
            // 
            // labelBox2
            // 
            this.labelBox2.AutoSize = true;
            this.labelBox2.Location = new System.Drawing.Point(111, 336);
            this.labelBox2.Name = "labelBox2";
            this.labelBox2.Size = new System.Drawing.Size(35, 13);
            this.labelBox2.TabIndex = 32;
            this.labelBox2.Text = "label1";
            // 
            // labelBox3
            // 
            this.labelBox3.AutoSize = true;
            this.labelBox3.Location = new System.Drawing.Point(183, 265);
            this.labelBox3.Name = "labelBox3";
            this.labelBox3.Size = new System.Drawing.Size(35, 13);
            this.labelBox3.TabIndex = 33;
            this.labelBox3.Text = "label1";
            // 
            // labelBox4
            // 
            this.labelBox4.AutoSize = true;
            this.labelBox4.Location = new System.Drawing.Point(268, 336);
            this.labelBox4.Name = "labelBox4";
            this.labelBox4.Size = new System.Drawing.Size(35, 13);
            this.labelBox4.TabIndex = 34;
            this.labelBox4.Text = "label1";
            this.labelBox4.Click += new System.EventHandler(this.labelBox4_Click);
            // 
            // labelBox5
            // 
            this.labelBox5.AutoSize = true;
            this.labelBox5.Location = new System.Drawing.Point(354, 265);
            this.labelBox5.Name = "labelBox5";
            this.labelBox5.Size = new System.Drawing.Size(35, 13);
            this.labelBox5.TabIndex = 35;
            this.labelBox5.Text = "label1";
            this.labelBox5.Click += new System.EventHandler(this.labelBox5_Click);
            // 
            // labelBox6
            // 
            this.labelBox6.AutoSize = true;
            this.labelBox6.Location = new System.Drawing.Point(441, 336);
            this.labelBox6.Name = "labelBox6";
            this.labelBox6.Size = new System.Drawing.Size(35, 13);
            this.labelBox6.TabIndex = 36;
            this.labelBox6.Text = "label1";
            // 
            // labelBox7
            // 
            this.labelBox7.AutoSize = true;
            this.labelBox7.Location = new System.Drawing.Point(526, 265);
            this.labelBox7.Name = "labelBox7";
            this.labelBox7.Size = new System.Drawing.Size(35, 13);
            this.labelBox7.TabIndex = 37;
            this.labelBox7.Text = "label1";
            // 
            // labelBox8
            // 
            this.labelBox8.AutoSize = true;
            this.labelBox8.Location = new System.Drawing.Point(615, 336);
            this.labelBox8.Name = "labelBox8";
            this.labelBox8.Size = new System.Drawing.Size(35, 13);
            this.labelBox8.TabIndex = 38;
            this.labelBox8.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar8);
            this.Controls.Add(this.progressBar7);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.labelBox8);
            this.Controls.Add(this.labelBox7);
            this.Controls.Add(this.labelBox6);
            this.Controls.Add(this.labelBox5);
            this.Controls.Add(this.labelBox3);
            this.Controls.Add(this.labelBox2);
            this.Controls.Add(this.labelBox1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.currentDetailLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.conveyorPictureBox);
            this.Controls.Add(this.generatorPictureBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conveyorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spravkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpAboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpAuthorToolStripMenuItem;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.ProgressBar progressBar7;
        private System.Windows.Forms.ProgressBar progressBar8;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label currentDetailLabel;
        private System.Windows.Forms.PictureBox conveyorPictureBox;
        private System.Windows.Forms.PictureBox generatorPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label labelBox1;
        private System.Windows.Forms.Label labelBox2;
        private System.Windows.Forms.Label labelBox3;
        private System.Windows.Forms.Label labelBox4;
        private System.Windows.Forms.Label labelBox5;
        private System.Windows.Forms.Label labelBox6;
        private System.Windows.Forms.Label labelBox7;
        private System.Windows.Forms.Label labelBox8;
    }
}

