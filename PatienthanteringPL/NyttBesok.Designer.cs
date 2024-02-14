namespace PatienthanteringPL
{
    partial class NyttBesok
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
            this.dataGridViewSjukSkotare = new System.Windows.Forms.DataGridView();
            this.dataGridViewPatienter = new System.Windows.Forms.DataGridView();
            this.labelSjukSkotare = new System.Windows.Forms.Label();
            this.labelPatienter = new System.Windows.Forms.Label();
            this.labelBesokNummer = new System.Windows.Forms.Label();
            this.labelANummerLakare = new System.Windows.Forms.Label();
            this.labelSyfte = new System.Windows.Forms.Label();
            this.labelPatientNummer = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.dateTimePickerBesok = new System.Windows.Forms.DateTimePicker();
            this.textBoxBesokNummer = new System.Windows.Forms.TextBox();
            this.textBoxANummerLakare = new System.Windows.Forms.TextBox();
            this.textBoxPatientNummer = new System.Windows.Forms.TextBox();
            this.textBoxSyfte = new System.Windows.Forms.TextBox();
            this.buttonLaggTillBesok = new System.Windows.Forms.Button();
            this.buttonTillbaka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSjukSkotare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatienter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSjukSkotare
            // 
            this.dataGridViewSjukSkotare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSjukSkotare.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewSjukSkotare.Name = "dataGridViewSjukSkotare";
            this.dataGridViewSjukSkotare.Size = new System.Drawing.Size(353, 150);
            this.dataGridViewSjukSkotare.TabIndex = 0;
            // 
            // dataGridViewPatienter
            // 
            this.dataGridViewPatienter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatienter.Location = new System.Drawing.Point(428, 41);
            this.dataGridViewPatienter.Name = "dataGridViewPatienter";
            this.dataGridViewPatienter.Size = new System.Drawing.Size(360, 150);
            this.dataGridViewPatienter.TabIndex = 1;
            // 
            // labelSjukSkotare
            // 
            this.labelSjukSkotare.AutoSize = true;
            this.labelSjukSkotare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSjukSkotare.Location = new System.Drawing.Point(8, 18);
            this.labelSjukSkotare.Name = "labelSjukSkotare";
            this.labelSjukSkotare.Size = new System.Drawing.Size(93, 20);
            this.labelSjukSkotare.TabIndex = 2;
            this.labelSjukSkotare.Text = "Sjukskötare";
            // 
            // labelPatienter
            // 
            this.labelPatienter.AutoSize = true;
            this.labelPatienter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatienter.Location = new System.Drawing.Point(424, 18);
            this.labelPatienter.Name = "labelPatienter";
            this.labelPatienter.Size = new System.Drawing.Size(73, 20);
            this.labelPatienter.TabIndex = 3;
            this.labelPatienter.Text = "Patienter";
            // 
            // labelBesokNummer
            // 
            this.labelBesokNummer.AutoSize = true;
            this.labelBesokNummer.Location = new System.Drawing.Point(12, 231);
            this.labelBesokNummer.Name = "labelBesokNummer";
            this.labelBesokNummer.Size = new System.Drawing.Size(76, 13);
            this.labelBesokNummer.TabIndex = 4;
            this.labelBesokNummer.Text = "BesökNummer";
            // 
            // labelANummerLakare
            // 
            this.labelANummerLakare.AutoSize = true;
            this.labelANummerLakare.Location = new System.Drawing.Point(153, 231);
            this.labelANummerLakare.Name = "labelANummerLakare";
            this.labelANummerLakare.Size = new System.Drawing.Size(136, 13);
            this.labelANummerLakare.TabIndex = 5;
            this.labelANummerLakare.Text = "Anställningsnummer Läkare";
            // 
            // labelSyfte
            // 
            this.labelSyfte.AutoSize = true;
            this.labelSyfte.Location = new System.Drawing.Point(451, 231);
            this.labelSyfte.Name = "labelSyfte";
            this.labelSyfte.Size = new System.Drawing.Size(31, 13);
            this.labelSyfte.TabIndex = 6;
            this.labelSyfte.Text = "Syfte";
            // 
            // labelPatientNummer
            // 
            this.labelPatientNummer.AutoSize = true;
            this.labelPatientNummer.Location = new System.Drawing.Point(314, 231);
            this.labelPatientNummer.Name = "labelPatientNummer";
            this.labelPatientNummer.Size = new System.Drawing.Size(77, 13);
            this.labelPatientNummer.TabIndex = 7;
            this.labelPatientNummer.Text = "Patientnummer";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(579, 231);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(88, 13);
            this.labelDatum.TabIndex = 8;
            this.labelDatum.Text = "Datum för besök ";
            // 
            // dateTimePickerBesok
            // 
            this.dateTimePickerBesok.Location = new System.Drawing.Point(582, 247);
            this.dateTimePickerBesok.Name = "dateTimePickerBesok";
            this.dateTimePickerBesok.Size = new System.Drawing.Size(134, 20);
            this.dateTimePickerBesok.TabIndex = 9;
            // 
            // textBoxBesokNummer
            // 
            this.textBoxBesokNummer.Location = new System.Drawing.Point(12, 247);
            this.textBoxBesokNummer.Name = "textBoxBesokNummer";
            this.textBoxBesokNummer.Size = new System.Drawing.Size(100, 20);
            this.textBoxBesokNummer.TabIndex = 10;
            // 
            // textBoxANummerLakare
            // 
            this.textBoxANummerLakare.Location = new System.Drawing.Point(156, 247);
            this.textBoxANummerLakare.Name = "textBoxANummerLakare";
            this.textBoxANummerLakare.Size = new System.Drawing.Size(133, 20);
            this.textBoxANummerLakare.TabIndex = 11;
            // 
            // textBoxPatientNummer
            // 
            this.textBoxPatientNummer.Location = new System.Drawing.Point(317, 247);
            this.textBoxPatientNummer.Name = "textBoxPatientNummer";
            this.textBoxPatientNummer.Size = new System.Drawing.Size(100, 20);
            this.textBoxPatientNummer.TabIndex = 12;
            // 
            // textBoxSyfte
            // 
            this.textBoxSyfte.Location = new System.Drawing.Point(454, 247);
            this.textBoxSyfte.Name = "textBoxSyfte";
            this.textBoxSyfte.Size = new System.Drawing.Size(100, 20);
            this.textBoxSyfte.TabIndex = 13;
            // 
            // buttonLaggTillBesok
            // 
            this.buttonLaggTillBesok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLaggTillBesok.Location = new System.Drawing.Point(299, 337);
            this.buttonLaggTillBesok.Name = "buttonLaggTillBesok";
            this.buttonLaggTillBesok.Size = new System.Drawing.Size(175, 59);
            this.buttonLaggTillBesok.TabIndex = 14;
            this.buttonLaggTillBesok.Text = "Lägg till besök";
            this.buttonLaggTillBesok.UseVisualStyleBackColor = true;
            this.buttonLaggTillBesok.Click += new System.EventHandler(this.buttonLaggTillBesok_Click);
            // 
            // buttonTillbaka
            // 
            this.buttonTillbaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTillbaka.Location = new System.Drawing.Point(679, 386);
            this.buttonTillbaka.Name = "buttonTillbaka";
            this.buttonTillbaka.Size = new System.Drawing.Size(109, 42);
            this.buttonTillbaka.TabIndex = 15;
            this.buttonTillbaka.Text = "Tillbaka";
            this.buttonTillbaka.UseVisualStyleBackColor = true;
            this.buttonTillbaka.Click += new System.EventHandler(this.buttonTillbaka_Click);
            // 
            // NyttBesok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTillbaka);
            this.Controls.Add(this.buttonLaggTillBesok);
            this.Controls.Add(this.textBoxSyfte);
            this.Controls.Add(this.textBoxPatientNummer);
            this.Controls.Add(this.textBoxANummerLakare);
            this.Controls.Add(this.textBoxBesokNummer);
            this.Controls.Add(this.dateTimePickerBesok);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelPatientNummer);
            this.Controls.Add(this.labelSyfte);
            this.Controls.Add(this.labelANummerLakare);
            this.Controls.Add(this.labelBesokNummer);
            this.Controls.Add(this.labelPatienter);
            this.Controls.Add(this.labelSjukSkotare);
            this.Controls.Add(this.dataGridViewPatienter);
            this.Controls.Add(this.dataGridViewSjukSkotare);
            this.Name = "NyttBesok";
            this.Text = "NyttBesok";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSjukSkotare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatienter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSjukSkotare;
        private System.Windows.Forms.DataGridView dataGridViewPatienter;
        private System.Windows.Forms.Label labelSjukSkotare;
        private System.Windows.Forms.Label labelPatienter;
        private System.Windows.Forms.Label labelBesokNummer;
        private System.Windows.Forms.Label labelANummerLakare;
        private System.Windows.Forms.Label labelSyfte;
        private System.Windows.Forms.Label labelPatientNummer;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.DateTimePicker dateTimePickerBesok;
        private System.Windows.Forms.TextBox textBoxBesokNummer;
        private System.Windows.Forms.TextBox textBoxANummerLakare;
        private System.Windows.Forms.TextBox textBoxPatientNummer;
        private System.Windows.Forms.TextBox textBoxSyfte;
        private System.Windows.Forms.Button buttonLaggTillBesok;
        private System.Windows.Forms.Button buttonTillbaka;
    }
}