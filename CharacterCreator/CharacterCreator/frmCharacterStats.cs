﻿using System;
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

        frmCharacterCreator characterCreator = new frmCharacterCreator();

        private void btnNewCharacter_Click(object sender, EventArgs e)
        {
            characterCreator.Show();
        }
    }
}
