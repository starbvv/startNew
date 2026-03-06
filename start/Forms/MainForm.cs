using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using start.Forms;
using start.Models;
using start.Services;
namespace start
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //CreateBase();
            GetData();
        }

        #region хламник
        private void GetData()
        {
            mainView.DataSource = StartDB.GetAttendances();
            mainView.ReadOnly = true;

            sportsmensView.DataSource = StartDB.GetSportsmen();
            sportsmensView.ReadOnly = true;

            coachesView.DataSource = StartDB.GetCoaches();
            coachesView.ReadOnly = true;
        }  //<----- получение данных

        private void Table_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    RowDelete(sender as DataGridView);
                    break;
            }
        }//<----- обработка кнопок
        private void mainView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RowUpdate(sender as DataGridView);
        }//<----- обработка двойного клика

        private void RowDelete(DataGridView dataGrid)
        {
            int rowIndx = dataGrid.SelectedCells[0].RowIndex;
            var row = dataGrid.Rows[rowIndx];
            var data = row.DataBoundItem;

            if (data is Coaches coaches)
            {
                DeleteInDateBase.RemoveCoaches(coaches.Id);
                coachesView.DataSource = StartDB.GetCoaches();
            }
            else if (data is Sportsmen sportsmen)
            {
                DeleteInDateBase.RemoveSportsmen(sportsmen.Id);
                sportsmensView.DataSource = StartDB.GetSportsmen();
            }
        } //<----- получение строк для удаления

        private void RowUpdate(DataGridView dataGrid)
        {
            int rowIndx = dataGrid.SelectedCells[0].RowIndex;
            var row = dataGrid.Rows[rowIndx];
            var data = row.DataBoundItem;

            if (data is Coaches coaches)
            {
                EditCoaches editCoaches = new EditCoaches(coaches.Id, coaches.FullName, coaches.SportType);
                editCoaches.ShowDialog();
                coachesView.DataSource = StartDB.GetCoaches();
                coachesView.ReadOnly = true;

            }
            else if (data is Sportsmen sportsmen)
            {
                EditSportsmen editSportsmen = new EditSportsmen(sportsmen.Id, sportsmen.FullName, sportsmen.Bday, sportsmen.ParentPhone);
                editSportsmen.ShowDialog();
                sportsmensView.DataSource = StartDB.GetSportsmen();
                sportsmensView.ReadOnly = true;
            }
            else if (data is Attendances attendances)
            {
                string coachName = attendances.Coaches?.FullName ?? "";

                var editDateTraining = new EditDateTraining(
                    id: attendances.Id,
                    sportsmen: attendances.Sportsmen ?? new Sportsmen(),
                    coaches: coachName,
                    trainingDate: attendances.TrainingDate,
                    attended: attendances.Attended
                );

                if (editDateTraining.ShowDialog() == DialogResult.OK)
                {
                    mainView.DataSource = null;
                    mainView.DataSource = StartDB.GetAttendances();
                    mainView.ReadOnly = true;
                }
            }
        } //<----- получение строк для обновления

        //private void CreateBase() 
        //{
        //    using var db = new connect();
        //    db.Database.EnsureCreated();
        //} //<----- создание бз, если нету. хе х)
        #endregion

        #region добавление спортсмена
        private void AddSportsmen_Click(object sender, EventArgs e)
        {
            AddNewSportsmen Ans = new AddNewSportsmen();
            Ans.FormClosing += Ans_FormClosing;
            Ans.ShowDialog();
        }

        private void Ans_FormClosing(object? sender, FormClosingEventArgs e)
        {
            sportsmensView.DataSource = StartDB.GetSportsmen();
        }
        #endregion

        #region добавление тренера
        private void AddCouches_Click(object sender, EventArgs e)
        {
            AddNewCoaches Anc = new AddNewCoaches();
            Anc.FormClosing += Anc_FormClosing;
            Anc.ShowDialog();
        }

        private void Anc_FormClosing(object? sender, FormClosingEventArgs e)
        {
            coachesView.DataSource = StartDB.GetCoaches();
        }
        #endregion

        #region Фиксация даты тренировок
        private void AddTraining_Click(object sender, EventArgs e)
        {
            AddDateTraining Adt = new AddDateTraining();
            Adt.FormClosing += Adt_FormClosing;
            Adt.ShowDialog();
        }

        private void Adt_FormClosing(object? sender, FormClosingEventArgs e)
        {
            mainView.DataSource = StartDB.GetAttendances();
            if (mainView.Columns["DateTrainings"] != null)
            {
                mainView.Columns["DateTrainings"].DefaultCellStyle.Format = "dd.MM.yyyy";
            }
        }
        #endregion

        #region Прогульщики
        private void CheckTrainingPple_Click(object sender, EventArgs e)
        {
            CheckTrainingPple Ctp = new CheckTrainingPple();
            Ctp.FormClosing += Ctp_FormClosing;
            Ctp.ShowDialog();
        }

        private void Ctp_FormClosing(object? sender, FormClosingEventArgs e)
        {
            mainView.DataSource = CheckTraining.CheckTrainingPpleAddOut();
            mainView.ReadOnly = true;
        }
        #endregion

        #region Посещаемость тренера
        private void CheckTrainingCouches_Click(object sender, EventArgs e)
        {
            CheckTrainingCoaches Ctc = new CheckTrainingCoaches();

            Ctc.FormClosing += Ctc_FormClosing;
            Ctc.ShowDialog();
        }

        private void Ctc_FormClosing(object? sender, FormClosingEventArgs e)
        {
            mainView.DataSource = CheckTraining.CheckTrainingCoachesOut();
            mainView.ReadOnly = true;
        }
        #endregion

        #region Активность ребёнка
        private void CheckActiveChild_Click(object sender, EventArgs e)
        {
            CheckActiveChild Cac = new CheckActiveChild();

            Cac.FormClosing += Cac_FormClosing;
            Cac.ShowDialog();
        }

        private void Cac_FormClosing(object? sender, FormClosingEventArgs e)
        {
            CheckActiveChild Cac = new CheckActiveChild();


            mainView.DataSource = CheckTraining.CheckPpleOut();
            mainView.ReadOnly = true;

            mainView.Columns["AttendancePercentage"].DefaultCellStyle.Format = "0";
        }
        #endregion
    }
}
