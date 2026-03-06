using start.Models;
using PhoneNumbers;
using start.Services;

namespace start.Forms
{
    public partial class EditSportsmen : Form
    {
        private readonly int sportsmenId;
        private readonly string oldFullName;
        private readonly DateTime bdayOld;
        private readonly string parentPhoneOld;
        public EditSportsmen(int id, string fullName, DateTime bday, string parentPhone)
        {
            InitializeComponent();
            sportsmenId = id;
            oldFullName = fullName;
            bdayOld = bday;
            parentPhoneOld = parentPhone;
            AddInfo(fullName, bday, parentPhone);
        }

        private void AddInfo(string fullName, DateTime bday, string parentPhone)
        {
            textBox1.Text = fullName;
            dateTimePicker1.Value = bday;
            textBox4.Text = parentPhone;
        }
        private bool CheckTel(string telefon)
        {
            var phoneNumberUtil = PhoneNumberUtil.GetInstance();
            var phoneNumber = phoneNumberUtil.Parse(telefon, "RU");
            var isValid = phoneNumberUtil.IsValidNumber(phoneNumber);
            return isValid;
        }

        private bool CheckValue()
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Проверьте ФИО");
                return false;
            }
            else if (!CheckTel(textBox4.Text))
            {
                MessageBox.Show("Проверьте номер телефона");
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
                UpdateInDateBase.UpdateSportsmen(sportsmenId, textBox1.Text, bdayOld, textBox4.Text);
                this.Close();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
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
