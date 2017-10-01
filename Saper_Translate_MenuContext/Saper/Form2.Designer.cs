namespace Saper
{
    partial class Form2
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
            this.labelTimeGame = new System.Windows.Forms.Label();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.labelDificLevel = new System.Windows.Forms.Label();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelWinName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTimeGame
            // 
            this.labelTimeGame.AutoSize = true;
            this.labelTimeGame.Location = new System.Drawing.Point(20, 27);
            this.labelTimeGame.Name = "labelTimeGame";
            this.labelTimeGame.Size = new System.Drawing.Size(65, 13);
            this.labelTimeGame.TabIndex = 0;
            this.labelTimeGame.Text = "Time game :";
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(183, 21);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(86, 20);
            this.dateTimePickerTime.TabIndex = 1;
            // 
            // labelDificLevel
            // 
            this.labelDificLevel.AutoSize = true;
            this.labelDificLevel.Location = new System.Drawing.Point(20, 69);
            this.labelDificLevel.Name = "labelDificLevel";
            this.labelDificLevel.Size = new System.Drawing.Size(78, 13);
            this.labelDificLevel.TabIndex = 2;
            this.labelDificLevel.Text = "Difficulty level :";
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Location = new System.Drawing.Point(183, 58);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(86, 20);
            this.textBoxLevel.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(183, 105);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(86, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // labelWinName
            // 
            this.labelWinName.AutoSize = true;
            this.labelWinName.Location = new System.Drawing.Point(20, 111);
            this.labelWinName.Name = "labelWinName";
            this.labelWinName.Size = new System.Drawing.Size(83, 13);
            this.labelWinName.TabIndex = 5;
            this.labelWinName.Text = "Winner\'s name :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelWinName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxLevel);
            this.Controls.Add(this.labelDificLevel);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.labelTimeGame);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTimeGame;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.Label labelDificLevel;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelWinName;
        private System.Windows.Forms.Button button1;
    }
}