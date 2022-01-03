using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing_System
{
    public partial class AddPrice : UserControl
    {
        public AddPrice()
        {
            InitializeComponent();
            string dat = Utility1.ReadFromFile();
            
            if (dat != null) { load_data(); }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (GroupCount.SelectedIndex == -1 && Duration.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Box", "Empty Selection Box",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (childWeek.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Child Weekdays Price",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (childWeekend.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Child Weekend Price",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Adultweek.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Adult Weekdays Price",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (AdultWeekend.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Adult Weekend Price",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Agedweek.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Aged Weekdays Price",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Agedweekend.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Aged Weekend Price",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int dur = int.Parse(Duration.SelectedItem.ToString());
                int group = int.Parse(GroupCount.SelectedItem.ToString());
                int childweek = int.Parse(childWeek.Text);
                int childweekend = int.Parse(childWeekend.Text);
                int adultweek = int.Parse(Adultweek.Text);
                int adultweekend = int.Parse(AdultWeekend.Text);
                int agedweek = int.Parse(Agedweek.Text);
                int agedweekend = int.Parse(Agedweekend.Text);
                string data = Utility1.ReadFromFile();
                List<PriceData> Lstdata = JsonConvert.DeserializeObject<List<PriceData>>(data);
                int index = Lstdata.FindIndex(x => x.GroupCount == group && x.Duration == dur);
                Lstdata[index].weekDaysChild = childweek;
                Lstdata[index].weekendChildPrice = childweekend;
                Lstdata[index].weekDaysAdult = adultweek;
                Lstdata[index].weekendAdultPrice = adultweekend;
                Lstdata[index].weekDaysAged = agedweek;
                Lstdata[index].weekendAgedPrice = agedweekend;
                string dt = JsonConvert.SerializeObject(Lstdata);
                Utility1.WriteToFile(dt);
                MessageBox.Show("Data Edit", "Price Edited",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
            }
        }

        private void btnPriceSave_Click(object sender, EventArgs e)
        {
            
            int dur = 0;
            if (GroupCount.SelectedIndex == -1 && Duration.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Box", "Empty Selection Box",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (childWeek.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Child Weekdays Price",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (childWeekend.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Child Weekend Price",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Adultweek.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Adult Weekdays Price",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (AdultWeekend.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Adult Weekend Price",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Agedweek.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Aged Weekdays Price",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Agedweekend.Text == "")
            {
                MessageBox.Show("Please fill the Box", "Empty Aged Weekend Price",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (Duration.SelectedItem.ToString() == "4>")
                {
                    dur = 5;
                }
                else
                {
                    dur = int.Parse(Duration.SelectedItem.ToString());
                }
                int group = int.Parse(GroupCount.SelectedItem.ToString());
                int childweek = int.Parse(childWeek.Text);
                int childweekend = int.Parse(childWeekend.Text);
                int adultweek = int.Parse(Adultweek.Text);
                int adultweekend = int.Parse(AdultWeekend.Text);
                int agedweek = int.Parse(Agedweek.Text);
                int agedweekend = int.Parse(Agedweekend.Text);
                PriceData prices = new PriceData();
                prices.GroupCount = group;
                prices.Duration = dur;
                prices.weekDaysChild = childweek;
                prices.weekendChildPrice = childweekend;
                prices.weekDaysAdult = adultweek;
                prices.weekendAdultPrice = adultweekend;
                prices.weekDaysAged = agedweek;
                prices.weekendAgedPrice = agedweekend;

                List<PriceData> pricedata = new List<PriceData>();

                string dat = Utility1.ReadFromFile();
                if (dat != null && dat != "")
                {
                    pricedata = JsonConvert.DeserializeObject<List<PriceData>>(dat);
                }
                pricedata.Add(prices);
                string priceData = JsonConvert.SerializeObject(pricedata);
                Utility1.WriteToFile(priceData);
                MessageBox.Show("Data Added", "New Visitor Added",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                load_data();

            }
        }
        private void load_data()
        {
            string dat = Utility1.ReadFromFile();
            List<PriceData> Lstdata = JsonConvert.DeserializeObject<List<PriceData>>(dat);
            if (Lstdata == null) { }
            var columns = from t in Lstdata
                          orderby t.GroupCount
                          select new
                          {

                              Group = t.GroupCount,
                              Duration = t.Duration,
                              ChildWeekPrice = t.weekDaysChild,
                              ChildWeekendPrice = t.weekendChildPrice,
                              AdultWeekPrice = t.weekDaysAdult,
                              AdultWeekendPrice = t.weekendAdultPrice,
                              AgedWeekPrice = t.weekDaysAged,
                              AgedWeekendPrice = t.weekendAgedPrice,

                          };
            pricedata.DataSource = columns.ToList();

        }
    }
}
