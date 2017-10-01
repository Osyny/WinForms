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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void showInfoForm()
        {
            dateTimePickerTime.Text = ControlInfo.getInstance().CurrentInfo.Time;
            textBoxName.Text = ControlInfo.getInstance().CurrentInfo.Name;
            textBoxLevel.Text = ControlInfo.getInstance().CurrentInfo.Level;
            Show();
            updateTextTrans();
        }

        public void updateTextTrans()
        {
            this.Text = Translations.getInstance().getTranslation(TextId.YOU_WIN);

            labelTimeGame.Text = Translations.getInstance().getTranslation(TextId.TIME_GAME);
            labelDificLevel.Text = Translations.getInstance().getTranslation(TextId.DIFIC_LEVEL_WIN);
            labelWinName.Text = Translations.getInstance().getTranslation(TextId.NAME_WIN_USER);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
