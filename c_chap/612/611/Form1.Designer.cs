
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
            this.btn = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_tran = new System.Windows.Forms.Button();
            this.lbresult = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(293, 32);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(272, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "이미지 선택";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lb1.Location = new System.Drawing.Point(605, 94);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(300, 23);
            this.lb1.TabIndex = 2;
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb
            // 
            this.pb.Image = global::_611.Properties.Resources.오류;
            this.pb.Location = new System.Drawing.Point(293, 78);
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
            this.lb2.Location = new System.Drawing.Point(605, 53);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(170, 15);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "2. 이미지를 클릭하세요.";
            this.lb2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "3. 출력된 이미지명을 영문으로 입력하세요.";
            // 
            // btn_tran
            // 
            this.btn_tran.Location = new System.Drawing.Point(608, 259);
            this.btn_tran.Name = "btn_tran";
            this.btn_tran.Size = new System.Drawing.Size(297, 31);
            this.btn_tran.TabIndex = 5;
            this.btn_tran.Text = "4. 판정";
            this.btn_tran.UseVisualStyleBackColor = true;
            this.btn_tran.Click += new System.EventHandler(this.btn_tran_Click);
            // 
            // lbresult
            // 
            this.lbresult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbresult.Location = new System.Drawing.Point(605, 311);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(300, 23);
            this.lbresult.TabIndex = 6;
            this.lbresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(608, 215);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(297, 25);
            this.tb.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 140);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성별";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 140);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "가능한 언어는?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "남성";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(19, 83);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "여성";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(19, 38);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(59, 19);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "영어";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(19, 63);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(74, 19);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "일본어";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(19, 88);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(74, 19);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.Text = "중국어";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 374);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.btn_tran);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.pb);
            this.Name = "Form1";
            this.Text = "컨텐츠 만들기 예";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tran;
        private System.Windows.Forms.Label lbresult;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

