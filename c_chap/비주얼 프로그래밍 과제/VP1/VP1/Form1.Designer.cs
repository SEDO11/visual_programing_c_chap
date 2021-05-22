
namespace VP1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnin = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pt1 = new System.Windows.Forms.Label();
            this.lbin = new System.Windows.Forms.Label();
            this.lbout = new System.Windows.Forms.Label();
            this.tbin = new System.Windows.Forms.TextBox();
            this.lbtextout = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(391, 299);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(80, 26);
            this.btnin.TabIndex = 0;
            this.btnin.Text = "입력";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(490, 400);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(99, 38);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "종료";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pt1
            // 
            this.pt1.Font = new System.Drawing.Font("굴림", 11F);
            this.pt1.Location = new System.Drawing.Point(487, 12);
            this.pt1.Name = "pt1";
            this.pt1.Size = new System.Drawing.Size(102, 30);
            this.pt1.TabIndex = 3;
            this.pt1.Text = "과일 사진";
            this.pt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbin
            // 
            this.lbin.AutoSize = true;
            this.lbin.Location = new System.Drawing.Point(12, 306);
            this.lbin.Name = "lbin";
            this.lbin.Size = new System.Drawing.Size(42, 15);
            this.lbin.TabIndex = 4;
            this.lbin.Text = "입력:";
            // 
            // lbout
            // 
            this.lbout.AutoSize = true;
            this.lbout.Location = new System.Drawing.Point(12, 355);
            this.lbout.Name = "lbout";
            this.lbout.Size = new System.Drawing.Size(42, 15);
            this.lbout.TabIndex = 5;
            this.lbout.Text = "출력:";
            // 
            // tbin
            // 
            this.tbin.Location = new System.Drawing.Point(60, 299);
            this.tbin.Name = "tbin";
            this.tbin.Size = new System.Drawing.Size(310, 25);
            this.tbin.TabIndex = 6;
            this.tbin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbtextout
            // 
            this.lbtextout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbtextout.Location = new System.Drawing.Point(60, 355);
            this.lbtextout.Name = "lbtextout";
            this.lbtextout.Size = new System.Drawing.Size(310, 29);
            this.lbtextout.TabIndex = 7;
            this.lbtextout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbtextout.Click += new System.EventHandler(this.label1_Click);
            // 
            // pb1
            // 
            this.pb1.Image = global::VP1.Properties.Resources.오류;
            this.pb1.Location = new System.Drawing.Point(12, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(459, 271);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.lbtextout);
            this.Controls.Add(this.tbin);
            this.Controls.Add(this.lbout);
            this.Controls.Add(this.lbin);
            this.Controls.Add(this.pt1);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btnin);
            this.Name = "Form1";
            this.Text = "과일 검색 프로그램";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label pt1;
        private System.Windows.Forms.Label lbin;
        private System.Windows.Forms.Label lbout;
        private System.Windows.Forms.TextBox tbin;
        private System.Windows.Forms.Label lbtextout;
    }
}

