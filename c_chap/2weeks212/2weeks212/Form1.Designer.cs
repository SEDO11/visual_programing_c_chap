
namespace _2weeks212
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnanswer = new System.Windows.Forms.Button();
            this.labelanswer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonfront = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.pbtcard = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbtcard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "여기는 대한민국의 수도 서울입니다.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "여기는 대한민국의 수도 서울입니다.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "대한민국의 수도는 어디입니까?";
            // 
            // btnanswer
            // 
            this.btnanswer.Location = new System.Drawing.Point(542, 165);
            this.btnanswer.Name = "btnanswer";
            this.btnanswer.Size = new System.Drawing.Size(198, 31);
            this.btnanswer.TabIndex = 3;
            this.btnanswer.Text = "정답을 확인하려면 클릭";
            this.btnanswer.UseVisualStyleBackColor = true;
            this.btnanswer.Click += new System.EventHandler(this.btnanswer_Click);
            // 
            // labelanswer
            // 
            this.labelanswer.BackColor = System.Drawing.SystemColors.Info;
            this.labelanswer.Location = new System.Drawing.Point(570, 27);
            this.labelanswer.Name = "labelanswer";
            this.labelanswer.Size = new System.Drawing.Size(142, 54);
            this.labelanswer.TabIndex = 4;
            this.labelanswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(35, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(456, 40);
            this.label4.TabIndex = 6;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonfront
            // 
            this.buttonfront.Location = new System.Drawing.Point(824, 359);
            this.buttonfront.Name = "buttonfront";
            this.buttonfront.Size = new System.Drawing.Size(75, 23);
            this.buttonfront.TabIndex = 8;
            this.buttonfront.Text = "앞면";
            this.buttonfront.UseVisualStyleBackColor = true;
            this.buttonfront.Click += new System.EventHandler(this.buttonfront_Click);
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(1000, 357);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(88, 29);
            this.buttonback.TabIndex = 9;
            this.buttonback.Text = "뒷면";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // pbtcard
            // 
            this.pbtcard.Image = global::_2weeks212.Properties.Resources._5fdb48a0e626d53a76e2dd81c28a8b860d71a226;
            this.pbtcard.Location = new System.Drawing.Point(853, 96);
            this.pbtcard.Name = "pbtcard";
            this.pbtcard.Size = new System.Drawing.Size(168, 216);
            this.pbtcard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtcard.TabIndex = 7;
            this.pbtcard.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_2weeks212.Properties.Resources.autumn_4656877_1920;
            this.pictureBox1.Location = new System.Drawing.Point(38, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 512);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.buttonfront);
            this.Controls.Add(this.pbtcard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelanswer);
            this.Controls.Add(this.btnanswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbtcard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnanswer;
        private System.Windows.Forms.Label labelanswer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbtcard;
        private System.Windows.Forms.Button buttonfront;
        private System.Windows.Forms.Button buttonback;
    }
}

