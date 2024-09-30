namespace TestForm
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartLoading = new System.Windows.Forms.Button();
            this.btnStopLoading = new System.Windows.Forms.Button();
            this.btn5Second = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartLoading
            // 
            this.btnStartLoading.Location = new System.Drawing.Point(187, 80);
            this.btnStartLoading.Name = "btnStartLoading";
            this.btnStartLoading.Size = new System.Drawing.Size(218, 77);
            this.btnStartLoading.TabIndex = 0;
            this.btnStartLoading.Text = "Start Loading";
            this.btnStartLoading.UseVisualStyleBackColor = true;
            this.btnStartLoading.Click += new System.EventHandler(this.btnStartLoading_Click);
            // 
            // btnStopLoading
            // 
            this.btnStopLoading.Location = new System.Drawing.Point(187, 208);
            this.btnStopLoading.Name = "btnStopLoading";
            this.btnStopLoading.Size = new System.Drawing.Size(218, 77);
            this.btnStopLoading.TabIndex = 0;
            this.btnStopLoading.Text = "Stop Loading";
            this.btnStopLoading.UseVisualStyleBackColor = true;
            this.btnStopLoading.Click += new System.EventHandler(this.btnStopLoading_Click);
            // 
            // btn5Second
            // 
            this.btn5Second.Location = new System.Drawing.Point(449, 80);
            this.btn5Second.Name = "btn5Second";
            this.btn5Second.Size = new System.Drawing.Size(218, 77);
            this.btn5Second.TabIndex = 0;
            this.btn5Second.Text = "Launch 5 secs loading";
            this.btn5Second.UseVisualStyleBackColor = true;
            this.btn5Second.Click += new System.EventHandler(this.btn5Second_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStopLoading);
            this.Controls.Add(this.btn5Second);
            this.Controls.Add(this.btnStartLoading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartLoading;
        private System.Windows.Forms.Button btnStopLoading;
        private System.Windows.Forms.Button btn5Second;
    }
}

