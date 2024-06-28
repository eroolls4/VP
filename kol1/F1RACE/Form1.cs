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
    public partial class Form1 : Form
    {

        private bool isChanging = false;
        private decimal prevValue;
        public Form1()
        {
            InitializeComponent();
            prevValue=nudSeconds.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void handleAddDriver(object sender, EventArgs e)
        {
            AddDriver frm = new AddDriver();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                lbDrivers.Items.Add(frm.driver);
            }
        }

        private void handleRemoveDriver(object sender, EventArgs e)
        {
            if (lbDrivers.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("DELETING DRIVER", "ARE U SURE ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Driver driver = lbDrivers.SelectedItem as Driver;
                    lbDrivers.Items.Remove(driver);
                    clearBoxes();
                }
            }
        }

        private void handleAddLap(object sender, EventArgs e)
        {
            if (lbDrivers.SelectedItems.Count > 0)
            {
                Driver driver = lbDrivers.SelectedItem as Driver;
                Lap lap = new Lap((int)nudMinutes.Value, (int)nudSeconds.Value);
                driver.addLap(lap);
                updateLapComponent(driver);
                nudMinutes.Value=0;
                nudSeconds.Value=0;

            }
        }

        private void clearBoxes()
        {
            lbLaps.Items.Clear();
            tbFastest.Clear();
        }

        private void handleIndexChange(object sender, EventArgs e)
        {
            if (lbDrivers.SelectedItems.Count > 0)
            {
                Driver driver = lbDrivers.SelectedItem as Driver;
                updateLapComponent(driver);
            }
        }



        private Lap findBestLapFromFiltered(List<Lap> Laps)
        {
            Lap res = Laps.ElementAt(0);
            foreach (var item in Laps.Skip(1))
            {
                if (item.getTime() < res.getTime())
                {
                    res = item;
                }
            };
            return res;
        }


        private void showGreaterThan(Driver driver,int seconds)
        {
            List<Lap> greaterThan = new List<Lap>();
            foreach (var item in driver.Laps)
            {
                if (item.Seconds > seconds)
                {
                    greaterThan.Add(item);
                }
            }

            lbLaps.Items.Clear();
            tbFastest.Clear();
            if (greaterThan.Count > 0)
            {
                lbLaps.Items.AddRange(greaterThan.ToArray());
                tbFastest.Text = findBestLapFromFiltered(greaterThan).ToString();
            }
            else
            {
                lbLaps.Text = "NO LAPS !!!";
            }
        }


        private void updateLapComponent(Driver driver)
        {
            lbLaps.Items.Clear();
            tbFastest.Clear();
            lbLaps.Items.AddRange(driver.Laps.ToArray());
            if(driver.Laps.Count > 0)
            {
                tbFastest.Text=driver.findFastestLap().ToString();
            }
            else
            {
                tbFastest.Text = "NO LAPS YET !!!";
            }
        }
        private void filterGreaterThan(object sender, EventArgs e)
        {
            if(lbDrivers.SelectedItems.Count > 0)
            {
                Driver driver = lbDrivers.SelectedItem as Driver;
                showGreaterThan(driver, (int)filterTime.Value);
            }
        }

        private void handleSecondsChange(object sender, EventArgs e)
        {
            if (isChanging)
                return;

            isChanging = true;
            decimal newValue = nudSeconds.Value;

            if (newValue > 59)
            {
                nudMinutes.Value += 1;
                nudSeconds.Value = 0;
            }

            else if (newValue < 0)
            {
                if (nudMinutes.Value > 0)
                {
                    nudMinutes.Value -= 1;
                    nudSeconds.Value = 59;
                }
                else
                {
                    nudSeconds.Value = 0;
                }
            }

            else if (newValue < prevValue)
            {
                if (newValue == 0 && nudMinutes.Value > 0)
                {
                    nudMinutes.Value -= 1;
                    nudSeconds.Value = 59;
                }
            }

            prevValue = nudSeconds.Value;
            isChanging = false;
        }
    }
}
