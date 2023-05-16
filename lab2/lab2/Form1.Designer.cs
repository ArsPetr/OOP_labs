
namespace lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEFCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tepartmentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formOfEdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.create = new System.Windows.Forms.Button();
            this.HEI = new System.Windows.Forms.TextBox();
            this.fullName = new System.Windows.Forms.TextBox();
            this.formOfEd = new System.Windows.Forms.TextBox();
            this.faculty = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCol,
            this.fullNameCol,
            this.DateCol,
            this.HEFCol,
            this.facultyCol,
            this.tepartmentCol,
            this.formOfEdCol});
            this.dataGridView1.Location = new System.Drawing.Point(311, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(744, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // IDCol
            // 
            this.IDCol.HeaderText = "ID";
            this.IDCol.Name = "IDCol";
            // 
            // fullNameCol
            // 
            this.fullNameCol.HeaderText = "ФИО";
            this.fullNameCol.Name = "fullNameCol";
            // 
            // DateCol
            // 
            this.DateCol.HeaderText = "Дата зачисления";
            this.DateCol.Name = "DateCol";
            // 
            // HEFCol
            // 
            this.HEFCol.HeaderText = "ВУЗ";
            this.HEFCol.Name = "HEFCol";
            // 
            // facultyCol
            // 
            this.facultyCol.HeaderText = "Факультет";
            this.facultyCol.Name = "facultyCol";
            // 
            // tepartmentCol
            // 
            this.tepartmentCol.HeaderText = "Специальность";
            this.tepartmentCol.Name = "tepartmentCol";
            // 
            // formOfEdCol
            // 
            this.formOfEdCol.HeaderText = "Форма обучения";
            this.formOfEdCol.Name = "formOfEdCol";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(172, 247);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 2;
            this.create.Text = "Создать";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // HEI
            // 
            this.HEI.Location = new System.Drawing.Point(112, 131);
            this.HEI.Name = "HEI";
            this.HEI.Size = new System.Drawing.Size(193, 23);
            this.HEI.TabIndex = 3;
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(112, 73);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(193, 23);
            this.fullName.TabIndex = 4;
            // 
            // formOfEd
            // 
            this.formOfEd.Location = new System.Drawing.Point(112, 218);
            this.formOfEd.Name = "formOfEd";
            this.formOfEd.Size = new System.Drawing.Size(193, 23);
            this.formOfEd.TabIndex = 5;
            // 
            // faculty
            // 
            this.faculty.Location = new System.Drawing.Point(112, 160);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(193, 23);
            this.faculty.TabIndex = 6;
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(112, 189);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(193, 23);
            this.department.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "ВУЗ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Факультет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Специальность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Форма обучения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 384);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.department);
            this.Controls.Add(this.faculty);
            this.Controls.Add(this.formOfEd);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.HEI);
            this.Controls.Add(this.create);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Лаба 2-3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox HEI;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.TextBox formOfEd;
        private System.Windows.Forms.TextBox faculty;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEFCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tepartmentCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn formOfEdCol;
    }
}

