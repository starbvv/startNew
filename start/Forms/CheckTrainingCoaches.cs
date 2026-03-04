using start.Models;
using start.Services;

namespace start
{
    public partial class CheckTrainingCoaches : Form
    {
        private CheckTraining a = new CheckTraining();
        public CheckTrainingCoaches()
        {
            InitializeComponent();
            checkedListBox1.Items.AddRange(StartDB.GetCoaches().ToArray());
        }

        private bool CheckValue()
        {
            if (checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("Проверьте тренеров");
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
                var cId = checkedListBox1.CheckedItems.Cast<Coaches>().ToList();
                var date = dateTimePicker1.Value.Date;
                var date2 = dateTimePicker2.Value.Date;

                a.AddInfoTwo(cId, date, date2);

                this.Close();
            }
        }
    }
}
