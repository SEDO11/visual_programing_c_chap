
namespace 조건문
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
            this.tbin = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.lbresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "성적을 입력하시오: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "평점:";
            // 
            // tbin
            // 
            this.tbin.Location = new System.Drawing.Point(191, 43);
            this.tbin.Name = "tbin";
            this.tbin.Size = new System.Drawing.Size(319, 25);
            this.tbin.TabIndex = 2;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(403, 107);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(107, 36);
            this.btn.TabIndex = 3;
            this.btn.Text = "평점 환산";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbresult
            // 
            this.lbresult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbresult.Location = new System.Drawing.Point(116, 107);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(266, 32);
            this.lbresult.TabIndex = 4;
            this.lbresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.tbin);
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
        private System.Windows.Forms.TextBox tbin;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lbresult;
    }
}

