using start.Models;
using start.Services;

namespace start
{
    public partial class AddDateTraining : Form
    {
        public AddDateTraining()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(StartDB.GetCoaches().ToArray());
            checkedListBox1.Items.AddRange(StartDB.GetSportsmen().ToArray());
        }

        private bool CheckValue()
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("Проверьте тренера");
                return false;
            }
            else if (checkedListBox1.Items.Count == 0)
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
            var cId = comboBox1.SelectedItem as Coaches;

            var sId = checkedListBox1.CheckedItems.Cast<Sportsmen>().ToList();

            var all = checkedListBox1.Items.Cast<Sportsmen>().ToList();

            if (CheckValue())
            {
                AddInDateBase.AddNewAttendances(cId, sId, all, dateTimePicker1.Value);
                this.Close();
            }
        }
    }
}
