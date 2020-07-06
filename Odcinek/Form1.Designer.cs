namespace Odcinek
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.bres_btn = new System.Windows.Forms.Button();
            this.x0_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.y0_text = new System.Windows.Forms.TextBox();
            this.y1_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.x1_text = new System.Windows.Forms.TextBox();
            this.przy_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.wybor2 = new System.Windows.Forms.Button();
            this.wybor1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bres_btn
            // 
            this.bres_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.bres_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bres_btn.FlatAppearance.BorderSize = 3;
            this.bres_btn.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bres_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.bres_btn.Location = new System.Drawing.Point(813, 94);
            this.bres_btn.Name = "bres_btn";
            this.bres_btn.Size = new System.Drawing.Size(174, 50);
            this.bres_btn.TabIndex = 0;
            this.bres_btn.Text = "Algorytm Bresenhama";
            this.bres_btn.UseVisualStyleBackColor = false;
            this.bres_btn.Click += new System.EventHandler(this.bres_btn_Click);
            // 
            // x0_text
            // 
            this.x0_text.Location = new System.Drawing.Point(466, 118);
            this.x0_text.Name = "x0_text";
            this.x0_text.Size = new System.Drawing.Size(81, 20);
            this.x0_text.TabIndex = 2;
            this.x0_text.TextChanged += new System.EventHandler(this.x0_text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = " y0:";
            // 
            // y0_text
            // 
            this.y0_text.Location = new System.Drawing.Point(466, 150);
            this.y0_text.Name = "y0_text";
            this.y0_text.Size = new System.Drawing.Size(81, 20);
            this.y0_text.TabIndex = 6;
            this.y0_text.TextChanged += new System.EventHandler(this.y0_text_TextChanged);
            // 
            // y1_text
            // 
            this.y1_text.Location = new System.Drawing.Point(662, 150);
            this.y1_text.Name = "y1_text";
            this.y1_text.Size = new System.Drawing.Size(81, 20);
            this.y1_text.TabIndex = 10;
            this.y1_text.TextChanged += new System.EventHandler(this.y1_text_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(627, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "y1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(627, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "x1:";
            // 
            // x1_text
            // 
            this.x1_text.Location = new System.Drawing.Point(662, 118);
            this.x1_text.Name = "x1_text";
            this.x1_text.Size = new System.Drawing.Size(81, 20);
            this.x1_text.TabIndex = 7;
            this.x1_text.TextChanged += new System.EventHandler(this.x1_text_TextChanged);
            // 
            // przy_btn
            // 
            this.przy_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.przy_btn.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.przy_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.przy_btn.Location = new System.Drawing.Point(813, 150);
            this.przy_btn.Name = "przy_btn";
            this.przy_btn.Size = new System.Drawing.Size(174, 48);
            this.przy_btn.TabIndex = 11;
            this.przy_btn.Text = "Algorytm przyrostowy";
            this.przy_btn.UseVisualStyleBackColor = false;
            this.przy_btn.Click += new System.EventHandler(this.przy_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = " x0:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(388, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "RYSOWANIE ODCINKA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "(0,0)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1061, 666);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "(960,440)";
            // 
            // wybor2
            // 
            this.wybor2.BackColor = System.Drawing.Color.Gainsboro;
            this.wybor2.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wybor2.ForeColor = System.Drawing.Color.Black;
            this.wybor2.Location = new System.Drawing.Point(163, 150);
            this.wybor2.Name = "wybor2";
            this.wybor2.Size = new System.Drawing.Size(174, 48);
            this.wybor2.TabIndex = 16;
            this.wybor2.Text = "Zaznaczam";
            this.wybor2.UseVisualStyleBackColor = false;
            this.wybor2.Click += new System.EventHandler(this.wybor2_Click);
            // 
            // wybor1
            // 
            this.wybor1.BackColor = System.Drawing.Color.Gainsboro;
            this.wybor1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.wybor1.FlatAppearance.BorderSize = 3;
            this.wybor1.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wybor1.ForeColor = System.Drawing.Color.Black;
            this.wybor1.Location = new System.Drawing.Point(163, 94);
            this.wybor1.Name = "wybor1";
            this.wybor1.Size = new System.Drawing.Size(174, 50);
            this.wybor1.TabIndex = 15;
            this.wybor1.Text = "Wpisuje punkty";
            this.wybor1.UseVisualStyleBackColor = false;
            this.wybor1.Click += new System.EventHandler(this.wybor1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(373, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(416, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Proszę zaznaczyć 2 krańcowe punkty odcinka na panelu, a następnie wybrać metodę.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(385, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Podaj";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(385, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Podaj";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(586, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "Podaj";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(586, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Podaj";
            // 
            // clear_btn
            // 
            this.clear_btn.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(521, 675);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(129, 31);
            this.clear_btn.TabIndex = 21;
            this.clear_btn.Text = "Od nowa";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(3, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(961, 441);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picture);
            this.panel1.Location = new System.Drawing.Point(87, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 451);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1156, 718);
            this.Controls.Add(this.wybor1);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.wybor2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.przy_btn);
            this.Controls.Add(this.y1_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.x1_text);
            this.Controls.Add(this.y0_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x0_text);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bres_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bres_btn;
        private System.Windows.Forms.TextBox x0_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox y0_text;
        private System.Windows.Forms.TextBox y1_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox x1_text;
        private System.Windows.Forms.Button przy_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button wybor2;
        private System.Windows.Forms.Button wybor1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Panel panel1;
    }
}

