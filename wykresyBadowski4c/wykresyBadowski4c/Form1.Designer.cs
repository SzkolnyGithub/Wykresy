
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
            this.rownanie = new System.Windows.Forms.Label();
            this.wykres = new System.Windows.Forms.PictureBox();
            this.a = new System.Windows.Forms.TextBox();
            this.mZerowe = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.TextBox();
            this.monotonicznosc = new System.Windows.Forms.Label();
            this.rysuj = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wykres)).BeginInit();
            this.SuspendLayout();
            // 
            // rownanie
            // 
            this.rownanie.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rownanie.Location = new System.Drawing.Point(31, 35);
            this.rownanie.Name = "rownanie";
            this.rownanie.Size = new System.Drawing.Size(139, 38);
            this.rownanie.TabIndex = 0;
            this.rownanie.Text = "y = a x + b";
            // 
            // wykres
            // 
            this.wykres.BackColor = System.Drawing.SystemColors.Control;
            this.wykres.Location = new System.Drawing.Point(372, 26);
            this.wykres.Name = "wykres";
            this.wykres.Size = new System.Drawing.Size(400, 400);
            this.wykres.TabIndex = 1;
            this.wykres.TabStop = false;
            this.wykres.Paint += new System.Windows.Forms.PaintEventHandler(this.wykres_Paint);
            this.wykres.MouseMove += new System.Windows.Forms.MouseEventHandler(this.wykres_MouseMove);
            // 
            // a
            // 
            this.a.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.a.Location = new System.Drawing.Point(43, 93);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(91, 29);
            this.a.TabIndex = 3;
            // 
            // mZerowe
            // 
            this.mZerowe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mZerowe.Location = new System.Drawing.Point(12, 178);
            this.mZerowe.Name = "mZerowe";
            this.mZerowe.Size = new System.Drawing.Size(354, 39);
            this.mZerowe.TabIndex = 5;
            this.mZerowe.Text = "Miejsce zerowe: ";
            // 
            // b
            // 
            this.b.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b.Location = new System.Drawing.Point(43, 144);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(91, 29);
            this.b.TabIndex = 6;
            // 
            // monotonicznosc
            // 
            this.monotonicznosc.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monotonicznosc.Location = new System.Drawing.Point(12, 315);
            this.monotonicznosc.Name = "monotonicznosc";
            this.monotonicznosc.Size = new System.Drawing.Size(354, 39);
            this.monotonicznosc.TabIndex = 7;
            this.monotonicznosc.Text = "Monotoniczność: ";
            // 
            // rysuj
            // 
            this.rysuj.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rysuj.Location = new System.Drawing.Point(12, 392);
            this.rysuj.Name = "rysuj";
            this.rysuj.Size = new System.Drawing.Size(106, 34);
            this.rysuj.TabIndex = 8;
            this.rysuj.Text = "Rysuj wykres";
            this.rysuj.UseVisualStyleBackColor = true;
            this.rysuj.Click += new System.EventHandler(this.rysuj_Click);
            // 
            // a1
            // 
            this.a1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.a1.Location = new System.Drawing.Point(12, 96);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(25, 23);
            this.a1.TabIndex = 9;
            this.a1.Text = "a";
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b1.Location = new System.Drawing.Point(12, 144);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(25, 23);
            this.b1.TabIndex = 11;
            this.b1.Text = "b";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.rysuj);
            this.Controls.Add(this.monotonicznosc);
            this.Controls.Add(this.b);
            this.Controls.Add(this.mZerowe);
            this.Controls.Add(this.a);
            this.Controls.Add(this.wykres);
            this.Controls.Add(this.rownanie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wykres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

