namespace PatienthanteringPL
{
    partial class MainMenu
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
            this.hanteraPatient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.huvudMeny1 = new System.Windows.Forms.Label();
            this.buttonAvsluta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hanteraPatient
            // 
            this.hanteraPatient.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hanteraPatient.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hanteraPatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hanteraPatient.Location = new System.Drawing.Point(285, 401);
            this.hanteraPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hanteraPatient.Name = "hanteraPatient";
            this.hanteraPatient.Size = new System.Drawing.Size(377, 89);
            this.hanteraPatient.TabIndex = 0;
            this.hanteraPatient.Text = "Besök";
            this.hanteraPatient.UseVisualStyleBackColor = false;
            this.hanteraPatient.Click += new System.EventHandler(this.buttonManageVisits_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(285, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(377, 89);
            this.button1.TabIndex = 1;
            this.button1.Text = "Patienter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonManagePatients_Click);
            // 
            // huvudMeny1
            // 
            this.huvudMeny1.AutoSize = true;
            this.huvudMeny1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huvudMeny1.Location = new System.Drawing.Point(328, 122);
            this.huvudMeny1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.huvudMeny1.Name = "huvudMeny1";
            this.huvudMeny1.Size = new System.Drawing.Size(300, 61);
            this.huvudMeny1.TabIndex = 2;
            this.huvudMeny1.Text = "MainMenu";
            // 
            // buttonAvsluta
            // 
            this.buttonAvsluta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonAvsluta.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvsluta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAvsluta.Location = new System.Drawing.Point(763, 617);
            this.buttonAvsluta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAvsluta.Name = "buttonAvsluta";
            this.buttonAvsluta.Size = new System.Drawing.Size(206, 61);
            this.buttonAvsluta.TabIndex = 3;
            this.buttonAvsluta.Text = "Avsluta";
            this.buttonAvsluta.UseVisualStyleBackColor = false;
            this.buttonAvsluta.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 692);
            this.Controls.Add(this.buttonAvsluta);
            this.Controls.Add(this.huvudMeny1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hanteraPatient);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenu";
            this.Text = "MainMenu - Patienthantering";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hanteraPatient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label huvudMeny1;
        private System.Windows.Forms.Button buttonAvsluta;
    }
}

