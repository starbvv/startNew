using start.Services;

namespace start
{
    public partial class AddNewCoaches : Form
    {
        public AddNewCoaches()
        {
            InitializeComponent();
        }

        private bool CheckValue()
        {
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Проверьте ФИО");
                return false;
            }
            else if(comboBox1.Items.Count == 0)
            {
                MessageBox.Show("Проверьте тип спорта");
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
                AddInDateBase.AddNewCouches(textBox1.Text, comboBox1.Text);
                this.Close();
            }
        }
    }
}
