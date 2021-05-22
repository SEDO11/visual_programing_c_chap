
namespace _3week_C_F
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
            this.tb = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.lbCtoF = new System.Windows.Forms.Label();
            this.lbFtoC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(154, 49);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(273, 25);
            this.tb.TabIndex = 0;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(79, 52);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(67, 15);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "온도입력";
            this.lb1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(82, 107);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(344, 36);
            this.btn.TabIndex = 2;
            this.btn.Text = "변환";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbCtoF
            // 
            this.lbCtoF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbCtoF.Location = new System.Drawing.Point(85, 190);
            this.lbCtoF.Name = "lbCtoF";
            this.lbCtoF.Size = new System.Drawing.Size(342, 38);
            this.lbCtoF.TabIndex = 3;
            // 
            // lbFtoC
            // 
            this.lbFtoC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbFtoC.Location = new System.Drawing.Point(85, 258);
            this.lbFtoC.Name = "lbFtoC";
            this.lbFtoC.Size = new System.Drawing.Size(342, 47);
            this.lbFtoC.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbFtoC);
            this.Controls.Add(this.lbCtoF);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lbCtoF;
        private System.Windows.Forms.Label lbFtoC;
    }
}

