
namespace _41체크박스
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
            this.cbsb = new System.Windows.Forms.CheckBox();
            this.cbbanana = new System.Windows.Forms.CheckBox();
            this.cbapple = new System.Windows.Forms.CheckBox();
            this.btn = new System.Windows.Forms.Button();
            this.lbresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbsb
            // 
            this.cbsb.AutoSize = true;
            this.cbsb.Location = new System.Drawing.Point(34, 37);
            this.cbsb.Name = "cbsb";
            this.cbsb.Size = new System.Drawing.Size(48, 16);
            this.cbsb.TabIndex = 0;
            this.cbsb.Text = "딸기";
            this.cbsb.UseVisualStyleBackColor = true;
            // 
            // cbbanana
            // 
            this.cbbanana.AutoSize = true;
            this.cbbanana.Location = new System.Drawing.Point(34, 78);
            this.cbbanana.Name = "cbbanana";
            this.cbbanana.Size = new System.Drawing.Size(60, 16);
            this.cbbanana.TabIndex = 1;
            this.cbbanana.Text = "바나나";
            this.cbbanana.UseVisualStyleBackColor = true;
            // 
            // cbapple
            // 
            this.cbapple.AutoSize = true;
            this.cbapple.Location = new System.Drawing.Point(34, 121);
            this.cbapple.Name = "cbapple";
            this.cbapple.Size = new System.Drawing.Size(48, 16);
            this.cbapple.TabIndex = 2;
            this.cbapple.Text = "사과";
            this.cbapple.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(34, 165);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(83, 35);
            this.btn.TabIndex = 3;
            this.btn.Text = "확인";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbresult
            // 
            this.lbresult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbresult.Location = new System.Drawing.Point(32, 233);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(136, 52);
            this.lbresult.TabIndex = 4;
            this.lbresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 319);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.cbapple);
            this.Controls.Add(this.cbbanana);
            this.Controls.Add(this.cbsb);
            this.Name = "Form1";
            this.Text = "과일 추";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbsb;
        private System.Windows.Forms.CheckBox cbbanana;
        private System.Windows.Forms.CheckBox cbapple;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lbresult;
    }
}

