using start.Models;
using start.Services;

namespace start.Forms
{
    public partial class EditDateTraining : Form
    {
        private readonly int dateId;
        private readonly List<Sportsmen> sportsmensOld;
        private readonly string coachesOld;
        private readonly DateTime trainingDateOld;
        private readonly bool attendedOld;
        public EditDateTraining(int id, List<Sportsmen> sportsmen, string coaches, DateTime trainingDate, bool attended)
        {
            InitializeComponent();

            dateId = id;
            sportsmensOld = sportsmen;
            coachesOld = coaches;
            trainingDateOld = trainingDate;
            attendedOld = attended;
            Add(sportsmen, coaches, trainingDate, attended);

            comboBox1.Items.AddRange(StartDB.GetCoaches().ToArray());
            checkedListBox1.Items.AddRange(StartDB.GetSportsmen().ToArray());
        }

        private void Add(List<Sportsmen> sportsmens, string coaches, DateTime trainingDate, bool attended)
        {
            comboBox1.SelectedIndex = comboBox1.FindStringExact
                (
                StartDB.GetCoaches().ToString()
                );


        }

        private bool CheckValue()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
