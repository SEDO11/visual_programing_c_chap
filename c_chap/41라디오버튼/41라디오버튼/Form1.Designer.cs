
namespace _41라디오버튼
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
            this.btnsb = new System.Windows.Forms.RadioButton();
            this.btnba = new System.Windows.Forms.RadioButton();
            this.btnap = new System.Windows.Forms.RadioButton();
            this.fruitbox = new System.Windows.Forms.GroupBox();
            this.btnwn = new System.Windows.Forms.RadioButton();
            this.btnpn = new System.Windows.Forms.RadioButton();
            this.btnam = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn = new System.Windows.Forms.Button();
            this.fruitbox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsb
            // 
            this.btnsb.AutoSize = true;
            this.btnsb.Location = new System.Drawing.Point(21, 36);
            this.btnsb.Name = "btnsb";
            this.btnsb.Size = new System.Drawing.Size(47, 16);
            this.btnsb.TabIndex = 0;
            this.btnsb.TabStop = true;
            this.btnsb.Text = "딸기";
            this.btnsb.UseVisualStyleBackColor = true;
            this.btnsb.CheckedChanged += new System.EventHandler(this.btnsb_CheckedChanged);
            // 
            // btnba
            // 
            this.btnba.AutoSize = true;
            this.btnba.Location = new System.Drawing.Point(21, 80);
            this.btnba.Name = "btnba";
            this.btnba.Size = new System.Drawing.Size(59, 16);
            this.btnba.TabIndex = 1;
            this.btnba.TabStop = true;
            this.btnba.Text = "바나나";
            this.btnba.UseVisualStyleBackColor = true;
            // 
            // btnap
            // 
            this.btnap.AutoSize = true;
            this.btnap.Location = new System.Drawing.Point(21, 125);
            this.btnap.Name = "btnap";
            this.btnap.Size = new System.Drawing.Size(47, 16);
            this.btnap.TabIndex = 2;
            this.btnap.TabStop = true;
            this.btnap.Text = "사과";
            this.btnap.UseVisualStyleBackColor = true;
            // 
            // fruitbox
            // 
            this.fruitbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fruitbox.Controls.Add(this.btnsb);
            this.fruitbox.Controls.Add(this.btnap);
            this.fruitbox.Controls.Add(this.btnba);
            this.fruitbox.Location = new System.Drawing.Point(26, 26);
            this.fruitbox.Name = "fruitbox";
            this.fruitbox.Size = new System.Drawing.Size(182, 165);
            this.fruitbox.TabIndex = 3;
            this.fruitbox.TabStop = false;
            this.fruitbox.Text = "과일";
            // 
            // btnwn
            // 
            this.btnwn.AutoSize = true;
            this.btnwn.Location = new System.Drawing.Point(30, 34);
            this.btnwn.Name = "btnwn";
            this.btnwn.Size = new System.Drawing.Size(47, 16);
            this.btnwn.TabIndex = 4;
            this.btnwn.TabStop = true;
            this.btnwn.Text = "호두";
            this.btnwn.UseVisualStyleBackColor = true;
            // 
            // btnpn
            // 
            this.btnpn.AutoSize = true;
            this.btnpn.Location = new System.Drawing.Point(30, 78);
            this.btnpn.Name = "btnpn";
            this.btnpn.Size = new System.Drawing.Size(47, 16);
            this.btnpn.TabIndex = 5;
            this.btnpn.TabStop = true;
            this.btnpn.Text = "땅콩";
            this.btnpn.UseVisualStyleBackColor = true;
            // 
            // btnam
            // 
            this.btnam.AutoSize = true;
            this.btnam.Location = new System.Drawing.Point(30, 123);
            this.btnam.Name = "btnam";
            this.btnam.Size = new System.Drawing.Size(59, 16);
            this.btnam.TabIndex = 6;
            this.btnam.TabStop = true;
            this.btnam.Text = "아몬드";
            this.btnam.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnam);
            this.panel1.Controls.Add(this.btnpn);
            this.panel1.Controls.Add(this.btnwn);
            this.panel1.Location = new System.Drawing.Point(253, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 165);
            this.panel1.TabIndex = 7;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(189, 232);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(87, 45);
            this.btn.TabIndex = 8;
            this.btn.Text = "확인";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 312);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fruitbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fruitbox.ResumeLayout(false);
            this.fruitbox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton btnsb;
        private System.Windows.Forms.RadioButton btnba;
        private System.Windows.Forms.RadioButton btnap;
        private System.Windows.Forms.GroupBox fruitbox;
        private System.Windows.Forms.RadioButton btnwn;
        private System.Windows.Forms.RadioButton btnpn;
        private System.Windows.Forms.RadioButton btnam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn;
    }
}

