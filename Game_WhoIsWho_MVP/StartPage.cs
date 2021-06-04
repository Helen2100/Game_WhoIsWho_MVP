using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_WhoIsWho_MVP
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainMenuPage mainMenu = new MainMenuPage();
            mainMenu.ShowDialog();
            Application.Exit();
        }

        private void commandModeBtn_Click(object sender, EventArgs e)
        {
            СommandModePage commandModePage = new СommandModePage();
            commandModePage.ShowDialog();
            Application.Exit();
        }

        private void singleModeBtn_Click(object sender, EventArgs e)
        {
            SingleModePage singleModePage = new SingleModePage();
            singleModePage.ShowDialog();
            Application.Exit();
        }

        private void TrueFalseMode_Click(object sender, EventArgs e)
        {
            TrueFalseModePage trueFalseModePage = new TrueFalseModePage();
            trueFalseModePage.ShowDialog();
            Application.Exit();
        }
    }
}
