using start.Models;
using start.Services;

namespace start.Forms
{
    public partial class EditDateTraining : Form
    {
        private readonly int dateId;
        private readonly Sportsmen sportsmensOld;
        private readonly string coachesOld;
        private readonly DateTime trainingDateOld;
        private readonly bool attendedOld;
        public EditDateTraining(int id, Sportsmen sportsmen, string coaches, DateTime trainingDate, bool attended)
        {
            InitializeComponent();

            dateId = id;
            sportsmensOld = sportsmen ?? new Sportsmen();
            coachesOld = coaches ?? "";
            trainingDateOld = trainingDate;
            attendedOld = attended;

            var allCoaches = StartDB.GetCoaches();
            var allSportsmen = StartDB.GetSportsmen();

            comboBox1.Items.AddRange(allCoaches.ToArray());
            checkedListBox1.Items.AddRange(allSportsmen.ToArray());

            dateTimePicker1.Value = trainingDate.Date;

            if (!string.IsNullOrEmpty(coaches))
            {
                var currentCoach = allCoaches.FirstOrDefault(c => c.FullName == coaches);
                if (currentCoach != null)
                {
                    comboBox1.SelectedItem = currentCoach;
                }
            }

            if (sportsmensOld?.Id > 0)
            {
                int targetId = sportsmensOld.Id;

                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    var item = checkedListBox1.Items[i] as Sportsmen;
                    if (item != null && item.Id == targetId)
                    {
                        checkedListBox1.SetItemChecked(i, true);
                        break;
                    }
                }
            }
        }

        private bool CheckValue()
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Проверьте тренера");
                return false;
            }
            else if (checkedListBox1.CheckedItems.Count < 0)
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
            if(CheckValue())
            {
                var selectedCoach = (Coaches)comboBox1.SelectedItem;

                var selectedSportsman = (Sportsmen)checkedListBox1.CheckedItems[0];

                UpdateInDateBase.UpdateAt(
                    id: dateId,
                    sportsmenId: selectedSportsman.Id,
                    coachesId: selectedCoach.Id,
                    trainingDate: dateTimePicker1.Value.Date,
                    attended: true
                );

                this.Close();
            }
        }
    }
}
