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
            if(comboBox1.Text == string.Empty)
            {
                return false;
            }
            else if(textBox1.Text == FullNameOld)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateInDateBase.UpdateCoaches(CoachesId, textBox1.Text, comboBox1.Text);
            this.Close();
        }
    }
}
