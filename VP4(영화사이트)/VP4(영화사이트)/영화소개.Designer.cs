
namespace VP4_영화사이트_
{
    partial class 영화소개
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.laber3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblActor = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "제목:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMovieName
            // 
            this.lblMovieName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMovieName.Location = new System.Drawing.Point(27, 438);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(259, 77);
            this.lblMovieName.TabIndex = 2;
            // 
            // laber3
            // 
            this.laber3.AutoSize = true;
            this.laber3.Location = new System.Drawing.Point(349, 25);
            this.laber3.Name = "laber3";
            this.laber3.Size = new System.Drawing.Size(42, 15);
            this.laber3.TabIndex = 3;
            this.laber3.Text = "감독:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "주연 배우:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "설명:";
            // 
            // lblExp
            // 
            this.lblExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblExp.Location = new System.Drawing.Point(349, 175);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(430, 293);
            this.lblExp.TabIndex = 6;
            // 
            // lblActor
            // 
            this.lblActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblActor.Location = new System.Drawing.Point(349, 102);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(430, 30);
            this.lblActor.TabIndex = 7;
            // 
            // lblDir
            // 
            this.lblDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDir.Location = new System.Drawing.Point(397, 10);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(382, 30);
            this.lblDir.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "포스터 선택";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbPoster
            // 
            this.pbPoster.Location = new System.Drawing.Point(27, 25);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(258, 304);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPoster.TabIndex = 10;
            this.pbPoster.TabStop = false;
            // 
            // 영화소개
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.pbPoster);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.lblActor);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.laber3);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.label1);
            this.Name = "영화소개";
            this.Text = "영화소개";
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label laber3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbPoster;
    }
}