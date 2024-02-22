namespace PatienthanteringPL
{
    partial class ManagePatients
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registreraPatient
            // 
            this.registreraPatient.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.registreraPatient.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registreraPatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registreraPatient.Location = new System.Drawing.Point(198, 127);
            this.registreraPatient.Name = "registreraPatient";
            this.registreraPatient.Size = new System.Drawing.Size(251, 58);
            this.registreraPatient.TabIndex = 2;
            this.registreraPatient.Text = "Registrera patient";
            this.registreraPatient.UseVisualStyleBackColor = false;
            this.registreraPatient.Click += new System.EventHandler(this.buttonRegisterPatient_Click);
            // 
            // uppdateraPatient
            // 
            this.uppdateraPatient.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uppdateraPatient.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uppdateraPatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uppdateraPatient.Location = new System.Drawing.Point(198, 201);
            this.uppdateraPatient.Name = "uppdateraPatient";
            this.uppdateraPatient.Size = new System.Drawing.Size(251, 58);
            this.uppdateraPatient.TabIndex = 3;
            this.uppdateraPatient.Text = "Uppdatera patient";
            this.uppdateraPatient.UseVisualStyleBackColor = false;
            this.uppdateraPatient.Click += new System.EventHandler(this.buttonUpdatePatient_Click);
            // 
            // registreraDiagnos
            // 
            this.registreraDiagnos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.registreraDiagnos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registreraDiagnos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registreraDiagnos.Location = new System.Drawing.Point(198, 278);
            this.registreraDiagnos.Name = "registreraDiagnos";
            this.registreraDiagnos.Size = new System.Drawing.Size(251, 58);
            this.registreraDiagnos.TabIndex = 4;
            this.registreraDiagnos.Text = "Registrera diagnos";
            this.registreraDiagnos.UseVisualStyleBackColor = false;
            this.registreraDiagnos.Click += new System.EventHandler(this.buttonRegisterDiagnosis_Click);
            // 
            // huvudMeny1
            // 
            this.huvudMeny1.AutoSize = true;
            this.huvudMeny1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huvudMeny1.Location = new System.Drawing.Point(138, 56);
            this.huvudMeny1.Name = "huvudMeny1";
            this.huvudMeny1.Size = new System.Drawing.Size(361, 40);
            this.huvudMeny1.TabIndex = 5;
            this.huvudMeny1.Text = "Hantering av patienter";
            // 
            // skrivUtLakemedel
            // 
            this.skrivUtLakemedel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.skrivUtLakemedel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skrivUtLakemedel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.skrivUtLakemedel.Location = new System.Drawing.Point(198, 353);
            this.skrivUtLakemedel.Name = "skrivUtLakemedel";
            this.skrivUtLakemedel.Size = new System.Drawing.Size(251, 58);
            this.skrivUtLakemedel.TabIndex = 6;
            this.skrivUtLakemedel.Text = "Skriv ut läkemedel";
            this.skrivUtLakemedel.UseVisualStyleBackColor = false;
            this.skrivUtLakemedel.Click += new System.EventHandler(this.buttonChoosePrescription_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(511, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tillbaka";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // ManagePatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.skrivUtLakemedel);
            this.Controls.Add(this.huvudMeny1);
            this.Controls.Add(this.registreraDiagnos);
            this.Controls.Add(this.uppdateraPatient);
            this.Controls.Add(this.registreraPatient);
            this.Name = "ManagePatients";
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
        private System.Windows.Forms.Button button1;
    }
}