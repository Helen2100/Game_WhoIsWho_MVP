
namespace Game_WhoIsWho_MVP
{
    partial class AuthorsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorsPage));
            this.backBtn = new System.Windows.Forms.Button();
            this.txtAuthors = new System.Windows.Forms.Label();
            this.NameWindow = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.backBtn.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.ForeColor = System.Drawing.Color.Yellow;
            this.backBtn.Location = new System.Drawing.Point(12, 571);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(111, 51);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // txtAuthors
            // 
            this.txtAuthors.AutoSize = true;
            this.txtAuthors.BackColor = System.Drawing.Color.Transparent;
            this.txtAuthors.Font = new System.Drawing.Font("Segoe Print", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtAuthors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAuthors.Location = new System.Drawing.Point(85, 126);
            this.txtAuthors.Name = "txtAuthors";
            this.txtAuthors.Size = new System.Drawing.Size(1057, 464);
            this.txtAuthors.TabIndex = 17;
            this.txtAuthors.Text = resources.GetString("txtAuthors.Text");
            // 
            // NameWindow
            // 
            this.NameWindow.AutoSize = true;
            this.NameWindow.Font = new System.Drawing.Font("Microsoft YaHei", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameWindow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameWindow.Location = new System.Drawing.Point(496, 41);
            this.NameWindow.Name = "NameWindow";
            this.NameWindow.Size = new System.Drawing.Size(304, 52);
            this.NameWindow.TabIndex = 16;
            this.NameWindow.Text = "Авторы игры";
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
            // AuthorsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(1319, 634);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.txtAuthors);
            this.Controls.Add(this.NameWindow);
            this.Name = "AuthorsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorsPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label txtAuthors;
        private System.Windows.Forms.Label NameWindow;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}