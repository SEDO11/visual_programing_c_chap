
namespace while문
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
            this.btn_ruf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ruf
            // 
            this.btn_ruf.Location = new System.Drawing.Point(60, 52);
            this.btn_ruf.Name = "btn_ruf";
            this.btn_ruf.Size = new System.Drawing.Size(162, 104);
            this.btn_ruf.TabIndex = 0;
            this.btn_ruf.Text = "루프 시작";
            this.btn_ruf.UseVisualStyleBackColor = true;
            this.btn_ruf.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 220);
            this.Controls.Add(this.btn_ruf);
            this.Name = "Form1";
            this.Text = "while문 연습";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ruf;
    }
}

