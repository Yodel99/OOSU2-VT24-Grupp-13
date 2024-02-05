namespace PatienthanteringPL
{
    partial class LoggaIn
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
            this.InloggsIDtextBox1 = new System.Windows.Forms.TextBox();
            this.LosenordtextBox2 = new System.Windows.Forms.TextBox();
            this.LoggaInbutton1 = new System.Windows.Forms.Button();
            this.InloggIDlabel1 = new System.Windows.Forms.Label();
            this.LösenOrdlabel2 = new System.Windows.Forms.Label();
            this.LoggaInlabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InloggsIDtextBox1
            // 
            this.InloggsIDtextBox1.Location = new System.Drawing.Point(318, 152);
            this.InloggsIDtextBox1.Name = "InloggsIDtextBox1";
            this.InloggsIDtextBox1.Size = new System.Drawing.Size(196, 22);
            this.InloggsIDtextBox1.TabIndex = 0;
            // 
            // LosenordtextBox2
            // 
            this.LosenordtextBox2.Location = new System.Drawing.Point(318, 252);
            this.LosenordtextBox2.Name = "LosenordtextBox2";
            this.LosenordtextBox2.Size = new System.Drawing.Size(196, 22);
            this.LosenordtextBox2.TabIndex = 1;
            // 
            // LoggaInbutton1
            // 
            this.LoggaInbutton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoggaInbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggaInbutton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoggaInbutton1.Location = new System.Drawing.Point(318, 351);
            this.LoggaInbutton1.Name = "LoggaInbutton1";
            this.LoggaInbutton1.Size = new System.Drawing.Size(196, 47);
            this.LoggaInbutton1.TabIndex = 2;
            this.LoggaInbutton1.Text = "Logga in";
            this.LoggaInbutton1.UseVisualStyleBackColor = false;
            this.LoggaInbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InloggIDlabel1
            // 
            this.InloggIDlabel1.AutoSize = true;
            this.InloggIDlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InloggIDlabel1.Location = new System.Drawing.Point(168, 154);
            this.InloggIDlabel1.Name = "InloggIDlabel1";
            this.InloggIDlabel1.Size = new System.Drawing.Size(129, 20);
            this.InloggIDlabel1.TabIndex = 3;
            this.InloggIDlabel1.Text = "InloggningsID:";
            // 
            // LösenOrdlabel2
            // 
            this.LösenOrdlabel2.AutoSize = true;
            this.LösenOrdlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LösenOrdlabel2.Location = new System.Drawing.Point(168, 254);
            this.LösenOrdlabel2.Name = "LösenOrdlabel2";
            this.LösenOrdlabel2.Size = new System.Drawing.Size(93, 20);
            this.LösenOrdlabel2.TabIndex = 4;
            this.LösenOrdlabel2.Text = "Lösenord:";
            // 
            // LoggaInlabel3
            // 
            this.LoggaInlabel3.AutoSize = true;
            this.LoggaInlabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggaInlabel3.Location = new System.Drawing.Point(301, 75);
            this.LoggaInlabel3.Name = "LoggaInlabel3";
            this.LoggaInlabel3.Size = new System.Drawing.Size(238, 29);
            this.LoggaInlabel3.TabIndex = 5;
            this.LoggaInlabel3.Text = "Logga in i systemet";
            // 
            // LoggaIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoggaInlabel3);
            this.Controls.Add(this.LösenOrdlabel2);
            this.Controls.Add(this.InloggIDlabel1);
            this.Controls.Add(this.LoggaInbutton1);
            this.Controls.Add(this.LosenordtextBox2);
            this.Controls.Add(this.InloggsIDtextBox1);
            this.Name = "LoggaIn";
            this.Text = "LoggaIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InloggsIDtextBox1;
        private System.Windows.Forms.TextBox LosenordtextBox2;
        private System.Windows.Forms.Button LoggaInbutton1;
        private System.Windows.Forms.Label InloggIDlabel1;
        private System.Windows.Forms.Label LösenOrdlabel2;
        private System.Windows.Forms.Label LoggaInlabel3;
    }
}