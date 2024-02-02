namespace PatienthanteringPL
{
    partial class RedigeraBesok
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
            this.dataGridViewBefintligaBesok = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBefintligaBesok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBefintligaBesok
            // 
            this.dataGridViewBefintligaBesok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBefintligaBesok.Location = new System.Drawing.Point(226, 90);
            this.dataGridViewBefintligaBesok.Name = "dataGridViewBefintligaBesok";
            this.dataGridViewBefintligaBesok.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewBefintligaBesok.TabIndex = 0;
            // 
            // RedigeraBesok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewBefintligaBesok);
            this.Name = "RedigeraBesok";
            this.Text = "RedigeraBesok";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBefintligaBesok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBefintligaBesok;
    }
}