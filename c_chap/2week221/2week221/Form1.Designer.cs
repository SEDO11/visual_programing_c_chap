
namespace _2week221
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
            this.minin = new System.Windows.Forms.Label();
            this.maxin = new System.Windows.Forms.Label();
            this.minout = new System.Windows.Forms.Label();
            this.maxout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minin
            // 
            this.minin.AutoSize = true;
            this.minin.Location = new System.Drawing.Point(36, 33);
            this.minin.Name = "minin";
            this.minin.Size = new System.Drawing.Size(57, 15);
            this.minin.TabIndex = 0;
            this.minin.Text = "최솟값:";
            // 
            // maxin
            // 
            this.maxin.AutoSize = true;
            this.maxin.Location = new System.Drawing.Point(36, 87);
            this.maxin.Name = "maxin";
            this.maxin.Size = new System.Drawing.Size(57, 15);
            this.maxin.TabIndex = 1;
            this.maxin.Text = "최댓값:";
            // 
            // minout
            // 
            this.minout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.minout.Location = new System.Drawing.Point(125, 28);
            this.minout.Name = "minout";
            this.minout.Size = new System.Drawing.Size(115, 24);
            this.minout.TabIndex = 2;
            this.minout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxout
            // 
            this.maxout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.maxout.Location = new System.Drawing.Point(128, 81);
            this.maxout.Name = "maxout";
            this.maxout.Size = new System.Drawing.Size(112, 27);
            this.maxout.TabIndex = 3;
            this.maxout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 370);
            this.Controls.Add(this.maxout);
            this.Controls.Add(this.minout);
            this.Controls.Add(this.maxin);
            this.Controls.Add(this.minin);
            this.Name = "Form1";
            this.Text = "최대, 최소값 구하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minin;
        private System.Windows.Forms.Label maxin;
        private System.Windows.Forms.Label minout;
        private System.Windows.Forms.Label maxout;
    }
}

