
namespace _611
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
            this.btn_img = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_tran = new System.Windows.Forms.Button();
            this.lb_tran = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoFmale = new System.Windows.Forms.CheckBox();
            this.rdoMale = new System.Windows.Forms.CheckBox();
            this.gbCon = new System.Windows.Forms.GroupBox();
            this.rdoChi = new System.Windows.Forms.CheckBox();
            this.rdoJap = new System.Windows.Forms.CheckBox();
            this.rdoEng = new System.Windows.Forms.CheckBox();
            this.lb = new System.Windows.Forms.ListBox();
            this.btn_lbcheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbCon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_img
            // 
            this.btn_img.Location = new System.Drawing.Point(466, 34);
            this.btn_img.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(272, 22);
            this.btn_img.TabIndex = 1;
            this.btn_img.Text = "이미지 선택";
            this.btn_img.UseVisualStyleBackColor = true;
            this.btn_img.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lb1.Location = new System.Drawing.Point(764, 91);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(299, 22);
            this.lb1.TabIndex = 2;
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb
            // 
            this.pb.Image = global::_611.Properties.Resources.오류;
            this.pb.Location = new System.Drawing.Point(466, 80);
            this.pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(272, 256);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            this.pb.Click += new System.EventHandler(this.pb_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(764, 49);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(170, 15);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "2. 이미지를 클릭하세요.";
            this.lb2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "3. 출력된 이미지명을 영문으로 입력하세요.";
            // 
            // btn_tran
            // 
            this.btn_tran.Location = new System.Drawing.Point(768, 256);
            this.btn_tran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tran.Name = "btn_tran";
            this.btn_tran.Size = new System.Drawing.Size(297, 31);
            this.btn_tran.TabIndex = 5;
            this.btn_tran.Text = "4. 판정";
            this.btn_tran.UseVisualStyleBackColor = true;
            this.btn_tran.Click += new System.EventHandler(this.btn_tran_Click);
            // 
            // lb_tran
            // 
            this.lb_tran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lb_tran.Location = new System.Drawing.Point(764, 308);
            this.lb_tran.Name = "lb_tran";
            this.lb_tran.Size = new System.Drawing.Size(299, 22);
            this.lb_tran.TabIndex = 6;
            this.lb_tran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(768, 212);
            this.tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(297, 25);
            this.tb.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.rdoFmale);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(195, 140);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성별";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoFmale
            // 
            this.rdoFmale.AutoSize = true;
            this.rdoFmale.Location = new System.Drawing.Point(19, 82);
            this.rdoFmale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoFmale.Name = "rdoFmale";
            this.rdoFmale.Size = new System.Drawing.Size(59, 19);
            this.rdoFmale.TabIndex = 1;
            this.rdoFmale.Text = "여성";
            this.rdoFmale.UseVisualStyleBackColor = true;
            this.rdoFmale.CheckedChanged += new System.EventHandler(this.rdoFmale_CheckedChanged);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(19, 41);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(59, 19);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.Text = "남성";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.CheckedChanged += new System.EventHandler(this.rdoMale_CheckedChanged);
            // 
            // gbCon
            // 
            this.gbCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbCon.Controls.Add(this.rdoChi);
            this.gbCon.Controls.Add(this.rdoJap);
            this.gbCon.Controls.Add(this.rdoEng);
            this.gbCon.Location = new System.Drawing.Point(11, 202);
            this.gbCon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCon.Name = "gbCon";
            this.gbCon.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCon.Size = new System.Drawing.Size(195, 140);
            this.gbCon.TabIndex = 9;
            this.gbCon.TabStop = false;
            this.gbCon.Text = "가능한 언어는?";
            this.gbCon.Enter += new System.EventHandler(this.gbCon_Enter);
            // 
            // rdoChi
            // 
            this.rdoChi.AutoSize = true;
            this.rdoChi.Location = new System.Drawing.Point(19, 88);
            this.rdoChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoChi.Name = "rdoChi";
            this.rdoChi.Size = new System.Drawing.Size(74, 19);
            this.rdoChi.TabIndex = 3;
            this.rdoChi.Text = "중국어";
            this.rdoChi.UseVisualStyleBackColor = true;
            // 
            // rdoJap
            // 
            this.rdoJap.AutoSize = true;
            this.rdoJap.Location = new System.Drawing.Point(19, 62);
            this.rdoJap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoJap.Name = "rdoJap";
            this.rdoJap.Size = new System.Drawing.Size(74, 19);
            this.rdoJap.TabIndex = 2;
            this.rdoJap.Text = "일본어";
            this.rdoJap.UseVisualStyleBackColor = true;
            // 
            // rdoEng
            // 
            this.rdoEng.AutoSize = true;
            this.rdoEng.Location = new System.Drawing.Point(19, 38);
            this.rdoEng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoEng.Name = "rdoEng";
            this.rdoEng.Size = new System.Drawing.Size(59, 19);
            this.rdoEng.TabIndex = 1;
            this.rdoEng.Text = "영어";
            this.rdoEng.UseVisualStyleBackColor = true;
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 15;
            this.lb.Location = new System.Drawing.Point(223, 79);
            this.lb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(220, 259);
            this.lb.TabIndex = 10;
            // 
            // btn_lbcheck
            // 
            this.btn_lbcheck.Location = new System.Drawing.Point(223, 27);
            this.btn_lbcheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_lbcheck.Name = "btn_lbcheck";
            this.btn_lbcheck.Size = new System.Drawing.Size(221, 29);
            this.btn_lbcheck.TabIndex = 11;
            this.btn_lbcheck.Text = "설문 결과";
            this.btn_lbcheck.UseVisualStyleBackColor = true;
            this.btn_lbcheck.Click += new System.EventHandler(this.btn_lbcheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 362);
            this.Controls.Add(this.btn_lbcheck);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.gbCon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.lb_tran);
            this.Controls.Add(this.btn_tran);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btn_img);
            this.Controls.Add(this.pb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "컨텐츠 만들기 예";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCon.ResumeLayout(false);
            this.gbCon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button btn_img;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tran;
        private System.Windows.Forms.Label lb_tran;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbCon;
        private System.Windows.Forms.CheckBox rdoFmale;
        private System.Windows.Forms.CheckBox rdoMale;
        private System.Windows.Forms.CheckBox rdoChi;
        private System.Windows.Forms.CheckBox rdoJap;
        private System.Windows.Forms.CheckBox rdoEng;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Button btn_lbcheck;
    }
}

