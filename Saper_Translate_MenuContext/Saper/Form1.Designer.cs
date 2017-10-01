namespace Saper
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuForm = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameMenuForm = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuForm = new System.Windows.Forms.ToolStripMenuItem();
            this.DifLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.level1 = new System.Windows.Forms.ToolStripMenuItem();
            this.level2 = new System.Windows.Forms.ToolStripMenuItem();
            this.level3 = new System.Windows.Forms.ToolStripMenuItem();
            this.languageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.english = new System.Windows.Forms.ToolStripMenuItem();
            this.uk = new System.Windows.Forms.ToolStripMenuItem();
            this.ru = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuForm = new System.Windows.Forms.ToolStripMenuItem();
            this.championsMenuForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuForm,
            this.championsMenuForm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuForm
            // 
            this.FileMenuForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameMenuForm,
            this.SettingsMenuForm,
            this.ExitMenuForm});
            this.FileMenuForm.Name = "FileMenuForm";
            this.FileMenuForm.Size = new System.Drawing.Size(37, 20);
            this.FileMenuForm.Text = "File";
            // 
            // NewGameMenuForm
            // 
            this.NewGameMenuForm.Name = "NewGameMenuForm";
            this.NewGameMenuForm.Size = new System.Drawing.Size(132, 22);
            this.NewGameMenuForm.Text = "New Game";
            this.NewGameMenuForm.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // SettingsMenuForm
            // 
            this.SettingsMenuForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DifLevel,
            this.languageMenu});
            this.SettingsMenuForm.Name = "SettingsMenuForm";
            this.SettingsMenuForm.Size = new System.Drawing.Size(132, 22);
            this.SettingsMenuForm.Text = "Settings";
            this.SettingsMenuForm.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // DifLevel
            // 
            this.DifLevel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.level1,
            this.level2,
            this.level3});
            this.DifLevel.Name = "DifLevel";
            this.DifLevel.Size = new System.Drawing.Size(172, 22);
            this.DifLevel.Text = "1. Difficulty lavel :";
            // 
            // level1
            // 
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(107, 22);
            this.level1.Text = "Level1";
            this.level1.Click += new System.EventHandler(this.choiceOfDifficultyLevelToolStripMenuItem_Click);
            // 
            // level2
            // 
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(107, 22);
            this.level2.Text = "Level2";
            this.level2.Click += new System.EventHandler(this.level2ToolStripMenuItem_Click);
            // 
            // level3
            // 
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(107, 22);
            this.level3.Text = "Level3";
            this.level3.Click += new System.EventHandler(this.level3ToolStripMenuItem_Click);
            // 
            // languageMenu
            // 
            this.languageMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.english,
            this.uk,
            this.ru});
            this.languageMenu.Name = "languageMenu";
            this.languageMenu.Size = new System.Drawing.Size(172, 22);
            this.languageMenu.Text = "2. language menu:";
            // 
            // english
            // 
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(112, 22);
            this.english.Text = "English";
            this.english.Click += new System.EventHandler(this.english_Click);
            // 
            // uk
            // 
            this.uk.Name = "uk";
            this.uk.Size = new System.Drawing.Size(112, 22);
            this.uk.Text = "Uk";
            this.uk.Click += new System.EventHandler(this.uk_Click);
            // 
            // ru
            // 
            this.ru.Name = "ru";
            this.ru.Size = new System.Drawing.Size(112, 22);
            this.ru.Text = "Ru";
            this.ru.Click += new System.EventHandler(this.ru_Click);
            // 
            // ExitMenuForm
            // 
            this.ExitMenuForm.Name = "ExitMenuForm";
            this.ExitMenuForm.Size = new System.Drawing.Size(132, 22);
            this.ExitMenuForm.Text = "Exit";
            this.ExitMenuForm.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // championsMenuForm
            // 
            this.championsMenuForm.Name = "championsMenuForm";
            this.championsMenuForm.Size = new System.Drawing.Size(80, 20);
            this.championsMenuForm.Text = "Champions";
            this.championsMenuForm.Click += new System.EventHandler(this.championsMenuForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 627);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuForm;
        private System.Windows.Forms.ToolStripMenuItem NewGameMenuForm;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuForm;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuForm;
        private System.Windows.Forms.ToolStripMenuItem championsMenuForm;
        private System.Windows.Forms.ToolStripMenuItem DifLevel;
        private System.Windows.Forms.ToolStripMenuItem languageMenu;
        private System.Windows.Forms.ToolStripMenuItem english;
        private System.Windows.Forms.ToolStripMenuItem uk;
        private System.Windows.Forms.ToolStripMenuItem level1;
        private System.Windows.Forms.ToolStripMenuItem level2;
        private System.Windows.Forms.ToolStripMenuItem level3;
        private System.Windows.Forms.ToolStripMenuItem ru;
    }
}

