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
            sportsmensOld = sportsmen;
            coachesOld = coaches;
            trainingDateOld = trainingDate;
            attendedOld = attended;

            comboBox1.Items.AddRange(StartDB.GetCoaches().ToArray());
            checkedListBox1.Items.AddRange(StartDB.GetSportsmen().ToArray());

            dateTimePicker1.Value = trainingDate;
        }

        private void button1_Click(object sender, EventArgs e)
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
