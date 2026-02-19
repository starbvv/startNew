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
            catch ( Exception ex )
            {
                MessageBox.Show("1");
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
            catch ( Exception ex )
            {
                MessageBox.Show("2");
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

                db.Coaches.Attach( idCoaches );
                db.Entry( idCoaches ).State = EntityState.Unchanged;

                foreach (var smen in idSportsmen) //true
                {
                    db.Sportsmens.Attach( smen );
                    db.Entry( smen ).State = EntityState.Unchanged;

                    var attendances = new Attendances
                    {
                        Sportsmen = smen,
                        Coaches = idCoaches,
                        TrainingDate = TrainingDate,
                        Attended = true
                    };
                    db.Attendances.Add(attendances);
                }

                foreach (var allSmen in allSportsmen) //false
                {
                    db.Sportsmens.Attach(allSmen);
                    db.Entry(allSmen).State = EntityState.Unchanged;

                    var attendances = new Attendances
                    {
                        Sportsmen = allSmen,
                        Coaches = idCoaches,
                        TrainingDate = TrainingDate
                    };
                    db.Attendances.Add(attendances);
                }

                db.SaveChanges();
            }
            catch ( Exception ex )
            {
                MessageBox.Show($"{ex}"); 
            }
        }
    }
}
