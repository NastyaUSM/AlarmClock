namespace AlarmClock
{
    partial class AlarmClockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmClockForm));
            this.MusicDownloader = new System.Windows.Forms.Button();
            this.MusicFilePath = new System.Windows.Forms.TextBox();
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.CurrentTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.EnteringTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AlarmClockLabel = new System.Windows.Forms.Label();
            this.AlarmTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MusicDownloader
            // 
            this.MusicDownloader.Location = new System.Drawing.Point(11, 273);
            this.MusicDownloader.Margin = new System.Windows.Forms.Padding(2);
            this.MusicDownloader.Name = "MusicDownloader";
            this.MusicDownloader.Size = new System.Drawing.Size(133, 27);
            this.MusicDownloader.TabIndex = 0;
            this.MusicDownloader.Text = "Добавить музыку";
            this.MusicDownloader.UseVisualStyleBackColor = true;
            this.MusicDownloader.Click += new System.EventHandler(this.MusicDownloader_Click);
            // 
            // MusicFilePath
            // 
            this.MusicFilePath.Enabled = false;
            this.MusicFilePath.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MusicFilePath.Location = new System.Drawing.Point(148, 274);
            this.MusicFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.MusicFilePath.Name = "MusicFilePath";
            this.MusicFilePath.ReadOnly = true;
            this.MusicFilePath.Size = new System.Drawing.Size(267, 25);
            this.MusicFilePath.TabIndex = 1;
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.Location = new System.Drawing.Point(164, 8);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(87, 13);
            this.CurrentTimeLabel.TabIndex = 2;
            this.CurrentTimeLabel.Text = "Текущее время";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(144, 32);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(35, 13);
            this.HoursLabel.TabIndex = 3;
            this.HoursLabel.Text = "Часы";
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Location = new System.Drawing.Point(185, 32);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(46, 13);
            this.MinutesLabel.TabIndex = 4;
            this.MinutesLabel.Text = "Минуты";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Location = new System.Drawing.Point(237, 32);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(51, 13);
            this.SecondsLabel.TabIndex = 5;
            this.SecondsLabel.Text = "Секунды";
            // 
            // CurrentTime
            // 
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentTime.Location = new System.Drawing.Point(142, 54);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(139, 29);
            this.CurrentTime.TabIndex = 6;
            this.CurrentTime.Text = "11 :  30 :  27";
            // 
            // CurrentTimeTimer
            // 
            this.CurrentTimeTimer.Interval = 1000;
            this.CurrentTimeTimer.Tick += new System.EventHandler(this.CurrentTimeTimer_Tick);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(25, 122);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(92, 47);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Cтарт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopButton.Location = new System.Drawing.Point(306, 122);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(93, 47);
            this.StopButton.TabIndex = 8;
            this.StopButton.Text = "Стоп";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // EnteringTimeTextBox
            // 
            this.EnteringTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnteringTimeTextBox.Location = new System.Drawing.Point(147, 178);
            this.EnteringTimeTextBox.Mask = "00 : 00 : 00";
            this.EnteringTimeTextBox.Name = "EnteringTimeTextBox";
            this.EnteringTimeTextBox.Size = new System.Drawing.Size(134, 35);
            this.EnteringTimeTextBox.TabIndex = 9;
            this.EnteringTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AlarmClockLabel
            // 
            this.AlarmClockLabel.AutoSize = true;
            this.AlarmClockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlarmClockLabel.Location = new System.Drawing.Point(142, 122);
            this.AlarmClockLabel.Name = "AlarmClockLabel";
            this.AlarmClockLabel.Size = new System.Drawing.Size(139, 29);
            this.AlarmClockLabel.TabIndex = 10;
            this.AlarmClockLabel.Text = "11 :  30 :  27";
            // 
            // AlarmTimer
            // 
            this.AlarmTimer.Tick += new System.EventHandler(this.AlarmTimer_Tick);
            // 
            // AlarmClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 311);
            this.Controls.Add(this.AlarmClockLabel);
            this.Controls.Add(this.EnteringTimeTextBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CurrentTime);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.MinutesLabel);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.CurrentTimeLabel);
            this.Controls.Add(this.MusicFilePath);
            this.Controls.Add(this.MusicDownloader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AlarmClockForm";
            this.Text = "Будильник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MusicDownloader;
        private System.Windows.Forms.TextBox MusicFilePath;
        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.Timer CurrentTimeTimer;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.MaskedTextBox EnteringTimeTextBox;
        private System.Windows.Forms.Label AlarmClockLabel;
        private System.Windows.Forms.Timer AlarmTimer;
    }
}

