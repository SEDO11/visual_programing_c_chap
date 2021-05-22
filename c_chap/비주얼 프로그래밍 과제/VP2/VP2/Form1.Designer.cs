
namespace VP2
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
            this.lbtextout = new System.Windows.Forms.Label();
            this.tbin = new System.Windows.Forms.TextBox();
            this.lbout = new System.Windows.Forms.Label();
            this.lbin = new System.Windows.Forms.Label();
            this.pt1 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.apcheckbox = new System.Windows.Forms.RadioButton();
            this.bacheckbox = new System.Windows.Forms.RadioButton();
            this.gacheckbox = new System.Windows.Forms.RadioButton();
            this.lb_cal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_c = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbengout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtextout
            // 
            this.lbtextout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbtextout.Location = new System.Drawing.Point(259, 343);
            this.lbtextout.Name = "lbtextout";
            this.lbtextout.Size = new System.Drawing.Size(310, 29);
            this.lbtextout.TabIndex = 15;
            this.lbtextout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbin
            // 
            this.tbin.Location = new System.Drawing.Point(259, 299);
            this.tbin.Name = "tbin";
            this.tbin.Size = new System.Drawing.Size(310, 25);
            this.tbin.TabIndex = 14;
            this.tbin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbout
            // 
            this.lbout.AutoSize = true;
            this.lbout.Location = new System.Drawing.Point(211, 343);
            this.lbout.Name = "lbout";
            this.lbout.Size = new System.Drawing.Size(42, 15);
            this.lbout.TabIndex = 13;
            this.lbout.Text = "출력:";
            // 
            // lbin
            // 
            this.lbin.AutoSize = true;
            this.lbin.Location = new System.Drawing.Point(211, 306);
            this.lbin.Name = "lbin";
            this.lbin.Size = new System.Drawing.Size(42, 15);
            this.lbin.TabIndex = 12;
            this.lbin.Text = "입력:";
            // 
            // pt1
            // 
            this.pt1.Font = new System.Drawing.Font("굴림", 11F);
            this.pt1.Location = new System.Drawing.Point(686, 12);
            this.pt1.Name = "pt1";
            this.pt1.Size = new System.Drawing.Size(102, 30);
            this.pt1.TabIndex = 11;
            this.pt1.Text = "과일 사진";
            this.pt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb1
            // 
            this.pb1.Image = global::VP2.Properties.Resources.포도;
            this.pb1.Location = new System.Drawing.Point(211, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(459, 271);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 10;
            this.pb1.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(689, 400);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(99, 38);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "종료";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(590, 299);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(80, 26);
            this.btnin.TabIndex = 8;
            this.btnin.Text = "입력";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "과일 칼로리 계산기";
            // 
            // apcheckbox
            // 
            this.apcheckbox.AutoSize = true;
            this.apcheckbox.Location = new System.Drawing.Point(15, 56);
            this.apcheckbox.Name = "apcheckbox";
            this.apcheckbox.Size = new System.Drawing.Size(58, 19);
            this.apcheckbox.TabIndex = 17;
            this.apcheckbox.TabStop = true;
            this.apcheckbox.Text = "사과";
            this.apcheckbox.UseVisualStyleBackColor = true;
            this.apcheckbox.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // bacheckbox
            // 
            this.bacheckbox.AutoSize = true;
            this.bacheckbox.Location = new System.Drawing.Point(15, 99);
            this.bacheckbox.Name = "bacheckbox";
            this.bacheckbox.Size = new System.Drawing.Size(73, 19);
            this.bacheckbox.TabIndex = 18;
            this.bacheckbox.TabStop = true;
            this.bacheckbox.Text = "바나나";
            this.bacheckbox.UseVisualStyleBackColor = true;
            this.bacheckbox.CheckedChanged += new System.EventHandler(this.barbtn_CheckedChanged);
            // 
            // gacheckbox
            // 
            this.gacheckbox.AutoSize = true;
            this.gacheckbox.Location = new System.Drawing.Point(15, 146);
            this.gacheckbox.Name = "gacheckbox";
            this.gacheckbox.Size = new System.Drawing.Size(58, 19);
            this.gacheckbox.TabIndex = 19;
            this.gacheckbox.TabStop = true;
            this.gacheckbox.Text = "포도";
            this.gacheckbox.UseVisualStyleBackColor = true;
            this.gacheckbox.CheckedChanged += new System.EventHandler(this.gacheckbox_CheckedChanged);
            // 
            // lb_cal
            // 
            this.lb_cal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lb_cal.Location = new System.Drawing.Point(12, 231);
            this.lb_cal.Name = "lb_cal";
            this.lb_cal.Size = new System.Drawing.Size(137, 30);
            this.lb_cal.TabIndex = 20;
            this.lb_cal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kcal";
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(15, 190);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(106, 23);
            this.btn_c.TabIndex = 22;
            this.btn_c.Text = "칼로리 계산";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "영문 출력:";
            // 
            // lbengout
            // 
            this.lbengout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbengout.Location = new System.Drawing.Point(259, 383);
            this.lbengout.Name = "lbengout";
            this.lbengout.Size = new System.Drawing.Size(310, 29);
            this.lbengout.TabIndex = 24;
            this.lbengout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbengout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_cal);
            this.Controls.Add(this.gacheckbox);
            this.Controls.Add(this.bacheckbox);
            this.Controls.Add(this.apcheckbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbtextout);
            this.Controls.Add(this.tbin);
            this.Controls.Add(this.lbout);
            this.Controls.Add(this.lbin);
            this.Controls.Add(this.pt1);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btnin);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtextout;
        private System.Windows.Forms.TextBox tbin;
        private System.Windows.Forms.Label lbout;
        private System.Windows.Forms.Label lbin;
        private System.Windows.Forms.Label pt1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton apcheckbox;
        private System.Windows.Forms.RadioButton bacheckbox;
        private System.Windows.Forms.RadioButton gacheckbox;
        private System.Windows.Forms.Label lb_cal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbengout;
    }
}

