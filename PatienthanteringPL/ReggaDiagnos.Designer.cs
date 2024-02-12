namespace PatienthanteringPL
{
    partial class ReggaDiagnos
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewVisaPatienter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisaPatienter)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrera Diagnos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewVisaPatienter
            // 
            this.dataGridViewVisaPatienter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisaPatienter.Location = new System.Drawing.Point(313, 12);
            this.dataGridViewVisaPatienter.Name = "dataGridViewVisaPatienter";
            this.dataGridViewVisaPatienter.RowHeadersWidth = 62;
            this.dataGridViewVisaPatienter.RowTemplate.Height = 28;
            this.dataGridViewVisaPatienter.Size = new System.Drawing.Size(475, 426);
            this.dataGridViewVisaPatienter.TabIndex = 1;
            this.dataGridViewVisaPatienter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVisaPatienter_CellClick);
            // 
            // ReggaDiagnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewVisaPatienter);
            this.Controls.Add(this.button1);
            this.Name = "ReggaDiagnos";
            this.Text = "ReggaDiagnos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisaPatienter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewVisaPatienter;
    }
}