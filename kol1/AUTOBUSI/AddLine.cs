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
    public partial class AddLine : Form
    {

        public Line line;
        private ErrorProvider errorProvider;
        public AddLine()
        {
            InitializeComponent();
            line = new Line();
            errorProvider = new ErrorProvider();

            SubscribeValidators();
        }

        private void SubscribeValidators()
        {
            tbDestinationLine.Validating += validateDestination;
            button1.Click += handleConfirm;
            button2.Click += handleCancel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void handleConfirm(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                line = new Line(tbDestinationLine.Text.Trim(), (int)nudHour.Value, (int)nudMinutes.Value, (int)nudPrice.Value);
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }

        }

        private void handleCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void validateDestination(object sender, CancelEventArgs e)
        { 
             if(tbDestinationLine.Text.Trim().Length == 0) {

                errorProvider.SetError(tbDestinationLine, "DESTINATION CANNOT BE EMPTY");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbDestinationLine, null);
                e.Cancel = false;
            }
        }
    }
}
