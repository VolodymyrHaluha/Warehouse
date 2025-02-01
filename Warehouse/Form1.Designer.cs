namespace Warehouse
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
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search2 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.SubstanceName = new System.Windows.Forms.Label();
            this.QuantityKg = new System.Windows.Forms.Label();
            this.DateAdded = new System.Windows.Forms.Label();
            this.Posta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_Posta = new System.Windows.Forms.TextBox();
            this.textBox_Date = new System.Windows.Forms.TextBox();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_search
            // 
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_search.Location = new System.Drawing.Point(81, 12);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(222, 20);
            this.textBox_search.TabIndex = 0;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Запис:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(642, 229);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пошук";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_search2
            // 
            this.btn_search2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search2.Location = new System.Drawing.Point(309, 12);
            this.btn_search2.Name = "btn_search2";
            this.btn_search2.Size = new System.Drawing.Size(142, 28);
            this.btn_search2.TabIndex = 4;
            this.btn_search2.Text = "Пошук";
            this.btn_search2.UseVisualStyleBackColor = true;
            this.btn_search2.Click += new System.EventHandler(this.btn_search2_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(68, 32);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(16, 13);
            this.ID.TabIndex = 5;
            this.ID.Text = "Id";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // SubstanceName
            // 
            this.SubstanceName.AutoSize = true;
            this.SubstanceName.Location = new System.Drawing.Point(68, 61);
            this.SubstanceName.Name = "SubstanceName";
            this.SubstanceName.Size = new System.Drawing.Size(39, 13);
            this.SubstanceName.TabIndex = 6;
            this.SubstanceName.Text = "Назва";
            this.SubstanceName.Click += new System.EventHandler(this.label4_Click);
            // 
            // QuantityKg
            // 
            this.QuantityKg.AutoSize = true;
            this.QuantityKg.Location = new System.Drawing.Point(68, 90);
            this.QuantityKg.Name = "QuantityKg";
            this.QuantityKg.Size = new System.Drawing.Size(31, 13);
            this.QuantityKg.TabIndex = 7;
            this.QuantityKg.Text = "Вага";
            this.QuantityKg.Click += new System.EventHandler(this.QuantityKg_Click);
            // 
            // DateAdded
            // 
            this.DateAdded.AutoSize = true;
            this.DateAdded.Location = new System.Drawing.Point(29, 117);
            this.DateAdded.Name = "DateAdded";
            this.DateAdded.Size = new System.Drawing.Size(78, 13);
            this.DateAdded.TabIndex = 8;
            this.DateAdded.Text = "Дата довання";
            this.DateAdded.Click += new System.EventHandler(this.DateAdded_Click);
            // 
            // Posta
            // 
            this.Posta.AutoSize = true;
            this.Posta.Location = new System.Drawing.Point(29, 148);
            this.Posta.Name = "Posta";
            this.Posta.Size = new System.Drawing.Size(79, 13);
            this.Posta.TabIndex = 9;
            this.Posta.Text = "Постачальник";
            this.Posta.Click += new System.EventHandler(this.Posta_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(133, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(133, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(133, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(132, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 20);
            this.textBox4.TabIndex = 12;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(133, 141);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 20);
            this.textBox6.TabIndex = 14;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(19, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Керування записами:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(66, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Новий запис";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(66, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 25);
            this.button2.TabIndex = 17;
            this.button2.Text = "Видалити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(66, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 25);
            this.button3.TabIndex = 19;
            this.button3.Text = "Зберегти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(66, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 25);
            this.button4.TabIndex = 18;
            this.button4.Text = "Поміняти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Posta);
            this.panel1.Controls.Add(this.DateAdded);
            this.panel1.Controls.Add(this.QuantityKg);
            this.panel1.Controls.Add(this.SubstanceName);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 198);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox_Posta);
            this.panel2.Controls.Add(this.textBox_Date);
            this.panel2.Controls.Add(this.textBox_Quantity);
            this.panel2.Controls.Add(this.textBox_Name);
            this.panel2.Controls.Add(this.textBox_id);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 198);
            this.panel2.TabIndex = 21;
            // 
            // textBox_Posta
            // 
            this.textBox_Posta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Posta.Location = new System.Drawing.Point(133, 141);
            this.textBox_Posta.Name = "textBox_Posta";
            this.textBox_Posta.Size = new System.Drawing.Size(132, 20);
            this.textBox_Posta.TabIndex = 14;
            // 
            // textBox_Date
            // 
            this.textBox_Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Date.Location = new System.Drawing.Point(133, 110);
            this.textBox_Date.Name = "textBox_Date";
            this.textBox_Date.Size = new System.Drawing.Size(132, 20);
            this.textBox_Date.TabIndex = 13;
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Quantity.Location = new System.Drawing.Point(132, 81);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(132, 20);
            this.textBox_Quantity.TabIndex = 12;
            // 
            // textBox_Name
            // 
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Name.Location = new System.Drawing.Point(133, 54);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(132, 20);
            this.textBox_Name.TabIndex = 11;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // textBox_id
            // 
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_id.Location = new System.Drawing.Point(133, 25);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(132, 20);
            this.textBox_id.TabIndex = 10;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Постачальник";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата довання";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Вага";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Назва";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Запис:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(431, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 195);
            this.panel3.TabIndex = 21;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(723, 46);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 37);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Оновити";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(723, 113);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 37);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 567);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_search2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search2;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label SubstanceName;
        private System.Windows.Forms.Label QuantityKg;
        private System.Windows.Forms.Label DateAdded;
        private System.Windows.Forms.Label Posta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_Posta;
        private System.Windows.Forms.TextBox textBox_Date;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
    }
}

