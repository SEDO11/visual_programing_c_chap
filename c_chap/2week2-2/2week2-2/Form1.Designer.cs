
namespace _2week2_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbout = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "학번";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(112, 104);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(197, 25);
            this.tb1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "학번을 읽고 에코:";
            // 
            // lbout
            // 
            this.lbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbout.Location = new System.Drawing.Point(201, 152);
            this.lbout.Name = "lbout";
            this.lbout.Size = new System.Drawing.Size(108, 42);
            this.lbout.TabIndex = 3;
            this.lbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(204, 215);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(105, 38);
            this.btn.TabIndex = 4;
            this.btn.Text = "학번 출력";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 76);
            this.label4.TabIndex = 5;
            this.label4.Text = "실행순서: 텍스트박스에 학번을 입력하고 학번 출력 버튼을 눌러 붉은색에 표시";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(204, 294);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(105, 35);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "종료";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 341);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lbout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "텍스트박스 예제";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbout;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnexit;
    }
}

