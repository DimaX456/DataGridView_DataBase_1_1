namespace DataGridView1
{
    partial class Abiturienttinfo_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NUDInf = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.NUDRus = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.NUDMatem = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFormaObychenia = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btReady = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMatem)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 899);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pictureBox1.Image = global::DataGridView1.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(13, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.HotPink;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(140, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Информация об абитуриенте";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.NUDInf);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.NUDRus);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.NUDMatem);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbFormaObychenia);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbGender);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 714);
            this.panel2.TabIndex = 0;
            // 
            // NUDInf
            // 
            this.NUDInf.Location = new System.Drawing.Point(3, 502);
            this.NUDInf.Name = "NUDInf";
            this.NUDInf.Size = new System.Drawing.Size(491, 26);
            this.NUDInf.TabIndex = 19;
            this.NUDInf.ValueChanged += new System.EventHandler(this.NUDInf_ValueChanged);
            this.NUDInf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUDInf_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.HotPink;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(339, 33);
            this.label8.TabIndex = 19;
            this.label8.Text = "Баллы ЕГЭ по информатике";
            // 
            // NUDRus
            // 
            this.NUDRus.Location = new System.Drawing.Point(4, 428);
            this.NUDRus.Name = "NUDRus";
            this.NUDRus.Size = new System.Drawing.Size(491, 26);
            this.NUDRus.TabIndex = 18;
            this.NUDRus.ValueChanged += new System.EventHandler(this.NUDRus_ValueChanged);
            this.NUDRus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUDRus_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.HotPink;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(357, 33);
            this.label7.TabIndex = 17;
            this.label7.Text = "Баллы ЕГЭ по русскому языку";
            // 
            // NUDMatem
            // 
            this.NUDMatem.Location = new System.Drawing.Point(4, 351);
            this.NUDMatem.Name = "NUDMatem";
            this.NUDMatem.Size = new System.Drawing.Size(491, 26);
            this.NUDMatem.TabIndex = 17;
            this.NUDMatem.ValueChanged += new System.EventHandler(this.NUDMatem_ValueChanged);
            this.NUDMatem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUDMatem_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.HotPink;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(5, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 33);
            this.label6.TabIndex = 15;
            this.label6.Text = "Баллы ЕГЭ по математике";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.HotPink;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "Форма обучения";
            // 
            // cbFormaObychenia
            // 
            this.cbFormaObychenia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaObychenia.FormattingEnabled = true;
            this.cbFormaObychenia.Location = new System.Drawing.Point(4, 274);
            this.cbFormaObychenia.Name = "cbFormaObychenia";
            this.cbFormaObychenia.Size = new System.Drawing.Size(491, 28);
            this.cbFormaObychenia.TabIndex = 13;
            this.cbFormaObychenia.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbFormaObychenia_DrawItem);
            this.cbFormaObychenia.SelectedIndexChanged += new System.EventHandler(this.cbFormaObychenia_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 199);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(491, 26);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.HotPink;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата рождения";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(4, 122);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(491, 28);
            this.cbGender.TabIndex = 10;
            this.cbGender.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbGender_DrawItem);
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.HotPink;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пол";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(4, 51);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(491, 26);
            this.tbName.TabIndex = 8;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.HotPink;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "ФИО";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Thistle;
            this.panel3.Controls.Add(this.btCancel);
            this.panel3.Controls.Add(this.btReady);
            this.panel3.Location = new System.Drawing.Point(0, 538);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 65);
            this.panel3.TabIndex = 0;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Khaki;
            this.btCancel.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(301, 8);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(199, 49);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btReady
            // 
            this.btReady.BackColor = System.Drawing.Color.Khaki;
            this.btReady.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btReady.Enabled = false;
            this.btReady.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btReady.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btReady.Location = new System.Drawing.Point(3, 9);
            this.btReady.Name = "btReady";
            this.btReady.Size = new System.Drawing.Size(199, 49);
            this.btReady.TabIndex = 0;
            this.btReady.Text = "Готово";
            this.btReady.UseVisualStyleBackColor = false;
            // 
            // Abiturienttinfo_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 794);
            this.Controls.Add(this.panel1);
            this.Name = "Abiturienttinfo_form";
            this.Text = "Абитуриент";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMatem)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown NUDInf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NUDRus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NUDMatem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFormaObychenia;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btReady;
    }
}