
namespace fruitsBox
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
            this.btn = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbFruits = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFruits = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(106, 139);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(186, 54);
            this.btn.TabIndex = 9;
            this.btn.Text = "추가";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(106, 84);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(186, 25);
            this.tbPrice.TabIndex = 8;
            // 
            // tbFruits
            // 
            this.tbFruits.Location = new System.Drawing.Point(106, 34);
            this.tbFruits.Name = "tbFruits";
            this.tbFruits.Size = new System.Drawing.Size(186, 25);
            this.tbFruits.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "가격:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "과일명:";
            // 
            // lbFruits
            // 
            this.lbFruits.FormattingEnabled = true;
            this.lbFruits.ItemHeight = 15;
            this.lbFruits.Location = new System.Drawing.Point(356, 42);
            this.lbFruits.Name = "lbFruits";
            this.lbFruits.Size = new System.Drawing.Size(168, 139);
            this.lbFruits.TabIndex = 10;
            this.lbFruits.SelectedIndexChanged += new System.EventHandler(this.lbFruits_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbFruits);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbFruits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbFruits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbFruits;
    }
}

