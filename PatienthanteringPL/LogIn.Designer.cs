namespace PatienthanteringPL
{
    partial class LogIn
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
            this.LoggaInbutton1 = new System.Windows.Forms.Button();
            this.InloggIDlabel1 = new System.Windows.Forms.Label();
            this.LösenOrdlabel2 = new System.Windows.Forms.Label();
            this.LoggaInlabel3 = new System.Windows.Forms.Label();
            this.LosenordtextBox2 = new System.Windows.Forms.TextBox();
            this.buttonAvsluta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InloggsIDtextBox1
            // 
            this.InloggsIDtextBox1.Location = new System.Drawing.Point(239, 123);
            this.InloggsIDtextBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.InloggsIDtextBox1.Name = "InloggsIDtextBox1";
            this.InloggsIDtextBox1.Size = new System.Drawing.Size(148, 20);
            this.InloggsIDtextBox1.TabIndex = 0;
            // 
            // LoggaInbutton1
            // 
            this.LoggaInbutton1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LoggaInbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggaInbutton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoggaInbutton1.Location = new System.Drawing.Point(239, 253);
            this.LoggaInbutton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LoggaInbutton1.Name = "LoggaInbutton1";
            this.LoggaInbutton1.Size = new System.Drawing.Size(147, 38);
            this.LoggaInbutton1.TabIndex = 2;
            this.LoggaInbutton1.Text = "Logga in";
            this.LoggaInbutton1.UseVisualStyleBackColor = false;
            this.LoggaInbutton1.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // InloggIDlabel1
            // 
            this.InloggIDlabel1.AutoSize = true;
            this.InloggIDlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InloggIDlabel1.Location = new System.Drawing.Point(124, 123);
            this.InloggIDlabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InloggIDlabel1.Name = "InloggIDlabel1";
            this.InloggIDlabel1.Size = new System.Drawing.Size(111, 17);
            this.InloggIDlabel1.TabIndex = 3;
            this.InloggIDlabel1.Text = "InloggningsID:";
            // 
            // LösenOrdlabel2
            // 
            this.LösenOrdlabel2.AutoSize = true;
            this.LösenOrdlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LösenOrdlabel2.Location = new System.Drawing.Point(154, 208);
            this.LösenOrdlabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LösenOrdlabel2.Name = "LösenOrdlabel2";
            this.LösenOrdlabel2.Size = new System.Drawing.Size(81, 17);
            this.LösenOrdlabel2.TabIndex = 4;
            this.LösenOrdlabel2.Text = "Lösenord:";
            // 
            // LoggaInlabel3
            // 
            this.LoggaInlabel3.AutoSize = true;
            this.LoggaInlabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggaInlabel3.Location = new System.Drawing.Point(213, 60);
            this.LoggaInlabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoggaInlabel3.Name = "LoggaInlabel3";
            this.LoggaInlabel3.Size = new System.Drawing.Size(189, 24);
            this.LoggaInlabel3.TabIndex = 5;
            this.LoggaInlabel3.Text = "Logga in i systemet";
            // 
            // LosenordtextBox2
            // 
            this.LosenordtextBox2.Location = new System.Drawing.Point(239, 205);
            this.LosenordtextBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LosenordtextBox2.Name = "LosenordtextBox2";
            this.LosenordtextBox2.Size = new System.Drawing.Size(148, 20);
            this.LosenordtextBox2.TabIndex = 1;
            this.LosenordtextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordtextBox2_KeyDown);
            // 
            // buttonAvsluta
            // 
            this.buttonAvsluta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonAvsluta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvsluta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAvsluta.Location = new System.Drawing.Point(475, 324);
            this.buttonAvsluta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAvsluta.Name = "buttonAvsluta";
            this.buttonAvsluta.Size = new System.Drawing.Size(117, 32);
            this.buttonAvsluta.TabIndex = 6;
            this.buttonAvsluta.Text = "Avsluta";
            this.buttonAvsluta.UseVisualStyleBackColor = false;
            this.buttonAvsluta.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.buttonAvsluta);
            this.Controls.Add(this.LoggaInlabel3);
            this.Controls.Add(this.LösenOrdlabel2);
            this.Controls.Add(this.InloggIDlabel1);
            this.Controls.Add(this.LoggaInbutton1);
            this.Controls.Add(this.LosenordtextBox2);
            this.Controls.Add(this.InloggsIDtextBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InloggsIDtextBox1;
        private System.Windows.Forms.Button LoggaInbutton1;
        private System.Windows.Forms.Label InloggIDlabel1;
        private System.Windows.Forms.Label LösenOrdlabel2;
        private System.Windows.Forms.Label LoggaInlabel3;
        private System.Windows.Forms.TextBox LosenordtextBox2;
        private System.Windows.Forms.Button buttonAvsluta;
    }
}