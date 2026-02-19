using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

        //private void CreateBase()
        //{
        //    using var db = new connect();
        //    db.Database.EnsureCreated();
        //}

        private void GetData()
        {
            mainView.DataSource = StartDB.GetAttendances();

            sportsmensView.DataSource = StartDB.GetSportsmen();

            coachesView.DataSource = StartDB.GetCoaches();
        }

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
            mainView.DataSource = CheckTraining.CheckTr();
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
            mainView.DataSource = CheckTraining.CheckTrC();
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
            mainView.DataSource = CheckTraining.CheckPple();
            mainView.ReadOnly = true;
        }
        #endregion
        private void Table_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    RowDelete(sender as DataGridView);
                    break;
            }
        }

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
        }
    }
}
