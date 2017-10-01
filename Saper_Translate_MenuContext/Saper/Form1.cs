using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper
{
    public partial class Form1 : Form
    {
        private const int CELL_SIZE = 50;
        private const int MARGINE = 50;

        //Date USER

        private DateTime startTime;
        private DateTime endTime;
        private string timeGame;

        FormNewUser newGameForm;

        Button[,] buttons;
        Button[,] fields;

        Logic game = new Logic();

        Form2 infoWin = new Form2();
        FormChempions formChemp = new FormChempions();

        public Form1()
        {
            InitializeComponent();

            buttons = new Button[game.SIZE_X, game.SIZE_Y];
            fields = new Button[game.SIZE_X, game.SIZE_Y];

            //Mouse_click
            MouseClick += Form1_MouseClick;

            //Translation
            setLangMenuChecked();

            level1.Checked = true;

            newGameForm = new FormNewUser();
        }

        private void initFild()
        {
            //createFildEmptyBut();
            startGame();
        }

        private void showStartGameForm()
        {
            newGameForm.updateTextTrans();
            newGameForm.ShowDialog();
        }

        private void cleanForm()
        {
            foreach (Button field in fields)
                this.Controls.Remove(field);

            foreach (Button btn in buttons)
                this.Controls.Remove(btn);
        }
        public void startGame()
        {
            cleanForm();
            showStartGameForm();

            buttons = new Button[game.SIZE_X, game.SIZE_Y];
            fields = new Button[game.SIZE_X, game.SIZE_Y];

            createFildEmptyBut();

            startTime = DateTime.Now;

            //Close all cells
            // New Game
            game.init();

            createFild();
        }

        // GRAFIGS
        private void createFild()
        {
            for (int i = 0; i < game.SIZE_X; i++)
            {
                for (int j = 0; j < game.SIZE_Y; j++)
                {
                    // BUTTONS
                    fields[i, j] = new Button();
                    fields[i, j].Enabled = false;
                    fields[i, j].BackColor = Color.AliceBlue;
                    fields[i, j].FlatAppearance.BorderSize = 0;

                    fields[i, j].Size = new Size(CELL_SIZE, CELL_SIZE);
                    fields[i, j].Location = new Point(MARGINE + fields[i, j].Width * j, MARGINE + fields[i, j].Height * i);


                    if (game.Field[i, j] > 0)
                        fields[i, j].Text = game.Field[i, j].ToString();
                    else if (game.Field[i, j] == -1)
                        fields[i, j].Text = "*";

                    this.Controls.Add(fields[i, j]);
                    //fields[i, j].MouseClick += onBtnClick;
                }
            }
        }

        private void createFildEmptyBut()
        {
            for (int i = 0; i < game.SIZE_X; i++)
            {
                for (int j = 0; j < game.SIZE_Y; j++)
                {
                    // BUTTONS
                    buttons[i, j] = new Button();
                    buttons[i, j].Enabled = true;

                    buttons[i, j].Size = new Size(CELL_SIZE, CELL_SIZE);
                    buttons[i, j].Location = new Point(MARGINE + buttons[i, j].Width * j, MARGINE + buttons[i, j].Height * i);

                    this.Controls.Add(buttons[i, j]);
                    buttons[i, j].MouseClick += onBtnClick;
                }
            }
        }

        public void delateButUpdate()
        {
            for (int i = 0; i < game.SIZE_X; i++)
            {
                for (int j = 0; j < game.SIZE_Y; j++)
                {
                    if (game.isOpen[i, j] && buttons[i, j].Text != null)
                    {
                        buttons[i, j].Visible = false;
                    }
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("FORM click");
            // int x = Button.Lo
            //this.Text = $"X: {e.X}, Y:{e.Y}, x:{x}, y: {y}";
        }

        private void onBtnClick(object sender, MouseEventArgs e)
        {
            Button targetBtn = sender as Button;
            int targetJ = (targetBtn.Location.X - MARGINE) / CELL_SIZE;
            int targetI = (targetBtn.Location.Y - MARGINE) / CELL_SIZE;

            Console.WriteLine("Btn click: sender: J = " + targetJ +  "; I = " + targetI);

            game.openButton(targetI, targetJ);

            bool isMine = game.mine(targetI, targetJ);
            bool isWin = game.checkWin();

            if (isMine)
                game.openAllMines();
            else if (isMine)
                game.openAll();


            //DelateBut
            delateButUpdate();

            if (isMine)
            {
                Console.WriteLine("YOU LOSS!!!");
                MessageBox.Show("YOU LOSS!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                cleanForm();
            }
            else if (isWin)
            {
                //TIME GAME
                endTime = DateTime.Now;
                timeGame = (endTime.Hour - startTime.Hour).ToString() + ":" + (endTime.Minute - startTime.Minute).ToString() + ":" + (endTime.Second - startTime.Second).ToString();

                ControlInfo.getInstance().addTimeGame(timeGame);

                Console.WriteLine("YOU WIN!!! " + timeGame);
                infoWin.showInfoForm();
            }
        }
        
        // Translate form TEXT
        public void updateTextTrans()
        {
            this.Text = Translations.getInstance().getTranslation(TextId.SAPER_TITLE);

            FileMenuForm.Text = Translations.getInstance().getTranslation(TextId.FILE);
            NewGameMenuForm.Text = Translations.getInstance().getTranslation(TextId.NEW_GAME);
            SettingsMenuForm.Text = Translations.getInstance().getTranslation(TextId.SETINGS);
            ExitMenuForm.Text = Translations.getInstance().getTranslation(TextId.EXIT);

            DifLevel.Text = Translations.getInstance().getTranslation(TextId.DIF_LAVAL_GAME);
            languageMenu.Text = Translations.getInstance().getTranslation(TextId.LANG_MENU);

            level1.Text = Translations.getInstance().getTranslation(TextId.LEVEL_1);
            level2.Text = Translations.getInstance().getTranslation(TextId.LEVEL_2);
            level3.Text = Translations.getInstance().getTranslation(TextId.LEVEL_3);

            english.Text = Translations.getInstance().getTranslation(TextId.ENGLISH);
            uk.Text = Translations.getInstance().getTranslation(TextId.UA);
            ru.Text = Translations.getInstance().getTranslation(TextId.RU);

            championsMenuForm.Text = Translations.getInstance().getTranslation(TextId.CHAMPIONS);
        }


        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
           // ControlInfo.getInstance().doSerialize();
        }

            // LEWEL
        private void choiceOfDifficultyLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level1.Checked = true;

            ControlInfo.getInstance().setLevel(Level.LEVEL_1);
            //startGame();
        }

        private void level2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level2.Checked = true;

            ControlInfo.getInstance().setLevel(Level.LEVEL_2);
            //startGame();
        }

        private void level3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level3.Checked = true;

            ControlInfo.getInstance().setLevel(Level.LEVEL_3);
            //startGame();
        }

        private void setLangMenuChecked()
        {
            switch(ControlInfo.getInstance().CurrentLang)
            {
                case LanguageId.ENG:
                    english.Checked = true;
                    uk.Checked = false;
                    ru.Checked = false;
                    break;
                case LanguageId.RU:
                    english.Checked = false;
                    uk.Checked = false;
                    ru.Checked = true;
                    break;
                case LanguageId.UA:
                    english.Checked = false;
                    uk.Checked = true;
                    ru.Checked = false;
                    break;
                default:
                    break;
            }

            updateTextTrans();

        }

        //Сhoice of Language
        private void english_Click(object sender, EventArgs e)
        {
            ControlInfo.getInstance().CurrentLang = LanguageId.ENG;
            setLangMenuChecked();
        }

        private void uk_Click(object sender, EventArgs e)
        {
            ControlInfo.getInstance().CurrentLang = LanguageId.UA;
            setLangMenuChecked();
        }

        private void ru_Click(object sender, EventArgs e)
        {
            ControlInfo.getInstance().CurrentLang = LanguageId.RU;
            setLangMenuChecked();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // ControlInfo.getInstance().doSerialize();
        }

        private void championsMenuForm_Click(object sender, EventArgs e)
        {
            
            formChemp.updateForm();
        }
    }
}
