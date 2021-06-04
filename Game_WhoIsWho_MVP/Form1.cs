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
    public partial class MainMenuPage : Form
    {
        public MainMenuPage()
        {
            InitializeComponent();
        }

        private void Start_btn_MouseHover(object sender, EventArgs e)
        {
            StartBtn.BackColor = Color.FromName("DeepPink");
        }

        private void Rule_btn_MouseHover(object sender, EventArgs e)
        {
            RuleBtn.BackColor = Color.FromName("DeepPink");
        }

        private void Authors_btn_MouseHover(object sender, EventArgs e)
        {
            AuthorsBtn.BackColor = Color.FromName("DeepPink");
        }


        private void Start_btn_MouseLeave(object sender, EventArgs e)
        {
            StartBtn.BackColor = Color.FromName("MediumVioletRed");
        }

        private void Rule_btn_MouseLeave(object sender, EventArgs e)
        {
            RuleBtn.BackColor = Color.FromName("MediumVioletRed");
        }

        private void Authors_btn_MouseLeave(object sender, EventArgs e)
        {
            AuthorsBtn.BackColor = Color.FromName("MediumVioletRed");
        }

        private void Exit_btn_MouseHover(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.FromName("DeepPink");
        }

        private void Exit_btn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.FromName("MediumVioletRed");
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartPage startPage = new StartPage();
            startPage.ShowDialog();
            Application.Exit();
        }

        private void RuleBtn_Click(object sender, EventArgs e)
        {
            RulePage rulePage = new RulePage();
            rulePage.ShowDialog();
            Application.Exit();
        }

        private void AuthorsBtn_Click(object sender, EventArgs e)
        {
            AuthorsPage authorsPage = new AuthorsPage();
            authorsPage.ShowDialog();
            Application.Exit();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
