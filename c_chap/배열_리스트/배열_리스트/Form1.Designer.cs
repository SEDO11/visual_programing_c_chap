
namespace 배열_리스트
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
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.tbSecond = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_in = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBefore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAfter = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFirst
            // 
            this.tbFirst.Location = new System.Drawing.Point(119, 35);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(135, 25);
            this.tbFirst.TabIndex = 0;
            // 
            // tbSecond
            // 
            this.tbSecond.Location = new System.Drawing.Point(383, 35);
            this.tbSecond.Name = "tbSecond";
            this.tbSecond.Size = new System.Drawing.Size(135, 25);
            this.tbSecond.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "첫 번째 자료:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "두 번째 자료:";
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(262, 103);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(75, 23);
            this.btn_in.TabIndex = 4;
            this.btn_in.Text = "입력";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "교환전:";
            // 
            // lblBefore
            // 
            this.lblBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblBefore.Location = new System.Drawing.Point(134, 194);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(324, 55);
            this.lblBefore.TabIndex = 6;
            this.lblBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "교환메소드 내:";
            // 
            // lblAfter
            // 
            this.lblAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAfter.Location = new System.Drawing.Point(134, 299);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(324, 55);
            this.lblAfter.TabIndex = 8;
            this.lblAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAfter.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOut
            // 
            this.lblOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblOut.Location = new System.Drawing.Point(134, 400);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(324, 55);
            this.lblOut.TabIndex = 9;
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(21, 418);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(107, 15);
            this.lbl6.TabIndex = 10;
            this.lbl6.Text = "교환메소드 외:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 496);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblAfter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBefore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSecond);
            this.Controls.Add(this.tbFirst);
            this.Name = "Form1";
            this.Text = "자료의 교환";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.TextBox tbSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBefore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lbl6;
    }
}

