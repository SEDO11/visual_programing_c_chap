
namespace _9_1사용자클래스
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbS = new System.Windows.Forms.TextBox();
            this.tbE = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "시작값:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "종료값:";
            // 
            // tbS
            // 
            this.tbS.Location = new System.Drawing.Point(130, 44);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(149, 25);
            this.tbS.TabIndex = 2;
            // 
            // tbE
            // 
            this.tbE.Location = new System.Drawing.Point(427, 44);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(149, 25);
            this.tbE.TabIndex = 3;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(272, 95);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(94, 37);
            this.btn.TabIndex = 4;
            this.btn.Text = "입력";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "총합:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblSum
            // 
            this.lblSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblSum.Location = new System.Drawing.Point(269, 164);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(166, 37);
            this.lblSum.TabIndex = 6;
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.tbE);
            this.Controls.Add(this.tbS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbS;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSum;
    }
}

