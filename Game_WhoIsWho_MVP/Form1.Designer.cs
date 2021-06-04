
namespace Game_WhoIsWho_MVP
{
    partial class MainMenuPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartBtn = new System.Windows.Forms.Button();
            this.RuleBtn = new System.Windows.Forms.Button();
            this.AuthorsBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.StartBtn.Font = new System.Drawing.Font("Segoe Print", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.StartBtn.ForeColor = System.Drawing.Color.Yellow;
            this.StartBtn.Location = new System.Drawing.Point(548, 216);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(285, 83);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Начать игру";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            this.StartBtn.MouseLeave += new System.EventHandler(this.Start_btn_MouseLeave);
            this.StartBtn.MouseHover += new System.EventHandler(this.Start_btn_MouseHover);
            // 
            // RuleBtn
            // 
            this.RuleBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.RuleBtn.Font = new System.Drawing.Font("Segoe Print", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RuleBtn.ForeColor = System.Drawing.Color.Yellow;
            this.RuleBtn.Location = new System.Drawing.Point(548, 351);
            this.RuleBtn.Name = "RuleBtn";
            this.RuleBtn.Size = new System.Drawing.Size(285, 83);
            this.RuleBtn.TabIndex = 1;
            this.RuleBtn.Text = "Правила";
            this.RuleBtn.UseVisualStyleBackColor = false;
            this.RuleBtn.Click += new System.EventHandler(this.RuleBtn_Click);
            this.RuleBtn.MouseLeave += new System.EventHandler(this.Rule_btn_MouseLeave);
            this.RuleBtn.MouseHover += new System.EventHandler(this.Rule_btn_MouseHover);
            // 
            // AuthorsBtn
            // 
            this.AuthorsBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.AuthorsBtn.Font = new System.Drawing.Font("Segoe Print", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.AuthorsBtn.ForeColor = System.Drawing.Color.Yellow;
            this.AuthorsBtn.Location = new System.Drawing.Point(548, 481);
            this.AuthorsBtn.Name = "AuthorsBtn";
            this.AuthorsBtn.Size = new System.Drawing.Size(285, 83);
            this.AuthorsBtn.TabIndex = 2;
            this.AuthorsBtn.Text = "Об авторах";
            this.AuthorsBtn.UseVisualStyleBackColor = false;
            this.AuthorsBtn.Click += new System.EventHandler(this.AuthorsBtn_Click);
            this.AuthorsBtn.MouseLeave += new System.EventHandler(this.Authors_btn_MouseLeave);
            this.AuthorsBtn.MouseHover += new System.EventHandler(this.Authors_btn_MouseHover);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.exitBtn.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold);
            this.exitBtn.ForeColor = System.Drawing.Color.Yellow;
            this.exitBtn.Location = new System.Drawing.Point(12, 571);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(113, 51);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseLeave += new System.EventHandler(this.Exit_btn_MouseLeave);
            this.exitBtn.MouseHover += new System.EventHandler(this.Exit_btn_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(491, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "Кто есть Кто";
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
            // MainMenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(1319, 634);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.AuthorsBtn);
            this.Controls.Add(this.RuleBtn);
            this.Controls.Add(this.StartBtn);
            this.Name = "MainMenuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button RuleBtn;
        private System.Windows.Forms.Button AuthorsBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

