namespace PatienthanteringPL
{
    partial class RedigeraBesok
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
            this.dataGridViewBefintligaBesok = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBesokNr = new System.Windows.Forms.TextBox();
            this.buttonRedigeraTid = new System.Windows.Forms.Button();
            this.buttonTaBort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBefintligaBesok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBefintligaBesok
            // 
            this.dataGridViewBefintligaBesok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBefintligaBesok.Location = new System.Drawing.Point(23, 44);
            this.dataGridViewBefintligaBesok.Name = "dataGridViewBefintligaBesok";
            this.dataGridViewBefintligaBesok.Size = new System.Drawing.Size(488, 150);
            this.dataGridViewBefintligaBesok.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beffintliga besök";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mata in besöksnummret som du vill ändra tid eller ta bort.";
            // 
            // textBoxBesokNr
            // 
            this.textBoxBesokNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBesokNr.Location = new System.Drawing.Point(32, 297);
            this.textBoxBesokNr.Name = "textBoxBesokNr";
            this.textBoxBesokNr.Size = new System.Drawing.Size(113, 29);
            this.textBoxBesokNr.TabIndex = 3;
            // 
            // buttonRedigeraTid
            // 
            this.buttonRedigeraTid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedigeraTid.Location = new System.Drawing.Point(32, 344);
            this.buttonRedigeraTid.Name = "buttonRedigeraTid";
            this.buttonRedigeraTid.Size = new System.Drawing.Size(132, 51);
            this.buttonRedigeraTid.TabIndex = 4;
            this.buttonRedigeraTid.Text = "Redigera tid";
            this.buttonRedigeraTid.UseVisualStyleBackColor = true;
            this.buttonRedigeraTid.Click += new System.EventHandler(this.buttonRedigeraTid_Click);
            // 
            // buttonTaBort
            // 
            this.buttonTaBort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaBort.Location = new System.Drawing.Point(192, 344);
            this.buttonTaBort.Name = "buttonTaBort";
            this.buttonTaBort.Size = new System.Drawing.Size(137, 51);
            this.buttonTaBort.TabIndex = 5;
            this.buttonTaBort.Text = "Ta bort besök";
            this.buttonTaBort.UseVisualStyleBackColor = true;
            this.buttonTaBort.Click += new System.EventHandler(this.buttonTaBort_Click);
            // 
            // RedigeraBesok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.buttonTaBort);
            this.Controls.Add(this.buttonRedigeraTid);
            this.Controls.Add(this.textBoxBesokNr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewBefintligaBesok);
            this.Name = "RedigeraBesok";
            this.Text = "RedigeraBesok";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBefintligaBesok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBefintligaBesok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBesokNr;
        private System.Windows.Forms.Button buttonRedigeraTid;
        private System.Windows.Forms.Button buttonTaBort;
    }
}