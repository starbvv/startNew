using System.Data;
using start.Models;
using start.Services;
using PhoneNumbers;

namespace start
{
    public partial class AddNewSportsmen : Form
    {
        public AddNewSportsmen()
        {
            InitializeComponent();
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
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Проверьте ФИО");
                return false;
            }
            else if (!CheckTel(textBox4.Text))
            {
                MessageBox.Show("Проверьте телефон");
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
                AddInDateBase.AddNewSportsmen(textBox1.Text, dateTimePicker1.Value.Date, textBox4.Text);
                this.Close();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != '(' && ch != ')' && ch != '+')
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
