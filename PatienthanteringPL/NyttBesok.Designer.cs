namespace PatienthanteringPL
{
    partial class NyttBesok
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
            this.dataGridViewSjukSkotare = new System.Windows.Forms.DataGridView();
            this.dataGridViewPatienter = new System.Windows.Forms.DataGridView();
            this.labelSjukSkotare = new System.Windows.Forms.Label();
            this.labelPatienter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSjukSkotare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatienter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSjukSkotare
            // 
            this.dataGridViewSjukSkotare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSjukSkotare.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewSjukSkotare.Name = "dataGridViewSjukSkotare";
            this.dataGridViewSjukSkotare.Size = new System.Drawing.Size(353, 150);
            this.dataGridViewSjukSkotare.TabIndex = 0;
            // 
            // dataGridViewPatienter
            // 
            this.dataGridViewPatienter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatienter.Location = new System.Drawing.Point(428, 41);
            this.dataGridViewPatienter.Name = "dataGridViewPatienter";
            this.dataGridViewPatienter.Size = new System.Drawing.Size(360, 150);
            this.dataGridViewPatienter.TabIndex = 1;
            // 
            // labelSjukSkotare
            // 
            this.labelSjukSkotare.AutoSize = true;
            this.labelSjukSkotare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSjukSkotare.Location = new System.Drawing.Point(8, 18);
            this.labelSjukSkotare.Name = "labelSjukSkotare";
            this.labelSjukSkotare.Size = new System.Drawing.Size(93, 20);
            this.labelSjukSkotare.TabIndex = 2;
            this.labelSjukSkotare.Text = "Sjukskötare";
            // 
            // labelPatienter
            // 
            this.labelPatienter.AutoSize = true;
            this.labelPatienter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatienter.Location = new System.Drawing.Point(424, 18);
            this.labelPatienter.Name = "labelPatienter";
            this.labelPatienter.Size = new System.Drawing.Size(73, 20);
            this.labelPatienter.TabIndex = 3;
            this.labelPatienter.Text = "Patienter";
            // 
            // NyttBesok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPatienter);
            this.Controls.Add(this.labelSjukSkotare);
            this.Controls.Add(this.dataGridViewPatienter);
            this.Controls.Add(this.dataGridViewSjukSkotare);
            this.Name = "NyttBesok";
            this.Text = "NyttBesok";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSjukSkotare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatienter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSjukSkotare;
        private System.Windows.Forms.DataGridView dataGridViewPatienter;
        private System.Windows.Forms.Label labelSjukSkotare;
        private System.Windows.Forms.Label labelPatienter;
    }
}