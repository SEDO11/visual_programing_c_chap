
namespace 계산기
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
            this.display = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.bbeagi = new System.Windows.Forms.Button();
            this.gobhagi = new System.Windows.Forms.Button();
            this.nanugi = new System.Windows.Forms.Button();
            this.duhagi = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.cancell = new System.Windows.Forms.Button();
            this.nun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(12, 27);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(339, 21);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 72);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(81, 72);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(153, 72);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(153, 148);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(81, 148);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 148);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(153, 224);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(81, 224);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 224);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_click);
            // 
            // bbeagi
            // 
            this.bbeagi.Location = new System.Drawing.Point(228, 224);
            this.bbeagi.Name = "bbeagi";
            this.bbeagi.Size = new System.Drawing.Size(50, 50);
            this.bbeagi.TabIndex = 12;
            this.bbeagi.Text = "-";
            this.bbeagi.UseVisualStyleBackColor = true;
            this.bbeagi.Click += new System.EventHandler(this.op_click);
            // 
            // gobhagi
            // 
            this.gobhagi.Location = new System.Drawing.Point(228, 148);
            this.gobhagi.Name = "gobhagi";
            this.gobhagi.Size = new System.Drawing.Size(50, 50);
            this.gobhagi.TabIndex = 11;
            this.gobhagi.Text = "*";
            this.gobhagi.UseVisualStyleBackColor = true;
            this.gobhagi.Click += new System.EventHandler(this.op_click);
            // 
            // nanugi
            // 
            this.nanugi.Location = new System.Drawing.Point(228, 72);
            this.nanugi.Name = "nanugi";
            this.nanugi.Size = new System.Drawing.Size(50, 50);
            this.nanugi.TabIndex = 10;
            this.nanugi.Text = "/";
            this.nanugi.UseVisualStyleBackColor = true;
            this.nanugi.Click += new System.EventHandler(this.op_click);
            // 
            // duhagi
            // 
            this.duhagi.Location = new System.Drawing.Point(228, 296);
            this.duhagi.Name = "duhagi";
            this.duhagi.Size = new System.Drawing.Size(50, 50);
            this.duhagi.TabIndex = 13;
            this.duhagi.Text = "+";
            this.duhagi.UseVisualStyleBackColor = true;
            this.duhagi.Click += new System.EventHandler(this.op_click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(153, 296);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(50, 50);
            this.dot.TabIndex = 14;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.btn_click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 296);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(119, 50);
            this.btn0.TabIndex = 15;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn_click);
            // 
            // cancell
            // 
            this.cancell.Location = new System.Drawing.Point(301, 72);
            this.cancell.Name = "cancell";
            this.cancell.Size = new System.Drawing.Size(50, 126);
            this.cancell.TabIndex = 16;
            this.cancell.Text = "C";
            this.cancell.UseVisualStyleBackColor = true;
            // 
            // nun
            // 
            this.nun.Location = new System.Drawing.Point(301, 220);
            this.nun.Name = "nun";
            this.nun.Size = new System.Drawing.Size(50, 126);
            this.nun.TabIndex = 17;
            this.nun.Text = "=";
            this.nun.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 377);
            this.Controls.Add(this.nun);
            this.Controls.Add(this.cancell);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.duhagi);
            this.Controls.Add(this.bbeagi);
            this.Controls.Add(this.gobhagi);
            this.Controls.Add(this.nanugi);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button bbeagi;
        private System.Windows.Forms.Button gobhagi;
        private System.Windows.Forms.Button nanugi;
        private System.Windows.Forms.Button duhagi;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button cancell;
        private System.Windows.Forms.Button nun;
    }
}

