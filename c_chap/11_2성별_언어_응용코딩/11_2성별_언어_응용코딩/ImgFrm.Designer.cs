
namespace _11_2성별_언어_응용코딩
{
    partial class ImgFrm
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
            this.btnImg = new System.Windows.Forms.Button();
            this.pbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(36, 30);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(274, 36);
            this.btnImg.TabIndex = 0;
            this.btnImg.Text = "이미지선택";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // pbx
            // 
            this.pbx.Image = global::_11_2성별_언어_응용코딩.Properties.Resources.바나나;
            this.pbx.Location = new System.Drawing.Point(36, 97);
            this.pbx.Name = "pbx";
            this.pbx.Size = new System.Drawing.Size(274, 223);
            this.pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx.TabIndex = 1;
            this.pbx.TabStop = false;
            // 
            // ImgFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 357);
            this.Controls.Add(this.pbx);
            this.Controls.Add(this.btnImg);
            this.Name = "ImgFrm";
            this.Text = "이미지 선택";
            ((System.ComponentModel.ISupportInitialize)(this.pbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.PictureBox pbx;
    }
}