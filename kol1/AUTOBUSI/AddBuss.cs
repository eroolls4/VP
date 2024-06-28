using AUTOBUSI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUTOBUSI
{
    public partial class AddBuss : Form
    {

        public Autobus buss;
        private ErrorProvider errorProvider;
        public AddBuss()
        {
            InitializeComponent();
            buss = new Autobus();
            errorProvider = new ErrorProvider();

            SubscribeValidators();
        }


        private void SubscribeValidators()
        {
            tbName.Validating += validateName;
            tbRegistration.Validating += regValidator;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void validateName(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {

                errorProvider.SetError(tbName, "NAME CANNOT BE EMPTY");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void regValidator(object sender, CancelEventArgs e)
        {
            if (tbRegistration.Text.Trim().Length != 4)
            {

                errorProvider.SetError(tbRegistration, "REG NEEDS TO BE EXCAT 4 LENGTH");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbRegistration, null);
                e.Cancel = false;
            }
        }

        private void handleConfirm(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                buss=new Autobus(tbRegistration.Text.Trim(),tbName.Text.Trim(),isLocal.Checked);
                DialogResult = DialogResult.OK;
            }

        }

        private void handleCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
