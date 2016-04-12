namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.tbR1 = new System.Windows.Forms.TextBox();
            this.tbI1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbI2 = new System.Windows.Forms.TextBox();
            this.tbR2 = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.bDodawanie = new System.Windows.Forms.Button();
            this.bOdejmowanie = new System.Windows.Forms.Button();
            this.bMnożenie = new System.Windows.Forms.Button();
            this.bDzielenie = new System.Windows.Forms.Button();
            this.bRownosc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbR1
            // 
            this.tbR1.Location = new System.Drawing.Point(12, 70);
            this.tbR1.Name = "tbR1";
            this.tbR1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbR1.Size = new System.Drawing.Size(60, 20);
            this.tbR1.TabIndex = 0;
            this.tbR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbI1
            // 
            this.tbI1.Location = new System.Drawing.Point(93, 70);
            this.tbI1.Name = "tbI1";
            this.tbI1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbI1.Size = new System.Drawing.Size(60, 20);
            this.tbI1.TabIndex = 1;
            this.tbI1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "+";
            // 
            // tbI2
            // 
            this.tbI2.Location = new System.Drawing.Point(299, 70);
            this.tbI2.Name = "tbI2";
            this.tbI2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbI2.Size = new System.Drawing.Size(60, 20);
            this.tbI2.TabIndex = 4;
            this.tbI2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbR2
            // 
            this.tbR2.Location = new System.Drawing.Point(214, 70);
            this.tbR2.Name = "tbR2";
            this.tbR2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbR2.Size = new System.Drawing.Size(60, 20);
            this.tbR2.TabIndex = 3;
            this.tbR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbResult.Location = new System.Drawing.Point(12, 23);
            this.tbResult.Name = "tbResult";
            this.tbResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbResult.Size = new System.Drawing.Size(367, 20);
            this.tbResult.TabIndex = 6;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bDodawanie
            // 
            this.bDodawanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDodawanie.Location = new System.Drawing.Point(37, 123);
            this.bDodawanie.Name = "bDodawanie";
            this.bDodawanie.Size = new System.Drawing.Size(50, 50);
            this.bDodawanie.TabIndex = 7;
            this.bDodawanie.Text = "+";
            this.bDodawanie.UseVisualStyleBackColor = true;
            this.bDodawanie.Click += new System.EventHandler(this.bDodawanie_Click);
            // 
            // bOdejmowanie
            // 
            this.bOdejmowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bOdejmowanie.Location = new System.Drawing.Point(93, 123);
            this.bOdejmowanie.Name = "bOdejmowanie";
            this.bOdejmowanie.Size = new System.Drawing.Size(50, 50);
            this.bOdejmowanie.TabIndex = 8;
            this.bOdejmowanie.Text = "-";
            this.bOdejmowanie.UseVisualStyleBackColor = true;
            this.bOdejmowanie.Click += new System.EventHandler(this.bOdejmowanie_Click);
            // 
            // bMnożenie
            // 
            this.bMnożenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMnożenie.Location = new System.Drawing.Point(37, 181);
            this.bMnożenie.Name = "bMnożenie";
            this.bMnożenie.Size = new System.Drawing.Size(50, 50);
            this.bMnożenie.TabIndex = 9;
            this.bMnożenie.Text = "*";
            this.bMnożenie.UseVisualStyleBackColor = true;
            this.bMnożenie.Click += new System.EventHandler(this.bMnożenie_Click);
            // 
            // bDzielenie
            // 
            this.bDzielenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDzielenie.Location = new System.Drawing.Point(93, 181);
            this.bDzielenie.Name = "bDzielenie";
            this.bDzielenie.Size = new System.Drawing.Size(50, 50);
            this.bDzielenie.TabIndex = 10;
            this.bDzielenie.Text = "/";
            this.bDzielenie.UseVisualStyleBackColor = true;
            this.bDzielenie.Click += new System.EventHandler(this.bDzielenie_Click);
            // 
            // bRownosc
            // 
            this.bRownosc.Location = new System.Drawing.Point(167, 208);
            this.bRownosc.Name = "bRownosc";
            this.bRownosc.Size = new System.Drawing.Size(75, 23);
            this.bRownosc.TabIndex = 11;
            this.bRownosc.Text = "Porówanie";
            this.bRownosc.UseVisualStyleBackColor = true;
            this.bRownosc.Click += new System.EventHandler(this.bRownosc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(22, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Wynik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pierwsza zespolona";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Druga zespolona";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(159, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "i";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(365, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "i";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 258);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bRownosc);
            this.Controls.Add(this.bDzielenie);
            this.Controls.Add(this.bMnożenie);
            this.Controls.Add(this.bOdejmowanie);
            this.Controls.Add(this.bDodawanie);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbI2);
            this.Controls.Add(this.tbR2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbI1);
            this.Controls.Add(this.tbR1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Kalkulator Liczb Zespolonych";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbR1;
        private System.Windows.Forms.TextBox tbI1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbI2;
        private System.Windows.Forms.TextBox tbR2;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button bDodawanie;
        private System.Windows.Forms.Button bOdejmowanie;
        private System.Windows.Forms.Button bMnożenie;
        private System.Windows.Forms.Button bDzielenie;
        private System.Windows.Forms.Button bRownosc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

