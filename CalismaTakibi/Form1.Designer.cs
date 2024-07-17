namespace CalismaTakibi
{
    partial class Form1
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
            this.dataGridViewYapilanlar = new System.Windows.Forms.DataGridView();
            this.comboBoxKategoriler = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.labelCat = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPuan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBarStat = new System.Windows.Forms.ProgressBar();
            this.lblSonucAcklm = new System.Windows.Forms.Label();
            this.lblSonucPuan = new System.Windows.Forms.Label();
            this.lblSonucSure = new System.Windows.Forms.Label();
            this.buttonStatUpd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYapilanlar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewYapilanlar
            // 
            this.dataGridViewYapilanlar.AllowUserToAddRows = false;
            this.dataGridViewYapilanlar.AllowUserToDeleteRows = false;
            this.dataGridViewYapilanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYapilanlar.Location = new System.Drawing.Point(371, 12);
            this.dataGridViewYapilanlar.Name = "dataGridViewYapilanlar";
            this.dataGridViewYapilanlar.ReadOnly = true;
            this.dataGridViewYapilanlar.Size = new System.Drawing.Size(601, 587);
            this.dataGridViewYapilanlar.TabIndex = 0;
            // 
            // comboBoxKategoriler
            // 
            this.comboBoxKategoriler.FormattingEnabled = true;
            this.comboBoxKategoriler.Location = new System.Drawing.Point(127, 89);
            this.comboBoxKategoriler.Name = "comboBoxKategoriler";
            this.comboBoxKategoriler.Size = new System.Drawing.Size(206, 21);
            this.comboBoxKategoriler.TabIndex = 1;
            this.comboBoxKategoriler.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategoriler_SelectedIndexChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelID.Location = new System.Drawing.Point(50, 59);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(16, 18);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.labelCat);
            this.groupBox1.Controls.Add(this.lblBaslik);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxPuan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxKategoriler);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 298);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "Düzenle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCat.Location = new System.Drawing.Point(200, 59);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(61, 15);
            this.labelCat.TabIndex = 13;
            this.labelCat.Text = "Kategori";
            this.labelCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(111, 16);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(127, 26);
            this.lblBaslik.TabIndex = 12;
            this.lblBaslik.Text = "ÇALIŞMA EKLE";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(127, 236);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(206, 44);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Ekle";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kazanılacak Puan :";
            // 
            // textBoxPuan
            // 
            this.textBoxPuan.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxPuan.Enabled = false;
            this.textBoxPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPuan.Location = new System.Drawing.Point(222, 163);
            this.textBoxPuan.Name = "textBoxPuan";
            this.textBoxPuan.ReadOnly = true;
            this.textBoxPuan.Size = new System.Drawing.Size(97, 20);
            this.textBoxPuan.TabIndex = 9;
            this.textBoxPuan.Text = "0";
            this.textBoxPuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Süre (Dakika) :";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown.Location = new System.Drawing.Point(222, 127);
            this.numericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(111, 20);
            this.numericUpDown.TabIndex = 7;
            this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tarih :";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(75, 201);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker.Size = new System.Drawing.Size(258, 20);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Çalışma Türü :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.progressBarStat);
            this.groupBox2.Controls.Add(this.lblSonucAcklm);
            this.groupBox2.Controls.Add(this.lblSonucPuan);
            this.groupBox2.Controls.Add(this.lblSonucSure);
            this.groupBox2.Controls.Add(this.buttonStatUpd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 283);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // progressBarStat
            // 
            this.progressBarStat.Location = new System.Drawing.Point(18, 213);
            this.progressBarStat.Maximum = 130;
            this.progressBarStat.Name = "progressBarStat";
            this.progressBarStat.Size = new System.Drawing.Size(301, 23);
            this.progressBarStat.TabIndex = 22;
            // 
            // lblSonucAcklm
            // 
            this.lblSonucAcklm.AutoSize = true;
            this.lblSonucAcklm.Location = new System.Drawing.Point(153, 111);
            this.lblSonucAcklm.Name = "lblSonucAcklm";
            this.lblSonucAcklm.Size = new System.Drawing.Size(108, 13);
            this.lblSonucAcklm.TabIndex = 21;
            this.lblSonucAcklm.Text = "Günü verimli geçirdin.";
            // 
            // lblSonucPuan
            // 
            this.lblSonucPuan.AutoSize = true;
            this.lblSonucPuan.Location = new System.Drawing.Point(195, 84);
            this.lblSonucPuan.Name = "lblSonucPuan";
            this.lblSonucPuan.Size = new System.Drawing.Size(25, 13);
            this.lblSonucPuan.TabIndex = 20;
            this.lblSonucPuan.Text = "150";
            // 
            // lblSonucSure
            // 
            this.lblSonucSure.AutoSize = true;
            this.lblSonucSure.Location = new System.Drawing.Point(195, 56);
            this.lblSonucSure.Name = "lblSonucSure";
            this.lblSonucSure.Size = new System.Drawing.Size(40, 13);
            this.lblSonucSure.TabIndex = 19;
            this.lblSonucSure.Text = "600 dk";
            // 
            // buttonStatUpd
            // 
            this.buttonStatUpd.Location = new System.Drawing.Point(18, 242);
            this.buttonStatUpd.Name = "buttonStatUpd";
            this.buttonStatUpd.Size = new System.Drawing.Size(301, 35);
            this.buttonStatUpd.TabIndex = 18;
            this.buttonStatUpd.Text = "Güncelle";
            this.buttonStatUpd.UseVisualStyleBackColor = true;
            this.buttonStatUpd.Click += new System.EventHandler(this.buttonStatUpd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(15, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sonuç :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(15, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Toplam Puan :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Toplam Çalışma Süresi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(111, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "İSTATİSTİKLER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewYapilanlar);
            this.Name = "Form1";
            this.Text = "Çalışma Takibi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYapilanlar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewYapilanlar;
        private System.Windows.Forms.ComboBox comboBoxKategoriler;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPuan;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSonucAcklm;
        private System.Windows.Forms.Label lblSonucPuan;
        private System.Windows.Forms.Label lblSonucSure;
        private System.Windows.Forms.Button buttonStatUpd;
        private System.Windows.Forms.ProgressBar progressBarStat;
    }
}

