namespace PatienthanteringPL
{
    partial class CreatDiagnosis
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
            this.dataGridViewShowDiagnosis = new System.Windows.Forms.DataGridView();
            this.Tillbakabutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowDiagnosis)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDiagnosBeskrivning
            // 
            this.textBoxDiagnosBeskrivning.Location = new System.Drawing.Point(119, 114);
            this.textBoxDiagnosBeskrivning.Name = "textBoxDiagnosBeskrivning";
            this.textBoxDiagnosBeskrivning.Size = new System.Drawing.Size(293, 26);
            this.textBoxDiagnosBeskrivning.TabIndex = 0;
            this.textBoxDiagnosBeskrivning.TextChanged += new System.EventHandler(this.textBoxDiagnosisDescription_TextChanged);
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
            this.textBoxBehandlingsplan.TextChanged += new System.EventHandler(this.textBoxTreatmentPlan_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lägg till diagnos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCreateDiagnosis_Click);
            // 
            // dataGridViewShowDiagnosis
            // 
            this.dataGridViewShowDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowDiagnosis.Location = new System.Drawing.Point(473, 12);
            this.dataGridViewShowDiagnosis.Name = "dataGridViewShowDiagnosis";
            this.dataGridViewShowDiagnosis.RowHeadersWidth = 62;
            this.dataGridViewShowDiagnosis.RowTemplate.Height = 28;
            this.dataGridViewShowDiagnosis.Size = new System.Drawing.Size(315, 358);
            this.dataGridViewShowDiagnosis.TabIndex = 5;
            // 
            // Tillbakabutton
            // 
            this.Tillbakabutton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Tillbakabutton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tillbakabutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tillbakabutton.Location = new System.Drawing.Point(13, 391);
            this.Tillbakabutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tillbakabutton.Name = "Tillbakabutton";
            this.Tillbakabutton.Size = new System.Drawing.Size(156, 45);
            this.Tillbakabutton.TabIndex = 9;
            this.Tillbakabutton.Text = "Tillbaka";
            this.Tillbakabutton.UseVisualStyleBackColor = false;
            this.Tillbakabutton.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // CreatDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tillbakabutton);
            this.Controls.Add(this.dataGridViewShowDiagnosis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxBehandlingsplan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDiagnosBeskrivning);
            this.Name = "CreatDiagnosis";
            this.Text = "CreatDiagnosis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowDiagnosis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDiagnosBeskrivning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBehandlingsplan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewShowDiagnosis;
        private System.Windows.Forms.Button Tillbakabutton;
    }
}