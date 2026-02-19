using start.Models;
using start.Services;

namespace start
{
    public partial class CheckTrainingCoaches : Form
    {
        public CheckTrainingCoaches()
        {
            InitializeComponent();
            checkedListBox1.Items.AddRange(StartDB.GetCoaches().ToArray());
        }

        private bool CheckValue()
        {
            if (checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("Проверьте данные");
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

                this.Close();
            }
        }
    }
}
