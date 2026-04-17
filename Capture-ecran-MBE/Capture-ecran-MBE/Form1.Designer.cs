namespace Capture_ecran_MBE
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Screenshot = new System.Windows.Forms.Button();
            this.pictureBox_Screenshot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Screenshot)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Screenshot
            // 
            this.button_Screenshot.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Screenshot.Location = new System.Drawing.Point(0, 0);
            this.button_Screenshot.Name = "button_Screenshot";
            this.button_Screenshot.Size = new System.Drawing.Size(88, 450);
            this.button_Screenshot.TabIndex = 0;
            this.button_Screenshot.Text = "Screenshot";
            this.button_Screenshot.UseVisualStyleBackColor = true;
            this.button_Screenshot.Click += new System.EventHandler(this.button_Screenshot_Click);
            // 
            // pictureBox_Screenshot
            // 
            this.pictureBox_Screenshot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Screenshot.Location = new System.Drawing.Point(88, 0);
            this.pictureBox_Screenshot.Name = "pictureBox_Screenshot";
            this.pictureBox_Screenshot.Size = new System.Drawing.Size(712, 450);
            this.pictureBox_Screenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Screenshot.TabIndex = 1;
            this.pictureBox_Screenshot.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox_Screenshot);
            this.Controls.Add(this.button_Screenshot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Screenshot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Screenshot;
        private System.Windows.Forms.PictureBox pictureBox_Screenshot;
    }
}

