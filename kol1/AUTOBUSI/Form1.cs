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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBusses.SelectedItems.Count > 0)
            {
                Autobus autobus = lbBusses.SelectedItem as Autobus;
                updateLineListBoxForBuss(autobus);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void handleAddNewBuss(object sender, EventArgs e)
        {
            AddBuss frm = new AddBuss();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                lbBusses.Items.Add(frm.buss);
                updateLineListBoxForBuss(frm.buss);
            }

        }

        private void handleRemoveBuss(object sender, EventArgs e)
        {
            if (lbBusses.SelectedItems.Count > 0)
            {
                Autobus autobus = lbBusses.SelectedItem as Autobus;
                autobus.Lines.Clear();
                lbBusses.Items.Remove(autobus);
                ClearBoxes();
            }

        }



        private void ClearBoxes()
        {
            lbLines.Items.Clear();
            tbAvgPrice.Clear();
            tbMostExpensive.Clear();
        }

        private void handleAddLine(object sender, EventArgs e)
        {
            if (lbBusses.SelectedItems.Count > 0)
            {
                AddLine frm = new AddLine();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Autobus autobus = lbBusses.SelectedItem as Autobus;
                    autobus.addLine(frm.line);
                    updateLineListBoxForBuss(autobus);
                }

            }
        }



        private void updateDetailsPart(Autobus autobus)
        {
            if (autobus.Lines.Count > 0)
            {
                tbAvgPrice.Text=autobus.getAvgPrice().ToString();
                tbMostExpensive.Text = autobus.mostExpensive().ToString();
            }
            else
            {
                tbAvgPrice.Text = "NO LINES YET !!!";
                tbMostExpensive.Text = "NO LINES YET !!!";
            }
        }


        private void updateLineListBoxForBuss(Autobus buss)
        {
            ClearBoxes();
            lbLines.Items.AddRange(buss.Lines.ToArray());
            updateDetailsPart(buss);
        }
    }
}
