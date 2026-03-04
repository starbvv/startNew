using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using start.Models;

namespace start.Services
{
    internal class UpdateInDateBase
    {
        public static void UpdateSportsmen(int id, string fullName, DateTime bday, string parentPhone)
        {
            try
            {
                using var db = new Connect();
                var newSportsmen = new Sportsmen
                {
                    Id = id,
                    FullName = fullName,
                    Bday = bday,
                    ParentPhone = parentPhone
                };
                db.Update(newSportsmen);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Не удалось обновить спортсмена");
            }
        }

        public static void UpdateCoaches(int id, string fullName, string sportType)
        {
            try
            {
                using var db = new Connect();
                var newCoaches = new Coaches
                {
                    Id = id,
                    FullName = fullName,
                    SportType = sportType
                };
                db.Update(newCoaches);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Не удалось обновить тренера");
            }
        }

        public static void UpdateAt(int id, int sportsmenId, int coachesId, DateTime trainingDate, bool attended)
        {
            try
            {
                using var db = new Connect();
                var attendance = db.Attendances
                    .Include(a => a.Sportsmen)
                    .Include(a => a.Coaches)
                    .FirstOrDefault(a => a.Id == id);

                attendance.TrainingDate = trainingDate.Date;
                attendance.Attended = attended;

                if (attendance.Sportsmen?.Id != sportsmenId)
                {
                    var newSportsman = db.Sportsmens.Find(sportsmenId);
                    attendance.Sportsmen = newSportsman;
                }

                if (attendance.Coaches?.Id != coachesId)
                {
                    var newCoach = db.Coaches.Find(coachesId);
                    attendance.Coaches = newCoach;
                }

                db.Update(attendance);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось обновить тренера");
            }
        }
    }
}
