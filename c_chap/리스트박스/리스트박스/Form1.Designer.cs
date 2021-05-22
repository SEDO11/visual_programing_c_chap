
namespace 리스트박스
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
            this.lb = new System.Windows.Forms.ListBox();
            this.tb = new System.Windows.Forms.TextBox();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 12;
            this.lb.Location = new System.Drawing.Point(12, 39);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(120, 88);
            this.lb.TabIndex = 0;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(12, 12);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(120, 21);
            this.tb.TabIndex = 1;
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(12, 133);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(120, 23);
            this.btn_plus.TabIndex = 2;
            this.btn_plus.Text = "추가";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(12, 162);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(120, 23);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "삭제";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.lb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_del;
    }
}

