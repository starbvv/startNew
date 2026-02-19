using start.Models;

namespace start.Services
{
    internal class DeleteInDateBase
    {
        public static void RemoveCoaches(int coachId)
        {
            try
            {
                using var db = new Connect();
                var coach = db.Coaches.Find(coachId);
                if(coach != null)
                {
                    db.Coaches.Remove(coach);
                    db.SaveChanges();
                }
            }
            catch (Exception e) 
            {
                MessageBox.Show("5");
            }
        }
        public static void RemoveSportsmen(int sportsmenId)
        {
            try
            {
                using var db = new Connect();
                var sportsmen = db.Sportsmens.Find(sportsmenId);
                if (sportsmen != null)
                {
                    db.Sportsmens.Remove(sportsmen);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("6");
            }
        }
    }
}
