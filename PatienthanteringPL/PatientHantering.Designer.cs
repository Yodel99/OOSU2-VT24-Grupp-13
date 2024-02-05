namespace PatienthanteringPL
{
    partial class PatientHantering
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
            this.registreraPatient = new System.Windows.Forms.Button();
            this.uppdateraPatient = new System.Windows.Forms.Button();
            this.registreraDiagnos = new System.Windows.Forms.Button();
            this.huvudMeny1 = new System.Windows.Forms.Label();
            this.skrivUtLakemedel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registreraPatient
            // 
            this.registreraPatient.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.registreraPatient.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registreraPatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registreraPatient.Location = new System.Drawing.Point(297, 195);
            this.registreraPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registreraPatient.Name = "registreraPatient";
            this.registreraPatient.Size = new System.Drawing.Size(376, 89);
            this.registreraPatient.TabIndex = 2;
            this.registreraPatient.Text = "Registrera patient";
            this.registreraPatient.UseVisualStyleBackColor = false;
            // 
            // uppdateraPatient
            // 
            this.uppdateraPatient.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uppdateraPatient.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uppdateraPatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uppdateraPatient.Location = new System.Drawing.Point(297, 309);
            this.uppdateraPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uppdateraPatient.Name = "uppdateraPatient";
            this.uppdateraPatient.Size = new System.Drawing.Size(376, 89);
            this.uppdateraPatient.TabIndex = 3;
            this.uppdateraPatient.Text = "Uppdatera patient";
            this.uppdateraPatient.UseVisualStyleBackColor = false;
            // 
            // registreraDiagnos
            // 
            this.registreraDiagnos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.registreraDiagnos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registreraDiagnos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registreraDiagnos.Location = new System.Drawing.Point(297, 428);
            this.registreraDiagnos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registreraDiagnos.Name = "registreraDiagnos";
            this.registreraDiagnos.Size = new System.Drawing.Size(376, 89);
            this.registreraDiagnos.TabIndex = 4;
            this.registreraDiagnos.Text = "Registrera diagnos";
            this.registreraDiagnos.UseVisualStyleBackColor = false;
            this.registreraDiagnos.Click += new System.EventHandler(this.registreraDiagnos_Click);
            // 
            // huvudMeny1
            // 
            this.huvudMeny1.AutoSize = true;
            this.huvudMeny1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huvudMeny1.Location = new System.Drawing.Point(207, 86);
            this.huvudMeny1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.huvudMeny1.Name = "huvudMeny1";
            this.huvudMeny1.Size = new System.Drawing.Size(546, 61);
            this.huvudMeny1.TabIndex = 5;
            this.huvudMeny1.Text = "Hantering av patienter";
            // 
            // skrivUtLakemedel
            // 
            this.skrivUtLakemedel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.skrivUtLakemedel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skrivUtLakemedel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.skrivUtLakemedel.Location = new System.Drawing.Point(297, 543);
            this.skrivUtLakemedel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.skrivUtLakemedel.Name = "skrivUtLakemedel";
            this.skrivUtLakemedel.Size = new System.Drawing.Size(376, 89);
            this.skrivUtLakemedel.TabIndex = 6;
            this.skrivUtLakemedel.Text = "Skriv ut läkemedel";
            this.skrivUtLakemedel.UseVisualStyleBackColor = false;
            this.skrivUtLakemedel.Click += new System.EventHandler(this.skrivUtLakemedel_Click);
            // 
            // PatientHantering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 692);
            this.Controls.Add(this.skrivUtLakemedel);
            this.Controls.Add(this.huvudMeny1);
            this.Controls.Add(this.registreraDiagnos);
            this.Controls.Add(this.uppdateraPatient);
            this.Controls.Add(this.registreraPatient);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PatientHantering";
            this.Text = "Patienthantering ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registreraPatient;
        private System.Windows.Forms.Button uppdateraPatient;
        private System.Windows.Forms.Button registreraDiagnos;
        private System.Windows.Forms.Label huvudMeny1;
        private System.Windows.Forms.Button skrivUtLakemedel;
    }
}