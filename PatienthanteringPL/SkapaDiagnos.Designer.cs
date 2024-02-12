namespace PatienthanteringPL
{
    partial class SkapaDiagnos
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
            this.textBoxDiagnosBeskrivning = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBehandlingsplan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewVisaDiagnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisaDiagnos)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDiagnosBeskrivning
            // 
            this.textBoxDiagnosBeskrivning.Location = new System.Drawing.Point(119, 114);
            this.textBoxDiagnosBeskrivning.Name = "textBoxDiagnosBeskrivning";
            this.textBoxDiagnosBeskrivning.Size = new System.Drawing.Size(293, 26);
            this.textBoxDiagnosBeskrivning.TabIndex = 0;
            this.textBoxDiagnosBeskrivning.TextChanged += new System.EventHandler(this.textBoxDiagnosBeskrivning_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beskriv diagnosen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Beskriv behandlingsplanen:";
            // 
            // textBoxBehandlingsplan
            // 
            this.textBoxBehandlingsplan.Location = new System.Drawing.Point(119, 194);
            this.textBoxBehandlingsplan.Name = "textBoxBehandlingsplan";
            this.textBoxBehandlingsplan.Size = new System.Drawing.Size(293, 26);
            this.textBoxBehandlingsplan.TabIndex = 3;
            this.textBoxBehandlingsplan.TextChanged += new System.EventHandler(this.textBoxBehandlingsplan_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lägg till diagnos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewVisaDiagnos
            // 
            this.dataGridViewVisaDiagnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisaDiagnos.Location = new System.Drawing.Point(461, 40);
            this.dataGridViewVisaDiagnos.Name = "dataGridViewVisaDiagnos";
            this.dataGridViewVisaDiagnos.RowHeadersWidth = 62;
            this.dataGridViewVisaDiagnos.RowTemplate.Height = 28;
            this.dataGridViewVisaDiagnos.Size = new System.Drawing.Size(315, 314);
            this.dataGridViewVisaDiagnos.TabIndex = 5;
            // 
            // SkapaDiagnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewVisaDiagnos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxBehandlingsplan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDiagnosBeskrivning);
            this.Name = "SkapaDiagnos";
            this.Text = "SkapaDiagnos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisaDiagnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDiagnosBeskrivning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBehandlingsplan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewVisaDiagnos;
    }
}