using start.Services;

namespace start
{
    public partial class CheckActiveChild : Form
    {
        private MainForm a = new();
        public CheckActiveChild()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(StartDB.GetSportsmen().ToArray());
        }

        private bool CheckValue()
        {
            if (comboBox1.Items.Count == 0)
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
                this.Close();
            }
        }
    }
}
