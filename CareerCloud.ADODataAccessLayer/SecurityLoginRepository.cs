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
    public class SecurityLoginRepository : BaseADORepository, IDataRepository<SecurityLoginPoco>
    {
        public void Add(params SecurityLoginPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                int rowsEffected = 0;

                foreach (SecurityLoginPoco poco in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Security_Logins]
                     ([Id],[Login],[Password],[Created_Date],[Password_Update_Date],[Agreement_Accepted_Date],[Is_Locked],
                     [Is_Inactive],[Email_Address],[Phone_Number],[Full_Name],[Force_Change_Password],[Prefferred_Language])
                     Values
                     (@Id,@Login,@Password,@Created_Date,@Password_Update_Date,@Agreement_Accepted_Date, @Is_Locked,
                     @Is_Inactive,@Email_Address,@Phone_Number,@Full_Name,@Force_Change_Password,@Prefferred_Language)";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Login", poco.Login);
                    cmd.Parameters.AddWithValue("@Password", poco.Password);
                    cmd.Parameters.AddWithValue("@Created_Date", poco.Created);
                    cmd.Parameters.AddWithValue("@Password_Update_Date", poco.PasswordUpdate);
                    cmd.Parameters.AddWithValue("@Agreement_Accepted_Date", poco.AgreementAccepted);
                    cmd.Parameters.AddWithValue("@Is_Locked", poco.IsLocked);
                    cmd.Parameters.AddWithValue("@Is_Inactive", poco.IsInactive);
                    cmd.Parameters.AddWithValue("@Email_Address", poco.EmailAddress);
                    cmd.Parameters.AddWithValue("@Phone_Number", poco.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Full_Name", poco.FullName);
                    cmd.Parameters.AddWithValue("@Force_Change_Password", poco.ForceChangePassword);
                    cmd.Parameters.AddWithValue("@Prefferred_Language", poco.PrefferredLanguage);

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

        public IList<SecurityLoginPoco> GetAll(params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            SecurityLoginPoco[] pocos = new SecurityLoginPoco[1000000];

            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM [dbo].[Security_Logins]";

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int position = 0;

                while (reader.Read())
                {
                    SecurityLoginPoco poco = new SecurityLoginPoco();
                    poco.Id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0);
                    poco.Login = reader.IsDBNull(1) ? null : reader.GetString(1);
                    poco.Password = reader.IsDBNull(2) ? null : reader.GetString(2);
                    poco.Created = reader.IsDBNull(3) ? default(DateTime) : reader.GetDateTime(3); //database type is datetime2
                    poco.PasswordUpdate = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    poco.AgreementAccepted = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    poco.IsLocked = reader.IsDBNull(6) ? default(bool) : reader.GetBoolean(6);
                    poco.IsInactive = reader.IsDBNull(7) ? default(bool) : reader.GetBoolean(7);
                    poco.EmailAddress = reader.IsDBNull(8) ? null : reader.GetString(8);
                    poco.PhoneNumber = reader.IsDBNull(9) ? null : reader.GetString(9);
                    poco.FullName = reader.IsDBNull(10) ? null : reader.GetString(10);
                    poco.ForceChangePassword = reader.IsDBNull(11) ? default(bool) : reader.GetBoolean(11);
                    poco.PrefferredLanguage = reader.IsDBNull(12) ? null : reader.GetString(12);
                    poco.TimeStamp = (byte[])reader[13];

                    pocos[position] = poco;
                    position++;
                }

                conn.Close();
            }

            return pocos.Where(p => p != null).ToList();
        }

        public IList<SecurityLoginPoco> GetList(Expression<Func<SecurityLoginPoco, bool>> where, params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginPoco GetSingle(Expression<Func<SecurityLoginPoco, bool>> where, params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            IQueryable<SecurityLoginPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params SecurityLoginPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                foreach (SecurityLoginPoco poco in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[Security_Logins]
                        WHERE [Id] = @Id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Update(params SecurityLoginPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                foreach (SecurityLoginPoco poco in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Security_Logins]
                            SET [Login] = @Login,
                            [Password] = @Password,
                            [Created_Date] = @Created_Date,
                            [Password_Update_Date] = @Password_Update_Date,
                            [Agreement_Accepted_Date] = @Agreement_Accepted_Date,
                            [Is_Locked] = @Is_Locked,
                            [Is_Inactive] = @Is_Inactive,
                            [Email_Address] = @Email_Address,
                            [Phone_Number] = @Phone_Number,
                            [Full_Name] = @Full_Name,
                            [Force_Change_Password] = @Force_Change_Password,
                            [Prefferred_Language] = @Prefferred_Language
                             WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Login", poco.Login);
                    cmd.Parameters.AddWithValue("@Password", poco.Password);
                    cmd.Parameters.AddWithValue("@Created_Date", poco.Created);
                    cmd.Parameters.AddWithValue("@Password_Update_Date", poco.PasswordUpdate);
                    cmd.Parameters.AddWithValue("@Agreement_Accepted_Date", poco.AgreementAccepted);
                    cmd.Parameters.AddWithValue("@Is_Locked", poco.IsLocked);
                    cmd.Parameters.AddWithValue("@Is_Inactive", poco.IsInactive);
                    cmd.Parameters.AddWithValue("@Email_Address", poco.EmailAddress);
                    cmd.Parameters.AddWithValue("@Phone_Number", poco.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Full_Name", poco.FullName);
                    cmd.Parameters.AddWithValue("@Force_Change_Password", poco.ForceChangePassword);
                    cmd.Parameters.AddWithValue("@Prefferred_Language", poco.PrefferredLanguage);
                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
