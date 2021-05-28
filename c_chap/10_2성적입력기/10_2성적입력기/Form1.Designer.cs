
namespace _10_2성적입력기
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCsharp = new System.Windows.Forms.TextBox();
            this.tbPython = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(95, 56);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 25);
            this.tbName.TabIndex = 0;
            // 
            // tbCsharp
            // 
            this.tbCsharp.Location = new System.Drawing.Point(95, 140);
            this.tbCsharp.Name = "tbCsharp";
            this.tbCsharp.Size = new System.Drawing.Size(100, 25);
            this.tbCsharp.TabIndex = 1;
            // 
            // tbPython
            // 
            this.tbPython.Location = new System.Drawing.Point(95, 224);
            this.tbPython.Name = "tbPython";
            this.tbPython.Size = new System.Drawing.Size(100, 25);
            this.tbPython.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "이름:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "C#:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "파이썬:";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(220, 116);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(100, 69);
            this.btn.TabIndex = 6;
            this.btn.Text = "입력";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 15;
            this.lb.Location = new System.Drawing.Point(344, 56);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(209, 199);
            this.lb.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPython);
            this.Controls.Add(this.tbCsharp);
            this.Controls.Add(this.tbName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCsharp;
        private System.Windows.Forms.TextBox tbPython;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ListBox lb;
    }
}

