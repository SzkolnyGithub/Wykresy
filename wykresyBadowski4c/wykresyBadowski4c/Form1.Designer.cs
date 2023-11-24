
namespace wykresyBadowski4c
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
            rownanie = new System.Windows.Forms.Label();
            wykres = new System.Windows.Forms.PictureBox();
            a = new System.Windows.Forms.TextBox();
            mZerowe = new System.Windows.Forms.Label();
            b = new System.Windows.Forms.TextBox();
            monotonicznosc = new System.Windows.Forms.Label();
            rysuj = new System.Windows.Forms.Button();
            a1 = new System.Windows.Forms.Label();
            b1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)wykres).BeginInit();
            SuspendLayout();
            // 
            // rownanie
            // 
            rownanie.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rownanie.Location = new System.Drawing.Point(31, 35);
            rownanie.Name = "rownanie";
            rownanie.Size = new System.Drawing.Size(139, 38);
            rownanie.TabIndex = 0;
            rownanie.Text = "y = a x + b";
            // 
            // wykres
            // 
            wykres.BackColor = System.Drawing.SystemColors.Control;
            wykres.Location = new System.Drawing.Point(372, 26);
            wykres.Name = "wykres";
            wykres.Size = new System.Drawing.Size(400, 400);
            wykres.TabIndex = 1;
            wykres.TabStop = false;
            wykres.Paint += wykres_Paint;
            wykres.MouseMove += wykres_MouseMove;
            // 
            // a
            // 
            a.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            a.Location = new System.Drawing.Point(43, 93);
            a.Name = "a";
            a.Size = new System.Drawing.Size(91, 29);
            a.TabIndex = 3;
            // 
            // mZerowe
            // 
            mZerowe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            mZerowe.Location = new System.Drawing.Point(12, 178);
            mZerowe.Name = "mZerowe";
            mZerowe.Size = new System.Drawing.Size(354, 39);
            mZerowe.TabIndex = 5;
            mZerowe.Text = "Miejsce zerowe: ";
            // 
            // b
            // 
            b.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            b.Location = new System.Drawing.Point(43, 144);
            b.Name = "b";
            b.Size = new System.Drawing.Size(91, 29);
            b.TabIndex = 6;
            // 
            // monotonicznosc
            // 
            monotonicznosc.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            monotonicznosc.Location = new System.Drawing.Point(12, 315);
            monotonicznosc.Name = "monotonicznosc";
            monotonicznosc.Size = new System.Drawing.Size(354, 39);
            monotonicznosc.TabIndex = 7;
            monotonicznosc.Text = "Monotoniczność: ";
            // 
            // rysuj
            // 
            rysuj.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rysuj.Location = new System.Drawing.Point(12, 392);
            rysuj.Name = "rysuj";
            rysuj.Size = new System.Drawing.Size(106, 34);
            rysuj.TabIndex = 8;
            rysuj.Text = "Rysuj wykres";
            rysuj.UseVisualStyleBackColor = true;
            rysuj.Click += rysuj_Click;
            // 
            // a1
            // 
            a1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            a1.Location = new System.Drawing.Point(3, 96);
            a1.Name = "a1";
            a1.Size = new System.Drawing.Size(34, 23);
            a1.TabIndex = 9;
            a1.Text = "a = ";
            // 
            // b1
            // 
            b1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            b1.Location = new System.Drawing.Point(3, 144);
            b1.Name = "b1";
            b1.Size = new System.Drawing.Size(34, 23);
            b1.TabIndex = 11;
            b1.Text = "b =";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(b1);
            Controls.Add(a1);
            Controls.Add(rysuj);
            Controls.Add(monotonicznosc);
            Controls.Add(b);
            Controls.Add(mZerowe);
            Controls.Add(a);
            Controls.Add(wykres);
            Controls.Add(rownanie);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Wykresy";
            Load += Form1_Load;
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)wykres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label rownanie;
        private System.Windows.Forms.PictureBox wykres;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label mZerowe;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.Label monotonicznosc;
        private System.Windows.Forms.Button rysuj;
        private System.Windows.Forms.Label a1;
        private System.Windows.Forms.Label b1;
    }
}

