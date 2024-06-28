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
    public partial class AddAirport : Form
    {
        public Airport airport;
        private ErrorProvider errorProvider;

        public AddAirport()
        {
            InitializeComponent();
            airport = new Airport();
            errorProvider = new ErrorProvider();
            SubscribeValidators();
        }

        private void SubscribeValidators()
        {
            tbName.Validating += tbNameValidator;
            tbCity.Validating += tbCityValidator;
            tbKratenka.Validating += tbKratenkaValidator;

            btnConfirm.Click += handleConfirm;
            btnCancel.Click += handleCancel;    

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void handleConfirm(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                airport = new Airport(tbName.Text.Trim(), tbKratenka.Text.Trim(), tbCity.Text.Trim());
                DialogResult = DialogResult.OK;
            }
        }

        private void handleCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbCityValidator(object sender, CancelEventArgs e)
        {
            if (tbCity.Text.Trim().Length == 0)
            {
                errorProvider.SetError(tbCity, "DESTINATION NAME CANNOT BE EMPTY");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbCity, null);
                e.Cancel = false;
            }
        }

        private void tbNameValidator(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {
                errorProvider.SetError(tbName, "DESTINATION NAME CANNOT BE EMPTY");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbName, null);
                e.Cancel = false;
            }

        }

        private void tbKratenkaValidator(object sender, CancelEventArgs e)
        {
            if (tbKratenka.Text.Trim().Length != 3)
            {
                errorProvider.SetError(tbKratenka, "KRATENKA MUST BE OF LENGTH 3");
                e.Cancel = true;
            }
            else
            {
                if (allUpperCase(tbKratenka.Text))
                {
                    errorProvider.SetError(tbKratenka, null);
                    e.Cancel = false;
                }
                else
                {
                    errorProvider.SetError(tbKratenka, "KRATENKA MUST BE ALL UPPERCASE");
                    e.Cancel = true;
                }
            }

        }

        private bool allUpperCase(string text)
        {
            bool result = true;
            foreach(char c in text)
            {
                if (Char.IsLower(c) || Char.IsDigit(c))
                {
                    result = false;
                }
            }
            return result;
        }



    }
}
