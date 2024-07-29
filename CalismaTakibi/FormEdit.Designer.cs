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
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.tBoxCat = new System.Windows.Forms.TextBox();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.tBoxDiff = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.radioButtonEkle = new System.Windows.Forms.RadioButton();
            this.radioButtonSil = new System.Windows.Forms.RadioButton();
            this.buttonSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCat
            // 
            this.dataGridViewCat.AllowUserToAddRows = false;
            this.dataGridViewCat.AllowUserToDeleteRows = false;
            this.dataGridViewCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCat.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCat.Name = "dataGridViewCat";
            this.dataGridViewCat.ReadOnly = true;
            this.dataGridViewCat.Size = new System.Drawing.Size(460, 212);
            this.dataGridViewCat.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kategori :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Çalışma Türü :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 259);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // tBoxID
            // 
            this.tBoxID.Location = new System.Drawing.Point(139, 106);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(132, 20);
            this.tBoxID.TabIndex = 9;
            // 
            // tBoxCat
            // 
            this.tBoxCat.Location = new System.Drawing.Point(139, 131);
            this.tBoxCat.Name = "tBoxCat";
            this.tBoxCat.Size = new System.Drawing.Size(132, 20);
            this.tBoxCat.TabIndex = 10;
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(139, 157);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(132, 20);
            this.tBoxName.TabIndex = 11;
            // 
            // tBoxDiff
            // 
            this.tBoxDiff.Location = new System.Drawing.Point(139, 185);
            this.tBoxDiff.Name = "tBoxDiff";
            this.tBoxDiff.Size = new System.Drawing.Size(132, 20);
            this.tBoxDiff.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(139, 217);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 36);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Ekle";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // radioButtonEkle
            // 
            this.radioButtonEkle.AutoSize = true;
            this.radioButtonEkle.Location = new System.Drawing.Point(46, 41);
            this.radioButtonEkle.Name = "radioButtonEkle";
            this.radioButtonEkle.Size = new System.Drawing.Size(85, 17);
            this.radioButtonEkle.TabIndex = 0;
            this.radioButtonEkle.TabStop = true;
            this.radioButtonEkle.Text = "Çalışma Ekle";
            this.radioButtonEkle.UseVisualStyleBackColor = true;
            this.radioButtonEkle.CheckedChanged += new System.EventHandler(this.radioButtonEkle_CheckedChanged);
            // 
            // radioButtonSil
            // 
            this.radioButtonSil.AutoSize = true;
            this.radioButtonSil.Location = new System.Drawing.Point(139, 41);
            this.radioButtonSil.Name = "radioButtonSil";
            this.radioButtonSil.Size = new System.Drawing.Size(75, 17);
            this.radioButtonSil.TabIndex = 1;
            this.radioButtonSil.TabStop = true;
            this.radioButtonSil.Text = "Çalışma Sil";
            this.radioButtonSil.UseVisualStyleBackColor = true;
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(139, 217);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(132, 36);
            this.buttonSil.TabIndex = 14;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Visible = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewCat);
            this.Name = "FormEdit";
            this.Text = "Kategori Düzenleme Modu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEdit_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}