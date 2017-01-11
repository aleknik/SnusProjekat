using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataConcentrator
{
    class AlarmDB
    {
        private string connString;

        public AlarmDB()
        {
            connString =
               "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\alepH\\Desktop\\Projekat P2\\Projekat\\DataConcentrator\\AlarmDatabase.mdf\";Integrated Security = True";
           // connString = 
           //     "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\dev\\Projekat P2\\Projekat P2\\Projekat\\DataConcentrator\\AlarmDatabase.mdf\";Integrated Security=True";
        }

        public void AddAlarm(AlarmDto alarmDto)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                string id = alarmDto.Id;
                string tagId = alarmDto.TagId;
                string message = alarmDto.Message;
                string time = alarmDto.Time.ToString();
                SqlCommand command = new SqlCommand("INSERT INTO Alarm values(@id,@tagId,@message,@time)", connection);

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@tagId", tagId);
                command.Parameters.AddWithValue("@message", message);
                command.Parameters.AddWithValue("@time", time);
                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public AlarmDto GetAlarm(string alarmId)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM Alarm WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@id", alarmId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string id = reader.GetString(0).Trim();
                string tagId = reader.GetString(1).Trim();
                string message = reader.GetString(2).Trim();
                DateTime time = reader.GetDateTime(3);
                return new AlarmDto(id, tagId, message, time);
            }
        }
    }
}