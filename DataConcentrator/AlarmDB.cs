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
        }

        public void AddAlarm(AlarmDto alarmDto)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                
                string id = alarmDto.Id;
                string tagId = alarmDto.TagId;
                string message = alarmDto.Message;
                string time = alarmDto.Time.ToString();
                SqlCommand command = new SqlCommand(string.Format("INSERT INTO Alarm VALUES({0}, {1}, {2}, {3})",
                    id, tagId, message, time), connection);
                //int n = command.ExecuteNonQuery();

                SqlCommand prikaz = new SqlCommand("INSERT INTO Alarm values(@id,@tagId,@message,@time)", connection);

                prikaz.Parameters.AddWithValue("@id", id);
                prikaz.Parameters.AddWithValue("@tagId", tagId);
                prikaz.Parameters.AddWithValue("@message", message);
                prikaz.Parameters.AddWithValue("@time", time);
                connection.Open();
                prikaz.ExecuteNonQuery();

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
                return  new AlarmDto(id, tagId, message, time);
            }
        }
    }
}
