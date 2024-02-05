namespace PatienthanteringPL
{
    partial class SkapaRecept
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
            this.dataGridViewVisaRecept = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxlakemedel = new System.Windows.Forms.TextBox();
            this.textBoxdosering = new System.Windows.Forms.TextBox();
            this.textBoxanledning = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisaRecept)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVisaRecept
            // 
            this.dataGridViewVisaRecept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisaRecept.Location = new System.Drawing.Point(393, 24);
            this.dataGridViewVisaRecept.Name = "dataGridViewVisaRecept";
            this.dataGridViewVisaRecept.RowHeadersWidth = 62;
            this.dataGridViewVisaRecept.RowTemplate.Height = 28;
            this.dataGridViewVisaRecept.Size = new System.Drawing.Size(395, 396);
            this.dataGridViewVisaRecept.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Läkemedel:";
            // 
            // textBoxlakemedel
            // 
            this.textBoxlakemedel.Location = new System.Drawing.Point(26, 48);
            this.textBoxlakemedel.Name = "textBoxlakemedel";
            this.textBoxlakemedel.Size = new System.Drawing.Size(230, 26);
            this.textBoxlakemedel.TabIndex = 2;
            this.textBoxlakemedel.TextChanged += new System.EventHandler(this.textBoxlakemedel_TextChanged);
            // 
            // textBoxdosering
            // 
            this.textBoxdosering.Location = new System.Drawing.Point(26, 131);
            this.textBoxdosering.Name = "textBoxdosering";
            this.textBoxdosering.Size = new System.Drawing.Size(230, 26);
            this.textBoxdosering.TabIndex = 3;
            this.textBoxdosering.TextChanged += new System.EventHandler(this.textBoxdosering_TextChanged);
            // 
            // textBoxanledning
            // 
            this.textBoxanledning.Location = new System.Drawing.Point(26, 217);
            this.textBoxanledning.Name = "textBoxanledning";
            this.textBoxanledning.Size = new System.Drawing.Size(230, 26);
            this.textBoxanledning.TabIndex = 4;
            this.textBoxanledning.TextChanged += new System.EventHandler(this.textBoxanledning_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dosering:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Anledning till beslut:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lägg till recept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SkapaRecept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxanledning);
            this.Controls.Add(this.textBoxdosering);
            this.Controls.Add(this.textBoxlakemedel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewVisaRecept);
            this.Name = "SkapaRecept";
            this.Text = "SkapaRecept";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisaRecept)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVisaRecept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxlakemedel;
        private System.Windows.Forms.TextBox textBoxdosering;
        private System.Windows.Forms.TextBox textBoxanledning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}