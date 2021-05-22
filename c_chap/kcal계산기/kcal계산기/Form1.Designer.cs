
namespace kcal계산기
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbWM = new System.Windows.Forms.PictureBox();
            this.pbBNN = new System.Windows.Forms.PictureBox();
            this.pbGP = new System.Windows.Forms.PictureBox();
            this.pbAP = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbresult = new System.Windows.Forms.Label();
            this.btnRS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBNN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAP)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWM
            // 
            this.pbWM.Image = ((System.Drawing.Image)(resources.GetObject("pbWM.Image")));
            this.pbWM.Location = new System.Drawing.Point(52, 37);
            this.pbWM.Name = "pbWM";
            this.pbWM.Size = new System.Drawing.Size(148, 105);
            this.pbWM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWM.TabIndex = 0;
            this.pbWM.TabStop = false;
            this.pbWM.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbBNN
            // 
            this.pbBNN.Image = global::kcal계산기.Properties.Resources.바나나;
            this.pbBNN.Location = new System.Drawing.Point(252, 37);
            this.pbBNN.Name = "pbBNN";
            this.pbBNN.Size = new System.Drawing.Size(148, 105);
            this.pbBNN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBNN.TabIndex = 1;
            this.pbBNN.TabStop = false;
            this.pbBNN.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbGP
            // 
            this.pbGP.Image = global::kcal계산기.Properties.Resources.포도;
            this.pbGP.Location = new System.Drawing.Point(252, 194);
            this.pbGP.Name = "pbGP";
            this.pbGP.Size = new System.Drawing.Size(148, 105);
            this.pbGP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGP.TabIndex = 3;
            this.pbGP.TabStop = false;
            this.pbGP.Click += new System.EventHandler(this.pbGP_Click);
            // 
            // pbAP
            // 
            this.pbAP.Image = global::kcal계산기.Properties.Resources.사과;
            this.pbAP.Location = new System.Drawing.Point(52, 194);
            this.pbAP.Name = "pbAP";
            this.pbAP.Size = new System.Drawing.Size(148, 106);
            this.pbAP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAP.TabIndex = 2;
            this.pbAP.TabStop = false;
            this.pbAP.Click += new System.EventHandler(this.pbAP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "총 칼로리:";
            // 
            // lbresult
            // 
            this.lbresult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbresult.Location = new System.Drawing.Point(52, 369);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(244, 44);
            this.lbresult.TabIndex = 5;
            this.lbresult.Text = "0";
            this.lbresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRS
            // 
            this.btnRS.Location = new System.Drawing.Point(325, 381);
            this.btnRS.Name = "btnRS";
            this.btnRS.Size = new System.Drawing.Size(75, 23);
            this.btnRS.TabIndex = 6;
            this.btnRS.Text = "리셋";
            this.btnRS.UseVisualStyleBackColor = true;
            this.btnRS.Click += new System.EventHandler(this.btnRS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.btnRS);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbGP);
            this.Controls.Add(this.pbAP);
            this.Controls.Add(this.pbBNN);
            this.Controls.Add(this.pbWM);
            this.Name = "Form1";
            this.Text = "칼로리 계산기";
            ((System.ComponentModel.ISupportInitialize)(this.pbWM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBNN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWM;
        private System.Windows.Forms.PictureBox pbBNN;
        private System.Windows.Forms.PictureBox pbGP;
        private System.Windows.Forms.PictureBox pbAP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbresult;
        private System.Windows.Forms.Button btnRS;
    }
}

