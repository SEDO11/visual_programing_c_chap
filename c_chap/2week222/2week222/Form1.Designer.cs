
namespace _2week222
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
            this.lbdou = new System.Windows.Forms.Label();
            this.lbflo = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbdou
            // 
            this.lbdou.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbdou.Location = new System.Drawing.Point(52, 126);
            this.lbdou.Name = "lbdou";
            this.lbdou.Size = new System.Drawing.Size(202, 27);
            this.lbdou.TabIndex = 7;
            this.lbdou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbflo
            // 
            this.lbflo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbflo.Location = new System.Drawing.Point(52, 73);
            this.lbflo.Name = "lbflo";
            this.lbflo.Size = new System.Drawing.Size(202, 24);
            this.lbflo.TabIndex = 6;
            this.lbflo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(49, 102);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(213, 15);
            this.lb2.TabIndex = 5;
            this.lb2.Text = "double:0.123456789123456789";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(49, 48);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(122, 15);
            this.lb1.TabIndex = 4;
            this.lb1.Text = "float: 0.12345678";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbdou);
            this.Controls.Add(this.lbflo);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdou;
        private System.Windows.Forms.Label lbflo;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
    }
}

