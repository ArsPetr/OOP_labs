using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void create_Click(object sender, EventArgs e)
        {
            students.Add(new Student(Student.Counter, fullName.Text,dateTimePicker1.Value,HEI.Text,faculty.Text,department.Text,formOfEd.Text));                 
            updateTable();
        }

        private void updateTable()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Student.Counter; i++)
            {              
                dataGridView1.Rows.Add(students[i].Id, students[i].FullName, students[i].EnrollDate, students[i].HEI, 
                                        students[i].Faculty,students[i].Department, students[i].FormOfEd);        
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        students[e.RowIndex].Id = (int)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        break;
                    case 1:
                        students[e.RowIndex].FullName = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        break;
                    case 2:
                        DateTime dt;
                        if (DateTime.TryParse((string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value, out dt))
                        {
                            students[e.RowIndex].EnrollDate = dt;
                        }
                        else 
                        {
                            NewInvalidCastException x = new NewInvalidCastException("Неверная дата");
                            x.Time = DateTime.Now;
                            throw x;
                        } 
                            
                        break;
                    case 3:
                        students[e.RowIndex].HEI = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        break;
                    case 4:
                        students[e.RowIndex].Faculty = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        break;
                    case 5:
                        students[e.RowIndex].Department = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        break;
                    case 6:
                        students[e.RowIndex].FormOfEd = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        break;
                }
            }
            catch (NewInvalidCastException ex)
            {
                MessageBox.Show(ex.Message + "Время ошибки: " + ex.Time,"Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            updateTable();
        }
    }
}
