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
    public partial class GameCommandModePage : Form
    {
        int firstCommandCorrectAnswers;
        int secondCommandCorrectAnswers;
        int firstCommandWrongAnswers;
        int secondCommandWrongAnswers;
        int quectionCount;
        int correctAnswers;
        int wrongAnswers;
        string[] arrayInformation;
        string[] arrayfirstCommandWrongAnswers;
        string[] arraysecondCommandWrongAnswers;
        int correctAnswersNumber;
        int selectResponse;
        System.IO.StreamReader Read;
        public GameCommandModePage()
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
                                                                @"\questionsForTheCommandModePage.txt", encoding);
                this.Text = Read.ReadLine();

                quectionCount = 0;
                correctAnswers = 0;
                wrongAnswers = 0;
                arrayInformation = new string[10];
                arrayfirstCommandWrongAnswers = new string[10];
                arraysecondCommandWrongAnswers = new string[10];
            }
            catch
            {
                MessageBox.Show("ошибка при чтении файла");
            }
            Quection();
        }
        public void Quection()
        {
            if (((correctAnswers + wrongAnswers) % 2 == 0) || (correctAnswers + wrongAnswers == 0))
                label2.Text = "Ход: " + 1;
            else label2.Text = "Ход: " + 2;

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectResponse == correctAnswersNumber)
            {
                correctAnswers++;
                if (label2.Text == "Ход: " + 1)
                    firstCommandCorrectAnswers++;
                else secondCommandCorrectAnswers++;
            }

            if (selectResponse != correctAnswersNumber)
            {
                wrongAnswers++;
                arrayInformation[wrongAnswers] = label1.Text;
                if (label2.Text == "Ход: " + 1)
                {
                    firstCommandWrongAnswers++;
                    arrayfirstCommandWrongAnswers[firstCommandWrongAnswers] = label1.Text;
                }
                else
                {
                    secondCommandWrongAnswers++;
                    arraysecondCommandWrongAnswers[secondCommandWrongAnswers] = label1.Text;
                }
            }
            if (button1.Text == "Начать викторину")
            {
                secondCommandCorrectAnswers = 0;
                firstCommandCorrectAnswers = 0;
                firstCommandWrongAnswers = 0;
                secondCommandWrongAnswers = 0;
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

                if (firstCommandWrongAnswers < secondCommandWrongAnswers)
                {
                    label1.Text = String.Format("Викторина закончена. \n" +
                    "Выйграла открывшая игру команда № 1: \n" +
                    "Правильных ответов: {0} из {1}. \n" +
                    "Правильных ответов у проигравшей: {2} из {3}. \n",
                    (quectionCount / 2) - firstCommandWrongAnswers, (quectionCount / 2),
                    (quectionCount / 2) - secondCommandWrongAnswers, (quectionCount / 2));
                }
                else if (firstCommandWrongAnswers > secondCommandWrongAnswers)
                {
                    label1.Text = String.Format("Викторина закончена. \n" +
                    "Выйграла завершившую игру команда № 2: \n" +
                    "Правильных ответов у выйгравшей команды: {0} из {1}. \n" +
                    "Правильных ответов у проигравшей: {2} из {3}. \n",
                    (quectionCount / 2) - secondCommandWrongAnswers, (quectionCount / 2),
                    (quectionCount / 2) - firstCommandWrongAnswers, (quectionCount / 2));
                }
                else label1.Text = "Победила дружба! :)";

                button1.Text = "Начать викторину";

                var listWrongAnswersFirstCommand = "список ошибок открывшей игру команды № 1" +
                    ":\n\n";
                for (int i = 1; i <= firstCommandWrongAnswers; i++)
                    listWrongAnswersFirstCommand += arrayfirstCommandWrongAnswers[i] + "\n";

                var listWrongAnswersSecondCommand = "список ошибок завершившей игру команды № 2" +
                    ":\n\n";
                for (int i = 1; i <= secondCommandWrongAnswers; i++)
                    listWrongAnswersSecondCommand += arraysecondCommandWrongAnswers[i] + "\n";

                if (wrongAnswers != 0)
                {
                    MessageBox.Show(listWrongAnswersFirstCommand, "Викторина закончена");
                    MessageBox.Show(listWrongAnswersSecondCommand, "Викторина закончена");
                }
            }
            if (button1.Text == "Следующий вопрос")
            {
                Quection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartPage startPage = new StartPage();
            startPage.ShowDialog();
            Application.Exit();
        }

        private void GameCommandModePage_Load(object sender, EventArgs e)
        {
            button1.Text = "Следующий вопрос";
            button2.Text = "Выйти из режима";

            radioButton1.CheckedChanged += new EventHandler(SwitchingState);
            radioButton2.CheckedChanged += new EventHandler(SwitchingState);
            Start();
        }
    }
}
