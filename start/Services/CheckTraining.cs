using System.Data;
using Microsoft.Data.Sqlite;
using start.Models;

namespace start.Services
{
    internal class CheckTraining
    {
        public static readonly string ConnectionString = Path.Combine(AppContext.BaseDirectory, @"dabe.db");
        public static List<CheckTrainingPpleKEK> CheckTr
            (
            string name
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
                    MissedDate = reader.GetString(2),
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
                    AttendedVisits = reader.GetInt32(3),
                    AttendancePercentage = reader.GetDouble(4)
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
    }
}
