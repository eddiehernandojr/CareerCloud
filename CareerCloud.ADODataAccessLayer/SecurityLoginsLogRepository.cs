using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public class SecurityLoginsLogRepository : BaseADORepository, IDataRepository<SecurityLoginsLogPoco>
    {
        public void Add(params SecurityLoginsLogPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                int rowsEffected = 0;

                foreach (SecurityLoginsLogPoco poco in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Security_Logins_Log]
                     ([Id],[Login],[Source_IP],[Logon_Date],[Is_Succesful])
                     Values
                     (@Id,@Login,@Source_IP,@Logon_Date,@Is_Succesful)";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Login", poco.Login);
                    cmd.Parameters.AddWithValue("@Source_IP", poco.SourceIP);
                    cmd.Parameters.AddWithValue("@Logon_Date", poco.LogonDate);
                    cmd.Parameters.AddWithValue("@Is_Succesful", poco.IsSuccesful);

                    conn.Open();
                    rowsEffected += cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<SecurityLoginsLogPoco> GetAll(params Expression<Func<SecurityLoginsLogPoco, object>>[] navigationProperties)
        {
            SecurityLoginsLogPoco[] pocos = new SecurityLoginsLogPoco[1000000];

            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM [dbo].[Security_Logins_Log]";

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int position = 0;

                while (reader.Read())
                {
                    SecurityLoginsLogPoco poco = new SecurityLoginsLogPoco();
                    poco.Id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0);
                    poco.Login = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1);
                    poco.SourceIP = reader.IsDBNull(2) ? null : reader.GetString(2);
                    poco.LogonDate = reader.IsDBNull(3) ? System.Data.SqlTypes.SqlDateTime.MinValue.Value : reader.GetDateTime(3); //database type is datetime
                    poco.IsSuccesful = reader.IsDBNull(4) ? default(bool) : reader.GetBoolean(4);

                    pocos[position] = poco;
                    position++;
                }

                conn.Close();
            }

            return pocos.Where(p => p != null).ToList();
        }

        public IList<SecurityLoginsLogPoco> GetList(Expression<Func<SecurityLoginsLogPoco, bool>> where, params Expression<Func<SecurityLoginsLogPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginsLogPoco GetSingle(Expression<Func<SecurityLoginsLogPoco, bool>> where, params Expression<Func<SecurityLoginsLogPoco, object>>[] navigationProperties)
        {
            IQueryable<SecurityLoginsLogPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params SecurityLoginsLogPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                foreach (SecurityLoginsLogPoco poco in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[Security_Logins_Log]
                        WHERE [Id] = @Id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Update(params SecurityLoginsLogPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                foreach (SecurityLoginsLogPoco poco in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Security_Logins_Log]
                            SET [Login] = @Login,
                            [Source_IP] = @Source_IP,
                            [Logon_Date] = @Logon_Date,
                            [Is_Succesful] = @Is_Succesful
                             WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Login", poco.Login);
                    cmd.Parameters.AddWithValue("@Source_IP", poco.SourceIP);
                    cmd.Parameters.AddWithValue("@Logon_Date", poco.LogonDate);
                    cmd.Parameters.AddWithValue("@Is_Succesful", poco.IsSuccesful);
                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}