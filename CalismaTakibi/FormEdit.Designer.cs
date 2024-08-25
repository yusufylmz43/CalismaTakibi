namespace CalismaTakibi
{
    partial class FormEdit
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
            this.dataGridViewCat = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.radioButtonSil = new System.Windows.Forms.RadioButton();
            this.radioButtonEkle = new System.Windows.Forms.RadioButton();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tBoxDiff = new System.Windows.Forms.TextBox();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.tBoxCat = new System.Windows.Forms.TextBox();
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.dataGridViewYap = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonYSil = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.numericUDY = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerY = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.tBoxPuanY = new System.Windows.Forms.TextBox();
            this.tBoxIDY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tBoxNameY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBoxCatY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYap)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDY)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCat
            // 
            this.dataGridViewCat.AllowUserToAddRows = false;
            this.dataGridViewCat.AllowUserToDeleteRows = false;
            this.dataGridViewCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCat.Location = new System.Drawing.Point(683, 15);
            this.dataGridViewCat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCat.Name = "dataGridViewCat";
            this.dataGridViewCat.ReadOnly = true;
            this.dataGridViewCat.RowHeadersWidth = 51;
            this.dataGridViewCat.Size = new System.Drawing.Size(613, 261);
            this.dataGridViewCat.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kategori :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Çalışma Türü :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Zorluk :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSil);
            this.groupBox1.Controls.Add(this.radioButtonSil);
            this.groupBox1.Controls.Add(this.radioButtonEkle);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.tBoxDiff);
            this.groupBox1.Controls.Add(this.tBoxName);
            this.groupBox1.Controls.Add(this.tBoxCat);
            this.groupBox1.Controls.Add(this.tBoxID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(659, 261);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(185, 209);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(176, 44);
            this.buttonSil.TabIndex = 14;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Visible = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // radioButtonSil
            // 
            this.radioButtonSil.AutoSize = true;
            this.radioButtonSil.Location = new System.Drawing.Point(172, 23);
            this.radioButtonSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonSil.Name = "radioButtonSil";
            this.radioButtonSil.Size = new System.Drawing.Size(95, 20);
            this.radioButtonSil.TabIndex = 1;
            this.radioButtonSil.TabStop = true;
            this.radioButtonSil.Text = "Çalışma Sil";
            this.radioButtonSil.UseVisualStyleBackColor = true;
            // 
            // radioButtonEkle
            // 
            this.radioButtonEkle.AutoSize = true;
            this.radioButtonEkle.Location = new System.Drawing.Point(36, 23);
            this.radioButtonEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonEkle.Name = "radioButtonEkle";
            this.radioButtonEkle.Size = new System.Drawing.Size(107, 20);
            this.radioButtonEkle.TabIndex = 0;
            this.radioButtonEkle.TabStop = true;
            this.radioButtonEkle.Text = "Çalışma Ekle";
            this.radioButtonEkle.UseVisualStyleBackColor = true;
            this.radioButtonEkle.CheckedChanged += new System.EventHandler(this.radioButtonEkle_CheckedChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(185, 209);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(176, 44);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Ekle";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tBoxDiff
            // 
            this.tBoxDiff.Location = new System.Drawing.Point(185, 178);
            this.tBoxDiff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxDiff.Name = "tBoxDiff";
            this.tBoxDiff.Size = new System.Drawing.Size(175, 22);
            this.tBoxDiff.TabIndex = 12;
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(185, 142);
            this.tBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(175, 22);
            this.tBoxName.TabIndex = 11;
            // 
            // tBoxCat
            // 
            this.tBoxCat.Location = new System.Drawing.Point(185, 102);
            this.tBoxCat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxCat.Name = "tBoxCat";
            this.tBoxCat.Size = new System.Drawing.Size(175, 22);
            this.tBoxCat.TabIndex = 10;
            // 
            // tBoxID
            // 
            this.tBoxID.Location = new System.Drawing.Point(185, 66);
            this.tBoxID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(175, 22);
            this.tBoxID.TabIndex = 9;
            // 
            // dataGridViewYap
            // 
            this.dataGridViewYap.AllowUserToAddRows = false;
            this.dataGridViewYap.AllowUserToDeleteRows = false;
            this.dataGridViewYap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYap.Location = new System.Drawing.Point(495, 304);
            this.dataGridViewYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewYap.Name = "dataGridViewYap";
            this.dataGridViewYap.ReadOnly = true;
            this.dataGridViewYap.RowHeadersWidth = 51;
            this.dataGridViewYap.Size = new System.Drawing.Size(801, 380);
            this.dataGridViewYap.TabIndex = 10;
            this.dataGridViewYap.SelectionChanged += new System.EventHandler(this.dataGridViewYap_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(32, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonYSil);
            this.groupBox2.Controls.Add(this.buttonUpd);
            this.groupBox2.Controls.Add(this.numericUDY);
            this.groupBox2.Controls.Add(this.dateTimePickerY);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tBoxPuanY);
            this.groupBox2.Controls.Add(this.tBoxIDY);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tBoxNameY);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tBoxCatY);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(16, 304);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(471, 380);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // buttonYSil
            // 
            this.buttonYSil.Location = new System.Drawing.Point(369, 276);
            this.buttonYSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonYSil.Name = "buttonYSil";
            this.buttonYSil.Size = new System.Drawing.Size(73, 44);
            this.buttonYSil.TabIndex = 23;
            this.buttonYSil.Text = "Sil";
            this.buttonYSil.UseVisualStyleBackColor = true;
            this.buttonYSil.Click += new System.EventHandler(this.buttonYSil_Click);
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(185, 276);
            this.buttonUpd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(176, 44);
            this.buttonUpd.TabIndex = 22;
            this.buttonUpd.Text = "Güncelle";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // numericUDY
            // 
            this.numericUDY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUDY.Location = new System.Drawing.Point(185, 193);
            this.numericUDY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUDY.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.numericUDY.Name = "numericUDY";
            this.numericUDY.Size = new System.Drawing.Size(176, 22);
            this.numericUDY.TabIndex = 21;
            this.numericUDY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePickerY
            // 
            this.dateTimePickerY.Location = new System.Drawing.Point(185, 37);
            this.dateTimePickerY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerY.Name = "dateTimePickerY";
            this.dateTimePickerY.Size = new System.Drawing.Size(207, 22);
            this.dateTimePickerY.TabIndex = 20;
            this.dateTimePickerY.ValueChanged += new System.EventHandler(this.dateTimePickerY_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(31, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tarih :";
            // 
            // tBoxPuanY
            // 
            this.tBoxPuanY.Location = new System.Drawing.Point(185, 229);
            this.tBoxPuanY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxPuanY.Name = "tBoxPuanY";
            this.tBoxPuanY.Size = new System.Drawing.Size(175, 22);
            this.tBoxPuanY.TabIndex = 18;
            // 
            // tBoxIDY
            // 
            this.tBoxIDY.Location = new System.Drawing.Point(185, 78);
            this.tBoxIDY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxIDY.Name = "tBoxIDY";
            this.tBoxIDY.ReadOnly = true;
            this.tBoxIDY.Size = new System.Drawing.Size(175, 22);
            this.tBoxIDY.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(32, 230);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Puan :";
            // 
            // tBoxNameY
            // 
            this.tBoxNameY.Location = new System.Drawing.Point(185, 153);
            this.tBoxNameY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxNameY.Name = "tBoxNameY";
            this.tBoxNameY.Size = new System.Drawing.Size(175, 22);
            this.tBoxNameY.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(32, 193);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Süre :";
            // 
            // tBoxCatY
            // 
            this.tBoxCatY.Location = new System.Drawing.Point(185, 117);
            this.tBoxCatY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxCatY.Name = "tBoxCatY";
            this.tBoxCatY.Size = new System.Drawing.Size(175, 22);
            this.tBoxCatY.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(32, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Kategori :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(32, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Çalışma Türü :";
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 752);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewCat);
            this.Controls.Add(this.dataGridViewYap);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Düzenleme Modu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEdit_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBoxDiff;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.TextBox tBoxCat;
        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RadioButton radioButtonSil;
        private System.Windows.Forms.RadioButton radioButtonEkle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.DataGridView dataGridViewYap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tBoxPuanY;
        private System.Windows.Forms.TextBox tBoxIDY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBoxNameY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBoxCatY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUDY;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonYSil;
    }
}