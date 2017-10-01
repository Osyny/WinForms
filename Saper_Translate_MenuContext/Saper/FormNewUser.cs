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
    public partial class FormNewUser : Form
    {

        Info curentUser = new Info();
        Logic game = new Logic();
        

        public FormNewUser()
        {
            InitializeComponent();
            updateTextTrans();
        }

        public void updateTextTrans()
        {
            this.Text = Translations.getInstance().getTranslation(TextId.NEW_USER_TITLE);
            labelUserName.Text = Translations.getInstance().getTranslation(TextId.NEW_USER_NAME_LABEL);
            buttonStartGame.Text = Translations.getInstance().getTranslation(TextId.NEW_USER_OK_BTN);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            ControlInfo.getInstance().addInfoName(textBoxUserName.Text, game.getSize().ToString());

            // controllInfo.addInfoName(textBoxUserName.Text, 
            if (true)
            {
                Close();
            }
        }
    }
}
