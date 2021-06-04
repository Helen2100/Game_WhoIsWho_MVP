
namespace Game_WhoIsWho_MVP
{
    partial class StartPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TrueFalseMode = new System.Windows.Forms.Button();
            this.singleModeBtn = new System.Windows.Forms.Button();
            this.commandModeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TrueFalseMode
            // 
            this.TrueFalseMode.BackColor = System.Drawing.Color.MediumVioletRed;
            this.TrueFalseMode.Font = new System.Drawing.Font("Segoe Print", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TrueFalseMode.ForeColor = System.Drawing.Color.Yellow;
            this.TrueFalseMode.Location = new System.Drawing.Point(431, 454);
            this.TrueFalseMode.Name = "TrueFalseMode";
            this.TrueFalseMode.Size = new System.Drawing.Size(480, 71);
            this.TrueFalseMode.TabIndex = 16;
            this.TrueFalseMode.Text = "Режим правда/ложь";
            this.TrueFalseMode.UseVisualStyleBackColor = false;
            this.TrueFalseMode.Click += new System.EventHandler(this.TrueFalseMode_Click);
            // 
            // singleModeBtn
            // 
            this.singleModeBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.singleModeBtn.Font = new System.Drawing.Font("Segoe Print", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.singleModeBtn.ForeColor = System.Drawing.Color.Yellow;
            this.singleModeBtn.Location = new System.Drawing.Point(431, 338);
            this.singleModeBtn.Name = "singleModeBtn";
            this.singleModeBtn.Size = new System.Drawing.Size(482, 71);
            this.singleModeBtn.TabIndex = 15;
            this.singleModeBtn.Text = "Одиночный режим";
            this.singleModeBtn.UseVisualStyleBackColor = false;
            this.singleModeBtn.Click += new System.EventHandler(this.singleModeBtn_Click);
            // 
            // commandModeBtn
            // 
            this.commandModeBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.commandModeBtn.Font = new System.Drawing.Font("Segoe Print", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.commandModeBtn.ForeColor = System.Drawing.Color.Yellow;
            this.commandModeBtn.Location = new System.Drawing.Point(431, 225);
            this.commandModeBtn.Name = "commandModeBtn";
            this.commandModeBtn.Size = new System.Drawing.Size(481, 71);
            this.commandModeBtn.TabIndex = 14;
            this.commandModeBtn.Text = "Командный режим";
            this.commandModeBtn.UseVisualStyleBackColor = false;
            this.commandModeBtn.Click += new System.EventHandler(this.commandModeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(422, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 52);
            this.label1.TabIndex = 13;
            this.label1.Text = "Выберите режим игры";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(12, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Game_WhoIsWho_MVP.Resources.setting;
            this.pictureBox2.Location = new System.Drawing.Point(1262, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game_WhoIsWho_MVP.Resources.flagRussia;
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(1319, 634);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TrueFalseMode);
            this.Controls.Add(this.singleModeBtn);
            this.Controls.Add(this.commandModeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TrueFalseMode;
        private System.Windows.Forms.Button singleModeBtn;
        private System.Windows.Forms.Button commandModeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}