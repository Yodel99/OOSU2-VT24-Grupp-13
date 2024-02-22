namespace PatienthanteringPL
{
    partial class EditVisit
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
            this.dataGridViewExistingVisits = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBesokNr = new System.Windows.Forms.TextBox();
            this.buttonRedigeraTid = new System.Windows.Forms.Button();
            this.buttonTaBort = new System.Windows.Forms.Button();
            this.buttonTillbaka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExistingVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExistingVisits
            // 
            this.dataGridViewExistingVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExistingVisits.Location = new System.Drawing.Point(23, 44);
            this.dataGridViewExistingVisits.Name = "dataGridViewExistingVisits";
            this.dataGridViewExistingVisits.Size = new System.Drawing.Size(548, 150);
            this.dataGridViewExistingVisits.TabIndex = 0;
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
            this.buttonRedigeraTid.Click += new System.EventHandler(this.buttonEditTime_Click);
            // 
            // buttonTaBort
            // 
            this.buttonTaBort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaBort.Location = new System.Drawing.Point(170, 344);
            this.buttonTaBort.Name = "buttonTaBort";
            this.buttonTaBort.Size = new System.Drawing.Size(137, 51);
            this.buttonTaBort.TabIndex = 5;
            this.buttonTaBort.Text = "Ta bort besök";
            this.buttonTaBort.UseVisualStyleBackColor = true;
            this.buttonTaBort.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonTillbaka
            // 
            this.buttonTillbaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTillbaka.Location = new System.Drawing.Point(475, 399);
            this.buttonTillbaka.Name = "buttonTillbaka";
            this.buttonTillbaka.Size = new System.Drawing.Size(103, 39);
            this.buttonTillbaka.TabIndex = 6;
            this.buttonTillbaka.Text = "Tillbaka";
            this.buttonTillbaka.UseVisualStyleBackColor = true;
            this.buttonTillbaka.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // EditVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.buttonTillbaka);
            this.Controls.Add(this.buttonTaBort);
            this.Controls.Add(this.buttonRedigeraTid);
            this.Controls.Add(this.textBoxBesokNr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewExistingVisits);
            this.Name = "EditVisit";
            this.Text = "EditVisit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExistingVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExistingVisits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBesokNr;
        private System.Windows.Forms.Button buttonRedigeraTid;
        private System.Windows.Forms.Button buttonTaBort;
        private System.Windows.Forms.Button buttonTillbaka;
    }
}