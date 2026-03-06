using Microsoft.EntityFrameworkCore;
using start.Models;

namespace start.Services
{
    internal class AddInDateBase
    {
        public static void AddNewSportsmen
            (
            string FullName,
            DateTime Bday,
            string ParentPhone
            )
        {
            try
            {
                using var db = new Connect();
                var newSportsmen = new Sportsmen
                {
                    FullName = FullName,
                    Bday = Bday,
                    ParentPhone = ParentPhone
                };

                db.Sportsmens.Add(newSportsmen);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Не удалось добавить спортсмена.");
            }
        }

        public static void AddNewCouches
            (
            string FullName,
            string SportType
            )
        {
            try
            {
                using var db = new Connect();
                var newCouches = new Coaches
                {
                    FullName = FullName,
                    SportType = SportType
                };

                db.Coaches.Add(newCouches);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Не удалось добавить тренера.");
            }
        }

        public static void AddNewAttendances
            (
            Coaches idCoaches,
            List<Sportsmen> idSportsmen,
            List<Sportsmen> allSportsmen,
            DateTime TrainingDate
            )
        {
            try
            {
                using var db = new Connect();

                db.Coaches.Attach(idCoaches);
                db.Entry(idCoaches).State = EntityState.Unchanged;

                var trainingDateOnly = TrainingDate.Date;

                var presentIds = idSportsmen.Select(s => s.Id).ToHashSet();

                foreach (var sportsman in allSportsmen)
                {
                    db.Sportsmens.Attach(sportsman);
                    db.Entry(sportsman).State = EntityState.Unchanged;

                    bool attended = presentIds.Contains(sportsman.Id);

                    var attendance = new Attendances
                    {
                        Sportsmen = sportsman,
                        Coaches = idCoaches,
                        TrainingDate = trainingDateOnly,
                        Attended = attended
                    };

                    db.Attendances.Add(attendance);
                }

                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Не удалось добавить посещение.");
            }
        }
    }
}
