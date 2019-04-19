using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class frmCharacterStats : Form
    {
        public frmCharacterStats()
        {
            InitializeComponent();
        }

        private void btnNewCharacter_Click(object sender, EventArgs e)
        {
            // old method
            //new frmCharacterCreator().Show();

            //this disables the Stats form whilst the creator form is open
            frmCharacterCreator f2 = new frmCharacterCreator();
            f2.ShowDialog(this);
        }
    }
}
