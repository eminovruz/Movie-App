namespace Movie_App.UserControls
{
    partial class UC_Movie
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.MoviePicture_pctbx = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePicture_pctbx)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviePicture_pctbx
            // 
            this.MoviePicture_pctbx.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MoviePicture_pctbx.Location = new System.Drawing.Point(6, 3);
            this.MoviePicture_pctbx.Name = "MoviePicture_pctbx";
            this.MoviePicture_pctbx.Size = new System.Drawing.Size(251, 340);
            this.MoviePicture_pctbx.TabIndex = 0;
            this.MoviePicture_pctbx.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wiew More";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC_Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MoviePicture_pctbx);
            this.Name = "UC_Movie";
            this.Size = new System.Drawing.Size(262, 423);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePicture_pctbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public PictureBox MoviePicture_pctbx;
        public Button button1;
    }
}
