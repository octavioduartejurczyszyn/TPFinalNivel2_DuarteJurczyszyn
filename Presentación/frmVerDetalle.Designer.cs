namespace Presentación
{
    partial class frmVerDetalle
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
            this.pbxVerDetalle = new System.Windows.Forms.PictureBox();
            this.dgvVerDetalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVerDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxVerDetalle
            // 
            this.pbxVerDetalle.Location = new System.Drawing.Point(219, 36);
            this.pbxVerDetalle.Name = "pbxVerDetalle";
            this.pbxVerDetalle.Size = new System.Drawing.Size(291, 281);
            this.pbxVerDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxVerDetalle.TabIndex = 0;
            this.pbxVerDetalle.TabStop = false;
            // 
            // dgvVerDetalle
            // 
            this.dgvVerDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerDetalle.Location = new System.Drawing.Point(44, 332);
            this.dgvVerDetalle.Name = "dgvVerDetalle";
            this.dgvVerDetalle.Size = new System.Drawing.Size(645, 50);
            this.dgvVerDetalle.TabIndex = 1;
            // 
            // frmVerDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 426);
            this.Controls.Add(this.dgvVerDetalle);
            this.Controls.Add(this.pbxVerDetalle);
            this.Name = "frmVerDetalle";
            this.Text = "Detalle Articulo";
            this.Load += new System.EventHandler(this.frmVerDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxVerDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxVerDetalle;
        private System.Windows.Forms.DataGridView dgvVerDetalle;
    }
}