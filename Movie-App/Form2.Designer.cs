namespace Movie_App
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leanguage_lbl = new System.Windows.Forms.Label();
            this.Author_lbl = new System.Windows.Forms.Label();
            this.Country_lbl = new System.Windows.Forms.Label();
            this.IMBD_lbl = new System.Windows.Forms.Label();
            this.Awards = new System.Windows.Forms.Label();
            this.Website_lbl = new System.Windows.Forms.Label();
            this.Starts_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // leanguage_lbl
            // 
            this.leanguage_lbl.AutoSize = true;
            this.leanguage_lbl.Location = new System.Drawing.Point(14, 254);
            this.leanguage_lbl.Name = "leanguage_lbl";
            this.leanguage_lbl.Size = new System.Drawing.Size(93, 20);
            this.leanguage_lbl.TabIndex = 1;
            this.leanguage_lbl.Text = "Leanguage: ";
            // 
            // Author_lbl
            // 
            this.Author_lbl.AutoSize = true;
            this.Author_lbl.Location = new System.Drawing.Point(14, 283);
            this.Author_lbl.Name = "Author_lbl";
            this.Author_lbl.Size = new System.Drawing.Size(68, 20);
            this.Author_lbl.TabIndex = 2;
            this.Author_lbl.Text = "Author: ";
            // 
            // Country_lbl
            // 
            this.Country_lbl.AutoSize = true;
            this.Country_lbl.Location = new System.Drawing.Point(14, 314);
            this.Country_lbl.Name = "Country_lbl";
            this.Country_lbl.Size = new System.Drawing.Size(74, 20);
            this.Country_lbl.TabIndex = 3;
            this.Country_lbl.Text = "Country: ";
            // 
            // IMBD_lbl
            // 
            this.IMBD_lbl.AutoSize = true;
            this.IMBD_lbl.Location = new System.Drawing.Point(14, 402);
            this.IMBD_lbl.Name = "IMBD_lbl";
            this.IMBD_lbl.Size = new System.Drawing.Size(57, 20);
            this.IMBD_lbl.TabIndex = 6;
            this.IMBD_lbl.Text = "IMDB: ";
            // 
            // Awards
            // 
            this.Awards.AutoSize = true;
            this.Awards.Location = new System.Drawing.Point(14, 371);
            this.Awards.Name = "Awards";
            this.Awards.Size = new System.Drawing.Size(70, 20);
            this.Awards.TabIndex = 5;
            this.Awards.Text = "Awards: ";
            // 
            // Website_lbl
            // 
            this.Website_lbl.AutoSize = true;
            this.Website_lbl.Location = new System.Drawing.Point(14, 342);
            this.Website_lbl.Name = "Website_lbl";
            this.Website_lbl.Size = new System.Drawing.Size(74, 20);
            this.Website_lbl.TabIndex = 4;
            this.Website_lbl.Text = "Website: ";
            // 
            // Starts_panel
            // 
            this.Starts_panel.Location = new System.Drawing.Point(243, 12);
            this.Starts_panel.Name = "Starts_panel";
            this.Starts_panel.Size = new System.Drawing.Size(250, 30);
            this.Starts_panel.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 443);
            this.Controls.Add(this.IMBD_lbl);
            this.Controls.Add(this.Awards);
            this.Controls.Add(this.Website_lbl);
            this.Controls.Add(this.Country_lbl);
            this.Controls.Add(this.Author_lbl);
            this.Controls.Add(this.leanguage_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Starts_panel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label leanguage_lbl;
        private Label Author_lbl;
        private Label Country_lbl;
        private Label IMBD_lbl;
        private Label Awards;
        private Label Website_lbl;
        private Panel Starts_panel;
    }
}