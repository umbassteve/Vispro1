namespace Project_Vispro
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_BACK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNamaKost = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxJenisKost = new System.Windows.Forms.TextBox();
            this.BTN_DISPLAYS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(183, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(911, 223);
            this.dataGridView1.TabIndex = 0;
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_SEARCH.Location = new System.Drawing.Point(984, 84);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(110, 39);
            this.BTN_SEARCH.TabIndex = 1;
            this.BTN_SEARCH.Text = "Search";
            this.BTN_SEARCH.UseVisualStyleBackColor = false;
            this.BTN_SEARCH.Click += new System.EventHandler(this.BTN_SEARCH_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(662, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Boarding House Search";
            // 
            // BTN_BACK
            // 
            this.BTN_BACK.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_BACK.Location = new System.Drawing.Point(1135, 596);
            this.BTN_BACK.Name = "BTN_BACK";
            this.BTN_BACK.Size = new System.Drawing.Size(110, 39);
            this.BTN_BACK.TabIndex = 6;
            this.BTN_BACK.Text = "Back";
            this.BTN_BACK.UseVisualStyleBackColor = false;
            this.BTN_BACK.Click += new System.EventHandler(this.BTN_BACK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nama Kost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Harga";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 596);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Jenis Kost";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(329, 399);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(441, 26);
            this.textBoxID.TabIndex = 12;
            // 
            // textBoxNamaKost
            // 
            this.textBoxNamaKost.Location = new System.Drawing.Point(329, 450);
            this.textBoxNamaKost.Name = "textBoxNamaKost";
            this.textBoxNamaKost.Size = new System.Drawing.Size(441, 26);
            this.textBoxNamaKost.TabIndex = 13;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(329, 499);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(441, 26);
            this.textBoxAlamat.TabIndex = 14;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(329, 542);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(441, 26);
            this.textBoxHarga.TabIndex = 15;
            // 
            // textBoxJenisKost
            // 
            this.textBoxJenisKost.Location = new System.Drawing.Point(329, 596);
            this.textBoxJenisKost.Name = "textBoxJenisKost";
            this.textBoxJenisKost.Size = new System.Drawing.Size(441, 26);
            this.textBoxJenisKost.TabIndex = 16;
            // 
            // BTN_DISPLAYS
            // 
            this.BTN_DISPLAYS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_DISPLAYS.Location = new System.Drawing.Point(984, 399);
            this.BTN_DISPLAYS.Name = "BTN_DISPLAYS";
            this.BTN_DISPLAYS.Size = new System.Drawing.Size(110, 39);
            this.BTN_DISPLAYS.TabIndex = 17;
            this.BTN_DISPLAYS.Text = "Displays";
            this.BTN_DISPLAYS.UseVisualStyleBackColor = false;
            this.BTN_DISPLAYS.Click += new System.EventHandler(this.BTN_DISPLAYS_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1257, 647);
            this.Controls.Add(this.BTN_DISPLAYS);
            this.Controls.Add(this.textBoxJenisKost);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.textBoxNamaKost);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_BACK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTN_SEARCH);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_SEARCH;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_BACK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNamaKost;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxJenisKost;
        private System.Windows.Forms.Button BTN_DISPLAYS;
    }
}