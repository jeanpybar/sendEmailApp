using angularapp.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace angularapp.Repositories
    {
    public class EmailRepository
        {
        public List<Email> GetEmails(DateTime? startDate, DateTime? endDate, string subject, string toEmail)
            {

            SqlConnection connection = new SqlConnection(Properties.Resources.ResourceManager.GetString("ConnectionString"));
            string sql = "GetEmailData";
            connection.Open();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@DateStart",startDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parameters.Add("@DateEnd", endDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parameters.Add("@subject",subject, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@ToEmail",toEmail, dbType: DbType.String, direction: ParameterDirection.Input);

            var emailList = connection.Query<Email>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
            connection.Close();
            return emailList;
            }


        public int SaveEmail(Email email)
            {

            SqlConnection connection = new SqlConnection(Properties.Resources.ResourceManager.GetString("ConnectionString"));
            string sql = "InsertEmail";
            connection.Open();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@toEmail",email.ToEmail,dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@status", email.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@subject", email.Subject, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@message", email.Message, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@identifier", email.Identifier, dbType: DbType.String, direction: ParameterDirection.Input);

            var affectedRows = connection.Execute(sql, parameters, commandType: CommandType.StoredProcedure);
            connection.Close();
            return affectedRows;
            }

        public int ChangeEmailStatus(string status, string identifier)
            {

            SqlConnection connection = new SqlConnection(Properties.Resources.ResourceManager.GetString("ConnectionString"));
            string sql = "UpdateEmailStatus";
            connection.Open();
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@status", status , dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@identfier", identifier, dbType: DbType.String, direction: ParameterDirection.Input);

            var affectedRows = connection.Execute(sql, parameters, commandType: CommandType.StoredProcedure);
            connection.Close();
            return affectedRows;
            }
        }
    }
