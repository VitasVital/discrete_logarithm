
namespace InfoBezWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 733);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "RSA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 118);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 39);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 299);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "P:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 352);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Q:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Исходное сообщение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Битность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 563);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "n:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 506);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 32);
            this.label7.TabIndex = 8;
            this.label7.Text = "φ(n):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 458);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 32);
            this.label8.TabIndex = 11;
            this.label8.Text = "d:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 405);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 32);
            this.label9.TabIndex = 10;
            this.label9.Text = "e:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 643);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(340, 32);
            this.label10.TabIndex = 12;
            this.label10.Text = "Шифр исходного сообщения:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(811, 182);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 32);
            this.label11.TabIndex = 14;
            this.label11.Text = "Криптограмма";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(811, 288);
            this.textBox4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(397, 39);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(811, 341);
            this.textBox5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(397, 39);
            this.textBox5.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(767, 288);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 32);
            this.label12.TabIndex = 17;
            this.label12.Text = "d:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(769, 341);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 32);
            this.label13.TabIndex = 18;
            this.label13.Text = "n:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(811, 733);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 61);
            this.button2.TabIndex = 19;
            this.button2.Text = "Расшифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(811, 643);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(340, 32);
            this.label14.TabIndex = 20;
            this.label14.Text = "Расшифровка криптограммы:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 234);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(397, 39);
            this.textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(811, 235);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(397, 39);
            this.textBox3.TabIndex = 22;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(811, 680);
            this.textBox6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(397, 39);
            this.textBox6.TabIndex = 23;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(101, 299);
            this.textBox7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(397, 39);
            this.textBox7.TabIndex = 24;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(101, 352);
            this.textBox8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(397, 39);
            this.textBox8.TabIndex = 25;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(101, 405);
            this.textBox9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(397, 39);
            this.textBox9.TabIndex = 26;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(101, 458);
            this.textBox10.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(397, 39);
            this.textBox10.TabIndex = 27;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(101, 510);
            this.textBox11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(397, 39);
            this.textBox11.TabIndex = 28;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(101, 563);
            this.textBox12.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(397, 39);
            this.textBox12.TabIndex = 29;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(101, 680);
            this.textBox13.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(397, 39);
            this.textBox13.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 867);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
    }
}

