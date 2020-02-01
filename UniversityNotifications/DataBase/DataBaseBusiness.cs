using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using UniversityNotifications.Models;

namespace UniversityNotifications.DataBase
{
    public class DataBaseBusiness
    {
        ConnectToDB connection = new ConnectToDB();

        public void RegisterInNewsLetter(RegisterInNewsLetter model)
        {


            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand = connection.CreateCommand("[dbo].[RegisterInNewsLetter]", CommandType.StoredProcedure);
            sqlCommand.Parameters.AddWithValue("@UserName", model.UserName);
            sqlCommand.Parameters.AddWithValue("@Password", model.Password);
            sqlCommand.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
            sqlCommand.Parameters.AddWithValue("@Email", model.Email);
            sqlCommand.Parameters.AddWithValue("@UserType", model.UserType);
            sqlCommand.Parameters.AddWithValue("@Intrests", model.Intrests);
            sqlCommand.Parameters.AddWithValue("@NotificationType", model.NotificationType);
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose();


        }

        public ManagerLoginResponse ManagerLogin(ManagerLoginRequest model)
        {


            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand = connection.CreateCommand("[dbo].[ManagerLogin]", CommandType.StoredProcedure);
            sqlCommand.Parameters.AddWithValue("@UserName", model.UserName);
            sqlCommand.Parameters.AddWithValue("@Password", model.Password);


            SqlDataReader sqlDr = sqlCommand.ExecuteReader();

            var result = new ManagerLoginResponse();
            while (sqlDr.Read())
            {
                result.Id = (int)sqlDr["Id"];
                result.TypeId = (int)sqlDr["TypeId"];

            }

            sqlCommand.Dispose();
            return result;

        }

        public List<UniversityResponse> GetUniversity()
        {
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand = connection.CreateCommand("[dbo].[GetUniversitiesUnit]", CommandType.StoredProcedure);

            SqlDataReader sqlDr = sqlCommand.ExecuteReader();

            var resultList = new List<UniversityResponse>();
            while (sqlDr.Read())
            {
                var result = new UniversityResponse();

                result.Id = (int)sqlDr["Id"];
                result.Title = (string)sqlDr["Title"];
                resultList.Add(result);
            }
            sqlCommand.Dispose();
            return resultList;
        }

        public List<CollegeResponse> GetCollege(int id)
        {
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand = connection.CreateCommand("[dbo].[GetUniversityCollege]", CommandType.StoredProcedure);
            sqlCommand.Parameters.AddWithValue("@Id", id);

            SqlDataReader sqlDr = sqlCommand.ExecuteReader();

            var resultList = new List<CollegeResponse>();
            
            while (sqlDr.Read())
            {
                var result = new CollegeResponse();

                result.Id = (int)sqlDr["Id"];
                result.Title = (string)sqlDr["Title"];
                resultList.Add(result);
            }
            sqlCommand.Dispose();
            return resultList;
        }

        public List<LocationResponse> GetLocation(int id)
        {


            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand = connection.CreateCommand("[dbo].[GetLocation]", CommandType.StoredProcedure);
            sqlCommand.Parameters.AddWithValue("@Id", id);


            SqlDataReader sqlDr = sqlCommand.ExecuteReader();
            var resultList = new List<LocationResponse>();
            
            while (sqlDr.Read())
            {
                var result = new LocationResponse();

                result.Id = (int)sqlDr["Id"];
                result.Title = (string)sqlDr["Title"];
                resultList.Add(result);
            }

            sqlCommand.Dispose();
            return resultList;

        }

        public List<ScreenResponse> GetScreen()
        {


            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand = connection.CreateCommand("[dbo].[GetScreens]", CommandType.StoredProcedure);


            SqlDataReader sqlDr = sqlCommand.ExecuteReader();
            var resultList = new List<ScreenResponse>();
            
            while (sqlDr.Read())
            {
                var result = new ScreenResponse();

                result.Id = (int)sqlDr["Id"];
                result.Title = (string)sqlDr["Title"];
                resultList.Add(result);
            }

            sqlCommand.Dispose();
            return resultList;

        }

        public void InsertNotification(Notification model)
        {


            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand = connection.CreateCommand("[dbo].[InsertNewsManegment]", CommandType.StoredProcedure);
            sqlCommand.Parameters.AddWithValue("@TextShow", model.TextShow);
            sqlCommand.Parameters.AddWithValue("@UniversityScreenShow", model.UniversityScreenShow);
            sqlCommand.Parameters.AddWithValue("@CollegeScreenShow", model.CollegeScreenShow);
            sqlCommand.Parameters.AddWithValue("@LocationScreenShow", model.LocationScreenShow);
            sqlCommand.Parameters.AddWithValue("@FrequenceShow", model.FrequenceShow);
            sqlCommand.Parameters.AddWithValue("@ScheduleShow", model.ScheduleShow);
            sqlCommand.Parameters.AddWithValue("@UrgentShow", model.UrgentShow);
            sqlCommand.Parameters.AddWithValue("@typeId", model.TypeId);
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose();


        }
    }
}