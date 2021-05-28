
namespace _11_2성별_언어_응용코딩
{
    partial class lngFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkEng = new System.Windows.Forms.CheckBox();
            this.chkChin = new System.Windows.Forms.CheckBox();
            this.chkJpn = new System.Windows.Forms.CheckBox();
            this.btnLng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkEng
            // 
            this.chkEng.AutoSize = true;
            this.chkEng.Location = new System.Drawing.Point(91, 51);
            this.chkEng.Name = "chkEng";
            this.chkEng.Size = new System.Drawing.Size(59, 19);
            this.chkEng.TabIndex = 0;
            this.chkEng.Text = "영어";
            this.chkEng.UseVisualStyleBackColor = true;
            // 
            // chkChin
            // 
            this.chkChin.AutoSize = true;
            this.chkChin.Location = new System.Drawing.Point(91, 181);
            this.chkChin.Name = "chkChin";
            this.chkChin.Size = new System.Drawing.Size(74, 19);
            this.chkChin.TabIndex = 1;
            this.chkChin.Text = "중국어";
            this.chkChin.UseVisualStyleBackColor = true;
            // 
            // chkJpn
            // 
            this.chkJpn.AutoSize = true;
            this.chkJpn.Location = new System.Drawing.Point(91, 115);
            this.chkJpn.Name = "chkJpn";
            this.chkJpn.Size = new System.Drawing.Size(74, 19);
            this.chkJpn.TabIndex = 2;
            this.chkJpn.Text = "일본어";
            this.chkJpn.UseVisualStyleBackColor = true;
            // 
            // btnLng
            // 
            this.btnLng.Location = new System.Drawing.Point(91, 240);
            this.btnLng.Name = "btnLng";
            this.btnLng.Size = new System.Drawing.Size(182, 50);
            this.btnLng.TabIndex = 3;
            this.btnLng.Text = "언어선택 완료";
            this.btnLng.UseVisualStyleBackColor = true;
            this.btnLng.Click += new System.EventHandler(this.button1_Click);
            // 
            // lngFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLng);
            this.Controls.Add(this.chkJpn);
            this.Controls.Add(this.chkChin);
            this.Controls.Add(this.chkEng);
            this.Name = "lngFrm";
            this.Text = "언어 선택";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEng;
        private System.Windows.Forms.CheckBox chkChin;
        private System.Windows.Forms.CheckBox chkJpn;
        private System.Windows.Forms.Button btnLng;
    }
}