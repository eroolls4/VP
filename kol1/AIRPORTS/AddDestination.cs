using AIRPORTS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIRPORTS
{
    public partial class AddDestination : Form
    {

        public Destination destination;
        private ErrorProvider errorProvider;

        public AddDestination()
        {
            InitializeComponent();
            destination = new Destination();
            errorProvider = new ErrorProvider();
            SubscibeValidators();
        }


        private void SubscibeValidators()
        {
            tbDestName.Validating += destNameValidator;
            button1.Click += handleBtnConfirm;
            button2.Click += handleCancel;
        }



        private void handleBtnConfirm(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                destination = new Destination(tbDestName.Text, nudLength.Value, nudPrice.Value);
                DialogResult = DialogResult.OK;
            }
      
        }

        private void destNameValidator(object sender, CancelEventArgs e)
        {
            if(tbDestName.Text.Trim().Length == 0 )
            {
                errorProvider.SetError(tbDestName, "DESTINATION NAME CANNOT BE EMPTY");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbDestName, null);
                e.Cancel = false;
            }
        }

        private void handleCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
