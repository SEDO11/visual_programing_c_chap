
namespace 누적_값_계산
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
            this.tbstart = new System.Windows.Forms.TextBox();
            this.tbend = new System.Windows.Forms.TextBox();
            this.btn_col = new System.Windows.Forms.Button();
            this.lb_out = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "누적 종료값:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "누적 시작값:";
            // 
            // tbstart
            // 
            this.tbstart.Location = new System.Drawing.Point(141, 26);
            this.tbstart.Name = "tbstart";
            this.tbstart.Size = new System.Drawing.Size(369, 21);
            this.tbstart.TabIndex = 2;
            // 
            // tbend
            // 
            this.tbend.Location = new System.Drawing.Point(141, 153);
            this.tbend.Name = "tbend";
            this.tbend.Size = new System.Drawing.Size(369, 21);
            this.tbend.TabIndex = 3;
            // 
            // btn_col
            // 
            this.btn_col.Location = new System.Drawing.Point(435, 242);
            this.btn_col.Name = "btn_col";
            this.btn_col.Size = new System.Drawing.Size(75, 23);
            this.btn_col.TabIndex = 4;
            this.btn_col.Text = "계산";
            this.btn_col.UseVisualStyleBackColor = true;
            this.btn_col.Click += new System.EventHandler(this.btn_col_Click);
            // 
            // lb_out
            // 
            this.lb_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lb_out.Location = new System.Drawing.Point(139, 242);
            this.lb_out.Name = "lb_out";
            this.lb_out.Size = new System.Drawing.Size(255, 23);
            this.lb_out.TabIndex = 5;
            this.lb_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 318);
            this.Controls.Add(this.lb_out);
            this.Controls.Add(this.btn_col);
            this.Controls.Add(this.tbend);
            this.Controls.Add(this.tbstart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "누적 값 계산";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbstart;
        private System.Windows.Forms.TextBox tbend;
        private System.Windows.Forms.Button btn_col;
        private System.Windows.Forms.Label lb_out;
    }
}

