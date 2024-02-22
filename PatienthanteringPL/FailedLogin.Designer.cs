namespace PatienthanteringPL
{
    partial class FailedLogin
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
            this.FelIDLösenlabel1 = new System.Windows.Forms.Label();
            this.FörsökIgenbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FelIDLösenlabel1
            // 
            this.FelIDLösenlabel1.AutoSize = true;
            this.FelIDLösenlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FelIDLösenlabel1.Location = new System.Drawing.Point(214, 108);
            this.FelIDLösenlabel1.Name = "FelIDLösenlabel1";
            this.FelIDLösenlabel1.Size = new System.Drawing.Size(375, 25);
            this.FelIDLösenlabel1.TabIndex = 0;
            this.FelIDLösenlabel1.Text = "Felaktigt ID eller lösenord, försök igen";
            // 
            // FörsökIgenbutton1
            // 
            this.FörsökIgenbutton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FörsökIgenbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FörsökIgenbutton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FörsökIgenbutton1.Location = new System.Drawing.Point(288, 198);
            this.FörsökIgenbutton1.Name = "FörsökIgenbutton1";
            this.FörsökIgenbutton1.Size = new System.Drawing.Size(216, 48);
            this.FörsökIgenbutton1.TabIndex = 1;
            this.FörsökIgenbutton1.Text = "Försök igen";
            this.FörsökIgenbutton1.UseVisualStyleBackColor = false;
            this.FörsökIgenbutton1.Click += new System.EventHandler(this.buttonTryAgain_Click);
            // 
            // FailedLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FörsökIgenbutton1);
            this.Controls.Add(this.FelIDLösenlabel1);
            this.Name = "FailedLogin";
            this.Text = "FailedLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FelIDLösenlabel1;
        private System.Windows.Forms.Button FörsökIgenbutton1;
    }
}