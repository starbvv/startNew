using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using start.Models;
using start.Services;

namespace start
{
    public partial class CheckTrainingPple : Form
    {
        private CheckTraining a = new CheckTraining();
        public CheckTrainingPple()
        {
            InitializeComponent();
            checkedListBox1.Items.AddRange(StartDB.GetSportsmen().ToArray());
        }

        private bool CheckValue()
        {
            if (checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("Проверьте спортсменов");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckValue())
            {
                var sId = checkedListBox1.CheckedItems.Cast<Sportsmen>().ToList();
                var data = dateTimePicker1.Value.Date;
                var data2 = dateTimePicker2.Value.Date;

                a.AddInfoThree(sId);
                a.dataAddOneS(data);
                a.dataAddTwoS(data2);

                this.Close();
            }
        }
    }
}
