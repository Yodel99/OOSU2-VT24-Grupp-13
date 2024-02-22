namespace PatienthanteringPL
{
    partial class UpdatePatient
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
            this.dataGridViewShowPatients = new System.Windows.Forms.DataGridView();
            this.textBoxPatientId = new System.Windows.Forms.TextBox();
            this.textBoxAttribut = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.uppdateraPatientInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowPatients
            // 
            this.dataGridViewShowPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowPatients.Location = new System.Drawing.Point(267, 40);
            this.dataGridViewShowPatients.Name = "dataGridViewShowPatients";
            this.dataGridViewShowPatients.Size = new System.Drawing.Size(355, 327);
            this.dataGridViewShowPatients.TabIndex = 0;
            // 
            // textBoxPatientId
            // 
            this.textBoxPatientId.Location = new System.Drawing.Point(40, 89);
            this.textBoxPatientId.Name = "textBoxPatientId";
            this.textBoxPatientId.Size = new System.Drawing.Size(189, 20);
            this.textBoxPatientId.TabIndex = 1;
            // 
            // textBoxAttribut
            // 
            this.textBoxAttribut.Location = new System.Drawing.Point(40, 165);
            this.textBoxAttribut.Name = "textBoxAttribut";
            this.textBoxAttribut.Size = new System.Drawing.Size(189, 20);
            this.textBoxAttribut.TabIndex = 2;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(40, 237);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(189, 20);
            this.textBoxInput.TabIndex = 3;
            // 
            // uppdateraPatientInfo
            // 
            this.uppdateraPatientInfo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uppdateraPatientInfo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uppdateraPatientInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uppdateraPatientInfo.Location = new System.Drawing.Point(40, 308);
            this.uppdateraPatientInfo.Name = "uppdateraPatientInfo";
            this.uppdateraPatientInfo.Size = new System.Drawing.Size(189, 59);
            this.uppdateraPatientInfo.TabIndex = 4;
            this.uppdateraPatientInfo.Text = "Uppdatera patient";
            this.uppdateraPatientInfo.UseVisualStyleBackColor = false;
            this.uppdateraPatientInfo.Click += new System.EventHandler(this.buttonUpdatePatientInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "PatientID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Attribut:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Input:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(455, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Tillbaka";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // UpdatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uppdateraPatientInfo);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBoxAttribut);
            this.Controls.Add(this.textBoxPatientId);
            this.Controls.Add(this.dataGridViewShowPatients);
            this.Name = "UpdatePatient";
            this.Text = "UpdatePatient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShowPatients;
        private System.Windows.Forms.TextBox textBoxPatientId;
        private System.Windows.Forms.TextBox textBoxAttribut;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button uppdateraPatientInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}