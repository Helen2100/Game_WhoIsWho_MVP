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
    public partial class SingleModePage : Form
    {
        int quectionCount;
        int correctAnswers;
        int wrongAnswers;
        string[] arrayInformation;
        int correctAnswersNumber;
        int selectResponse;
        System.IO.StreamReader Read;
        public SingleModePage()
        {
            InitializeComponent();
        }
        public void Start()
        {
            var encoding = System.Text.Encoding.GetEncoding(1251);
            try
            {
                Read = new System.IO.StreamReader(
                    System.IO.Directory.GetCurrentDirectory() +
                                                                @"\questionsForTheSingleModePage.txt", encoding);
                this.Text = Read.ReadLine();

                quectionCount = 0;
                correctAnswers = 0;
                wrongAnswers = 0;
                arrayInformation = new string[10];
            }
            catch
            {
                MessageBox.Show("ошибка при чтении файла");
            }
            Quection();
        }
        public void Quection()
        {
            label1.Text = Read.ReadLine();

            radioButton1.Text = Read.ReadLine();
            radioButton2.Text = Read.ReadLine();

            correctAnswersNumber = int.Parse(Read.ReadLine());

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            button1.Enabled = false;
            quectionCount++;

            if (Read.EndOfStream == true) button1.Text = "Завершить";
        }
        private void SwitchingState(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.Focus();
            RadioButton switcher = (RadioButton)sender;
            var nameSwitcher = switcher.Name;

            selectResponse = int.Parse(nameSwitcher.Substring(11));
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
             StartPage startPage = new StartPage();
            startPage.ShowDialog();
            Application.Exit();
        }

        private void nextQuestionBtn_Click(object sender, EventArgs e)
        {
            if (selectResponse == correctAnswersNumber) correctAnswers++;

            if (selectResponse != correctAnswersNumber)
            {
                wrongAnswers++;
                arrayInformation[wrongAnswers] = label1.Text;
            }
            if (button1.Text == "Начать викторину")
            {
                button1.Text = "Следующий вопрос";
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                Start();
                return;
            }
            if (button1.Text == "Завершить")
            {
                Read.Close();

                radioButton1.Visible = false;
                radioButton2.Visible = false;

                label1.Text = String.Format("Викторина закончена. \n" +
                    "Правильных ответов: {0} из {1}.",
                    correctAnswers, quectionCount);

                button1.Text = "Начать викторину";

                var listWrongAnswers = "список ошибок" +
                    ":\n\n";
                for (int i = 1; i <= wrongAnswers; i++)
                    listWrongAnswers += arrayInformation[i] + "\n";

                if (wrongAnswers != 0) MessageBox.Show(
                                        listWrongAnswers, "Викторина закончена");
            }
            if (button1.Text == "Следующий вопрос") Quection();
        }

        private void SingleModePage_Load(object sender, EventArgs e)
        {
            button1.Text = "Следующий вопрос";
            button2.Text = "Выйти из режима";

            radioButton1.CheckedChanged += new EventHandler(SwitchingState);
            radioButton2.CheckedChanged += new EventHandler(SwitchingState);
            Start();
        }
    }
}
