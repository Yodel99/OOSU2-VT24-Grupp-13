namespace PatienthanteringPL
{
    partial class HanteraBesok
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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonHuvudMeny = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(193, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Skapa nytt besök";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(193, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "Redigera besök";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonHuvudMeny
            // 
            this.buttonHuvudMeny.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonHuvudMeny.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuvudMeny.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonHuvudMeny.Location = new System.Drawing.Point(193, 353);
            this.buttonHuvudMeny.Name = "buttonHuvudMeny";
            this.buttonHuvudMeny.Size = new System.Drawing.Size(251, 58);
            this.buttonHuvudMeny.TabIndex = 4;
            this.buttonHuvudMeny.Text = "Tillbaka till huvudmenyn";
            this.buttonHuvudMeny.UseVisualStyleBackColor = false;
            this.buttonHuvudMeny.Click += new System.EventHandler(this.buttonHuvudMeny_Click);
            // 
            // HanteraBesok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.buttonHuvudMeny);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "HanteraBesok";
            this.Text = "HanteraBesok";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonHuvudMeny;
    }
}