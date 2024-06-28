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
    public partial class AddStudent : Form
    {

        public Student student;
        private ErrorProvider errorProvider1;
        public AddStudent()
        {
            InitializeComponent();
            student = new Student();
            errorProvider1 = new ErrorProvider();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addStd(object sender, EventArgs e)
        {
            if(tbIndex.TextLength > 0 && tbName.TextLength> 0)
            {
                this.student = new Student(tbIndex.Text,tbName.Text);
                this.DialogResult= DialogResult.OK;
            }
        }

        private void handleCancel(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void validateIndex(object sender, CancelEventArgs e)
        {
            if(tbIndex.Text.Length == 6)
            {
                errorProvider1.SetError(tbIndex, null);
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(tbIndex, "INDEX NEEDS TO BE OF LENGTH 6");
                e.Cancel = true;
            }

        }

        private void validateName(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Length > 0)
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(tbName, "NAME NEEDS TO HAVE AT LEAST ONE CHARACTER");
                e.Cancel = true;
            }
        }
    }
}
