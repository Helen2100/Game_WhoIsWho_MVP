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
    public partial class AuthorsPage : Form
    {
        public AuthorsPage()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainMenuPage mainMenu = new MainMenuPage();
            mainMenu.ShowDialog();
            Application.Exit();
        }
    }
}
