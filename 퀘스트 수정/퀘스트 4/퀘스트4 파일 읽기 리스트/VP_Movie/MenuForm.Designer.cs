
namespace VP_Movie
{
    partial class MenuForm
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
            this.btnUserSelct = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnRv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUserSelct
            // 
            this.btnUserSelct.Location = new System.Drawing.Point(164, 12);
            this.btnUserSelct.Name = "btnUserSelct";
            this.btnUserSelct.Size = new System.Drawing.Size(105, 58);
            this.btnUserSelct.TabIndex = 6;
            this.btnUserSelct.Text = "유저 확인";
            this.btnUserSelct.UseVisualStyleBackColor = true;
            this.btnUserSelct.Click += new System.EventHandler(this.btnUserSelct_Click);
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblUser.Font = new System.Drawing.Font("굴림", 12F);
            this.lblUser.Location = new System.Drawing.Point(12, 97);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(257, 51);
            this.lblUser.TabIndex = 5;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRv
            // 
            this.btnRv.Location = new System.Drawing.Point(12, 12);
            this.btnRv.Name = "btnRv";
            this.btnRv.Size = new System.Drawing.Size(103, 58);
            this.btnRv.TabIndex = 4;
            this.btnRv.Text = "영화 예매하기";
            this.btnRv.UseVisualStyleBackColor = true;
            this.btnRv.Click += new System.EventHandler(this.btnRv_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 168);
            this.Controls.Add(this.btnUserSelct);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnRv);
            this.Name = "MenuForm";
            this.Text = "메뉴";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserSelct;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnRv;
    }
}