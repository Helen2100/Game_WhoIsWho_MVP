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
    public partial class СommandModePage : Form
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
        public СommandModePage()
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
                label4.Text = "Ход: " + textBox1.Text;
            else label4.Text = "Ход: " + textBox2.Text;

            label3.Text = Read.ReadLine();

            radioButton1.Text = Read.ReadLine();
            radioButton2.Text = Read.ReadLine();

            correctAnswersNumber = int.Parse(Read.ReadLine());

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            button3.Enabled = false;
            quectionCount++;

            if (Read.EndOfStream == true) button3.Text = "Завершить";
        }
        private void SwitchingState(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button3.Focus();
            RadioButton switcher = (RadioButton)sender;
            var nameSwitcher = switcher.Name;

            selectResponse = int.Parse(nameSwitcher.Substring(11));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            StartPage startPage = new StartPage();
            startPage.ShowDialog();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            NameWindow.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label4.Text = "Ход: " + textBox1.Text;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button3.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
        }

        private void СommandModePage_Load(object sender, EventArgs e)
        {
            button1.Text = "Начать игру";
            button2.Text = "Выйти из режимы";
            button3.Text = "Следующий вопрос";
            button3.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;

            radioButton1.CheckedChanged += new EventHandler(SwitchingState);
            radioButton2.CheckedChanged += new EventHandler(SwitchingState);
            Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectResponse == correctAnswersNumber)
            {
                correctAnswers++;
                if (label4.Text == "Ход: " + textBox1.Text)
                    firstCommandCorrectAnswers++;
                else secondCommandCorrectAnswers++;
            }

            if (selectResponse != correctAnswersNumber)
            {
                wrongAnswers++;
                arrayInformation[wrongAnswers] = label3.Text;
                if (label4.Text == "Ход: " + textBox1.Text)
                {
                    firstCommandWrongAnswers++;
                    arrayfirstCommandWrongAnswers[firstCommandWrongAnswers] = label3.Text;
                }
                else
                {
                    secondCommandWrongAnswers++;
                    arraysecondCommandWrongAnswers[secondCommandWrongAnswers] = label3.Text;
                }
            }
            if (button3.Text == "Начать викторину")
            {
                secondCommandCorrectAnswers = 0;
                firstCommandCorrectAnswers = 0;
                firstCommandWrongAnswers = 0;
                secondCommandWrongAnswers = 0;
                button3.Text = "Следующий вопрос";
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                Start();
                return;
            }
            if (button3.Text == "Завершить")
            {
                Read.Close();

                radioButton1.Visible = false;
                radioButton2.Visible = false;

                if (firstCommandCorrectAnswers > secondCommandCorrectAnswers)
                {
                    label3.Text = String.Format("Викторина закончена. \n" +
                    "Выйграла команда: {0} \n" +
                    "Правильных ответов: {1} из {2}. \n" +
                    "Правильных ответов у проигравшей: {3} из {4}. \n", textBox1.Text,
                    (quectionCount / 2) - firstCommandWrongAnswers, (quectionCount / 2),
                    (quectionCount / 2) - secondCommandWrongAnswers, (quectionCount / 2));
                }
                else if (firstCommandCorrectAnswers < secondCommandCorrectAnswers)
                {
                    label3.Text = String.Format("Викторина закончена. \n" +
                    "Выйграла команда: {0} \n" +
                    "Правильных ответов: {1} из {2}. \n" +
                    "Правильных ответов у проигравшей: {3} из {4}. \n", textBox2.Text,
                    (quectionCount / 2) - secondCommandWrongAnswers, (quectionCount / 2),
                    (quectionCount / 2) - firstCommandWrongAnswers, (quectionCount / 2));
                }
                else label3.Text = "Победила дружба! :)";

                button3.Text = "Начать викторину";

                var listWrongAnswersFirstCommand = "список ошибок у " + textBox1.Text +
                    ":\n\n";
                for (int i = 1; i <= firstCommandWrongAnswers; i++)
                    listWrongAnswersFirstCommand += arrayfirstCommandWrongAnswers[i] + "\n";

                var listWrongAnswersSecondCommand = "список ошибок у " + textBox2.Text +
                    ":\n\n";
                for (int i = 1; i <= secondCommandWrongAnswers; i++)
                    listWrongAnswersSecondCommand += arraysecondCommandWrongAnswers[i] + "\n";

                if (wrongAnswers != 0)
                {
                    MessageBox.Show(listWrongAnswersFirstCommand, "Викторина закончена");
                    MessageBox.Show(listWrongAnswersSecondCommand, "Викторина закончена");
                }
            }
            if (button3.Text == "Следующий вопрос")
            {
                Quection();
            }
        }
    }
}
