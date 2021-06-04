
namespace CGV로그인화면
{
    partial class NewUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.tbNewId = new System.Windows.Forms.TextBox();
            this.tbNewPw = new System.Windows.Forms.TextBox();
            this.btnUserMake = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(253, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원가입";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "아이디:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "비밀번호:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "이름:";
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(187, 132);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(282, 25);
            this.tbNewName.TabIndex = 5;
            // 
            // tbNewId
            // 
            this.tbNewId.Location = new System.Drawing.Point(187, 180);
            this.tbNewId.Name = "tbNewId";
            this.tbNewId.Size = new System.Drawing.Size(282, 25);
            this.tbNewId.TabIndex = 6;
            // 
            // tbNewPw
            // 
            this.tbNewPw.Location = new System.Drawing.Point(187, 230);
            this.tbNewPw.Name = "tbNewPw";
            this.tbNewPw.Size = new System.Drawing.Size(282, 25);
            this.tbNewPw.TabIndex = 7;
            // 
            // btnUserMake
            // 
            this.btnUserMake.Location = new System.Drawing.Point(534, 365);
            this.btnUserMake.Name = "btnUserMake";
            this.btnUserMake.Size = new System.Drawing.Size(99, 58);
            this.btnUserMake.TabIndex = 9;
            this.btnUserMake.Text = "회원가입";
            this.btnUserMake.UseVisualStyleBackColor = true;
            this.btnUserMake.Click += new System.EventHandler(this.btnUserMake_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 447);
            this.Controls.Add(this.btnUserMake);
            this.Controls.Add(this.tbNewPw);
            this.Controls.Add(this.tbNewId);
            this.Controls.Add(this.tbNewName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewUser";
            this.Text = "회원가입";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUserMake;
        public System.Windows.Forms.TextBox tbNewName;
        public System.Windows.Forms.TextBox tbNewId;
        public System.Windows.Forms.TextBox tbNewPw;
    }
}