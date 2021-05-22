
namespace _3_1_1
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
            this.lbic = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbcm = new System.Windows.Forms.Label();
            this.lbcmout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbic
            // 
            this.lbic.AutoSize = true;
            this.lbic.Location = new System.Drawing.Point(33, 30);
            this.lbic.Name = "lbic";
            this.lbic.Size = new System.Drawing.Size(77, 15);
            this.lbic.TabIndex = 0;
            this.lbic.Text = "인치 입력:";
            this.lbic.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(135, 23);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(252, 25);
            this.tb.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "변환";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbcm
            // 
            this.lbcm.AutoSize = true;
            this.lbcm.Location = new System.Drawing.Point(54, 167);
            this.lbcm.Name = "lbcm";
            this.lbcm.Size = new System.Drawing.Size(56, 15);
            this.lbcm.TabIndex = 4;
            this.lbcm.Text = "cm출력";
            // 
            // lbcmout
            // 
            this.lbcmout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbcmout.Location = new System.Drawing.Point(132, 167);
            this.lbcmout.Name = "lbcmout";
            this.lbcmout.Size = new System.Drawing.Size(255, 52);
            this.lbcmout.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 307);
            this.Controls.Add(this.lbcmout);
            this.Controls.Add(this.lbcm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.lbic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbic;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbcm;
        private System.Windows.Forms.Label lbcmout;
    }
}

