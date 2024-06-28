using F1RACE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1RACE
{
    public partial class AddDriver : Form
    {

        public Driver driver;
        private ErrorProvider errorProvider;
        public AddDriver()
        {
            InitializeComponent();
            driver = new Driver();
            errorProvider = new ErrorProvider();

            SubscribeValidators();
        }

        private void SubscribeValidators()
        {
            tbName.Validating += nameValidator;
        }

        private void handleAddDriver(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                driver=new Driver(tbName.Text.Trim(),(int)nudAge.Value,isFirst.Checked);
                DialogResult= DialogResult.OK;
            }
        }

        private void handleCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void nameValidator(object sender, CancelEventArgs e)
        {
            if(tbName.Text.Trim().Length == 0) {
                errorProvider.SetError(tbName, "NAME CANNOT BE EMPTY");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbName, null);
                e.Cancel = false;
            }

        }
    }
}
