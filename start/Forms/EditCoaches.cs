using start.Services;

namespace start.Forms
{
    public partial class EditCoaches : Form
    {
        private readonly int CoachesId;
        private readonly string FullNameOld;
        public EditCoaches(int id, string fullName, string sportType)
        {
            InitializeComponent();
            CoachesId = id;
            FullNameOld = fullName;
            AddInfo(fullName, sportType);
        }

        private void AddInfo(string fullName, string sportType)
        {
            textBox1.Text = fullName;
            comboBox1.Text = sportType;
        }

        private bool CheckValue()
        {
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Проверьте вид спорта");
                return false;
            }
            else if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Проверьте ФИО");
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
                UpdateInDateBase.UpdateCoaches(CoachesId, textBox1.Text, comboBox1.Text);
                this.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
