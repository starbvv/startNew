using System.Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using start.Models;

namespace start.Services
{
    internal class CheckTraining()
    {
        #region ставим на счетчик
        public static string info;

        public static List<Coaches> info2;
        public static DateTime dataOneC;
        public static DateTime dataTwoC;

        public static List<Sportsmen> info3;
        public static DateTime dataOneS;
        public static DateTime dataTwoS;
        #endregion

        public static readonly string ConnectionString = Path.Combine(AppContext.BaseDirectory, @"..\..\..\dabe.db");

        public string AddInfo(string add)
        {
            return info = add;
        }

        public List<Coaches> AddInfoTwo(List<Coaches> addInfo, DateTime dataOne, DateTime dataTwo)
        {
            return info2 = addInfo; dataOneC = dataOne; dataTwoC = dataTwo;
        }

        public List<Sportsmen> AddInfoThree(List<Sportsmen> addInfo, DateTime dataOne, DateTime dataTwo)
        {
            return info3 = addInfo; dataOneS = dataOne; dataTwoS = dataTwo; 
        }

        #region представление всех данных
        public static List<CheckTrainingPpleKEK> CheckTr
            (

            )
        {
            using var con = new SqliteConnection($"Data Source = { ConnectionString }");
            con.Open();

            List<CheckTrainingPpleKEK> infoz = new();
            using var cmd = new SqliteCommand("SELECT * FROM CheckTrainingPple", con);

            using var reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                infoz.Add(new CheckTrainingPpleKEK
                {
                    ChildName = reader.GetString(0),
                    BrirthDay = reader.GetString(1),
                    MissedDate = reader.GetDateTime(2),
                    ChildPhone = reader.GetString(3)
                });
            }

            return infoz;
        }

        public static List<CheckTrainingCoachesKEK> CheckTrC
            (

            )
        {
            using var con = new SqliteConnection($"Data Source = {ConnectionString}");
            con.Open();

            List<CheckTrainingCoachesKEK> infoz = new();
            using var cmd = new SqliteCommand("SELECT * FROM CheckTrainingCoaches", con);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                infoz.Add(new CheckTrainingCoachesKEK
                {
                    CoachesName = reader.GetString(0),
                    Sport = reader.GetString(1),
                    TotalTrainings = reader.GetInt32(2),
                    DateTrainings = reader.GetDateTime(3),
                    AttendedVisits = reader.GetInt32(4),
                    AttendancePercentage = reader.GetDouble(5)
                });
            }

            return infoz;
        }

        public static List<CheckActiveChildKEK> CheckPple
            (

            )
        {
            using var con = new SqliteConnection($"Data Source = {ConnectionString}");
            con.Open();

            List<CheckActiveChildKEK> infoz = new();
            using var cmd = new SqliteCommand("SELECT * FROM CheckActiveChild", con);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                infoz.Add(new CheckActiveChildKEK
                {
                    ChildName = reader.GetString(0),
                    Age = reader.GetInt32(1),
                    TotalTrainings = reader.GetInt32(2),
                    Misses = reader.GetInt32(3),
                    AttendancePercentage= reader.GetDouble(4)
                });
            }

            return infoz;
        }
        #endregion

        #region фильтры

        public static List<CheckActiveChildKEK> CheckPpleOut()
        {
            var all = CheckPple();

            var filtered = all.Where(a => string.Equals(a.ChildName, info)).ToList();

            return filtered;
        }

        public static List<CheckTrainingCoachesKEK> CheckTrainingCoachesOut()
        {
            var all = CheckTrC();

            DateTime from = dataOneC;
            DateTime to = dataTwoC; 

            var name = info2.Select(a => a.FullName?.Trim() ?? "");

            var filtered = all.Where(a => name.Contains(a.CoachesName.Trim()) && a.DateTrainings >= from.Date && a.DateTrainings <= to.Date).ToList();

            return filtered;
        }

        public static List<CheckTrainingPpleKEK> CheckTrainingPpleAddOut()
        {
            var all = CheckTr();

            DateTime from = dataOneS;
            DateTime to = dataTwoS;

            var name = info3.Select(a => a.FullName?.Trim() ?? "");

            var filtered = all.Where(a => name.Contains(a.ChildName.Trim()) && a.MissedDate >= from.Date && a.MissedDate <= to.Date).ToList();

            return filtered;
        }
        #endregion
    }
}
