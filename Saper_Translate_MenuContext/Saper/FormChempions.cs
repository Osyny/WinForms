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
    public partial class FormChempions : Form
    {
        public FormChempions()
        {
            InitializeComponent();
            updateTextTrans();
        }

        // list champions
        public void updateForm()
        {
            dataGridViewChempions.Rows.Clear();
            foreach(var i in ControlInfo.getInstance().Infos)
            {
                 dataGridViewChempions.Rows.Add(i.Value.Name, i.Value.Level, i.Value.Time);  
                           
            }
            Show();
        }

        public void updateTextTrans()
        {
            this.Text = Translations.getInstance().getTranslation(TextId.TITLE_CHAMPIONS);

           // dataGridViewChempions[0, dataGridViewChempions.CurrentCell.RowIndex].Na = Translations.getInstance().getTranslation(TextId.NAME);
           // dataGridViewChempions = Translations.getInstance().getTranslation(TextId.LEVEL);
           // dataGridViewChempions = Translations.getInstance().getTranslation(TextId.TIME);

        }
    }
}
