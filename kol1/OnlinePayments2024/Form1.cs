using OnlinePayments2024.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlinePayments2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDetails();
        }

        private void handleAddPayment(object sender, EventArgs e)
        {
            if (lbStudents.SelectedItems.Count > 0)
            {
                Student student = lbStudents.SelectedItem as Student;
                student.AddPayment(new Payment(nudUplata.Value));
                UpdateDetails();
                UpdateForMax();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (lbStudents.SelectedItems.Count > 0)
            {
                if(MessageBox.Show("Dali si siguren?" , "Siguren li si?" , MessageBoxButtons.YesNo) == DialogResult.Yes){
                    Student selectedStudent = lbStudents.SelectedItem as Student;
                    selectedStudent.Payments.Clear();
                    UpdateDetails();
                    UpdateForMax();
                }
           
            }
        }

        private void handleAdd(object sender, EventArgs e)
        {
            AddStudent frm = new AddStudent();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                lbStudents.Items.Add(frm.student);
            }

        }


        private void UpdateDetails()
        {
            if (lbStudents.SelectedItems.Count > 0)
            {
                Student selectedStudent = lbStudents.SelectedItem as Student;
                lbSelectedStudentDetails.Text = selectedStudent.Details();
            }
        }


        private void  UpdateForMax()
        {
            Student max = lbStudents.Items[0] as Student;
            foreach (var item in lbStudents.Items)
            {
                Student student = item as Student;
                if (student.TotalAmount() > max.TotalAmount())
                {
                    max = student;
                }
            }
            tbMaxStudent.Text=max.ToString();
        }

      
    }
}
