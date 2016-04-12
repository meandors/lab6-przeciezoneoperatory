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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.bDodawanie = new System.Windows.Forms.Button();
            this.bOdejmowanie = new System.Windows.Forms.Button();
            this.bMnożenie = new System.Windows.Forms.Button();
            this.bDzielenie = new System.Windows.Forms.Button();
            this.bRownosc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "+ j";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "+ j";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(385, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(255, 53);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 12);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(473, 20);
            this.textBox5.TabIndex = 6;
            // 
            // bDodawanie
            // 
            this.bDodawanie.Location = new System.Drawing.Point(37, 123);
            this.bDodawanie.Name = "bDodawanie";
            this.bDodawanie.Size = new System.Drawing.Size(75, 23);
            this.bDodawanie.TabIndex = 7;
            this.bDodawanie.Text = "Dodawanie";
            this.bDodawanie.UseVisualStyleBackColor = true;
            // 
            // bOdejmowanie
            // 
            this.bOdejmowanie.Location = new System.Drawing.Point(142, 123);
            this.bOdejmowanie.Name = "bOdejmowanie";
            this.bOdejmowanie.Size = new System.Drawing.Size(84, 23);
            this.bOdejmowanie.TabIndex = 8;
            this.bOdejmowanie.Text = "Odejmowanie";
            this.bOdejmowanie.UseVisualStyleBackColor = true;
            // 
            // bMnożenie
            // 
            this.bMnożenie.Location = new System.Drawing.Point(232, 123);
            this.bMnożenie.Name = "bMnożenie";
            this.bMnożenie.Size = new System.Drawing.Size(75, 23);
            this.bMnożenie.TabIndex = 9;
            this.bMnożenie.Text = "Mnożenie";
            this.bMnożenie.UseVisualStyleBackColor = true;
            this.bMnożenie.Click += new System.EventHandler(this.bMnożenie_Click);
            // 
            // bDzielenie
            // 
            this.bDzielenie.Location = new System.Drawing.Point(364, 123);
            this.bDzielenie.Name = "bDzielenie";
            this.bDzielenie.Size = new System.Drawing.Size(75, 23);
            this.bDzielenie.TabIndex = 10;
            this.bDzielenie.Text = "Dzielenie";
            this.bDzielenie.UseVisualStyleBackColor = true;
            // 
            // bRownosc
            // 
            this.bRownosc.Location = new System.Drawing.Point(200, 187);
            this.bRownosc.Name = "bRownosc";
            this.bRownosc.Size = new System.Drawing.Size(75, 23);
            this.bRownosc.TabIndex = 11;
            this.bRownosc.Text = "Porówanie";
            this.bRownosc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 291);
            this.Controls.Add(this.bRownosc);
            this.Controls.Add(this.bDzielenie);
            this.Controls.Add(this.bMnożenie);
            this.Controls.Add(this.bOdejmowanie);
            this.Controls.Add(this.bDodawanie);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button bDodawanie;
        private System.Windows.Forms.Button bOdejmowanie;
        private System.Windows.Forms.Button bMnożenie;
        private System.Windows.Forms.Button bDzielenie;
        private System.Windows.Forms.Button bRownosc;
    }
}

