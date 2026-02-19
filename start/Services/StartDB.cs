using Microsoft.EntityFrameworkCore;
using start.Models;

namespace start.Services
{
    public class StartDB
    {
        public static List<Sportsmen> GetSportsmen()
        {
            using var db = new Connect();
            var sportsmens = db.Sportsmens.ToList();

            return sportsmens;
        }

        public static List<Coaches> GetCoaches()
        {
            using var db = new Connect();
            var coaches = db.Coaches.ToList();

            return coaches;
        }

        public static List<Attendances> GetAttendances()
        {
            using var db = new Connect();

            return db.Attendances.Include(a => a.Sportsmen)
                                 .Include(a => a.Coaches)
                                 .ToList();
        }
    }
}
