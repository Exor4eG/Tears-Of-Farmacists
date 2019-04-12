namespace Tears_Of_Farmacists.Forms
{
    partial class PreviewForm

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
            this.PB_preview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_preview
            // 
            this.PB_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_preview.Image = global::Tears_Of_Farmacists.Properties.Resources.HrBtkP;
            this.PB_preview.Location = new System.Drawing.Point(0, 0);
            this.PB_preview.Margin = new System.Windows.Forms.Padding(4);
            this.PB_preview.Name = "PB_preview";
            this.PB_preview.Size = new System.Drawing.Size(421, 219);
            this.PB_preview.TabIndex = 0;
            this.PB_preview.TabStop = false;
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(421, 219);
            this.Controls.Add(this.PB_preview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreviewForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview";
            ((System.ComponentModel.ISupportInitialize)(this.PB_preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_preview;
    }
}
