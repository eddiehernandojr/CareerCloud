﻿using CareerCloud.DataAccessLayer;
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
    public class SecurityRoleRepository : BaseADO, IDataRepository<SecurityRolePoco>
    {
        public void Add(params SecurityRolePoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                int rowsEffected = 0;

                foreach (SecurityRolePoco poco in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Security_Roles]
                     ([Id],[Role],[Is_Inactive])
                     Values
                     (@Id,@Role,@Is_Inactive)";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Role", poco.Role);
                    cmd.Parameters.AddWithValue("@Is_Inactive", poco.IsInactive);

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

        public IList<SecurityRolePoco> GetAll(params Expression<Func<SecurityRolePoco, object>>[] navigationProperties)
        {
            SecurityRolePoco[] pocos = new SecurityRolePoco[1000];

            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM [dbo].[Security_Roles]";

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int position = 0;

                while (reader.Read())
                {
                    SecurityRolePoco poco = new SecurityRolePoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Role = reader.GetString(1);
                    poco.IsInactive = reader.GetBoolean(2);

                    pocos[position] = poco;
                    position++;
                }

                conn.Close();
            }

            return pocos;
        }

        public IList<SecurityRolePoco> GetList(Expression<Func<SecurityRolePoco, bool>> where, params Expression<Func<SecurityRolePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SecurityRolePoco GetSingle(Expression<Func<SecurityRolePoco, bool>> where, params Expression<Func<SecurityRolePoco, object>>[] navigationProperties)
        {
            IQueryable<SecurityRolePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params SecurityRolePoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                foreach (SecurityRolePoco poco in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[Security_Roles]
                        WHERE [Id] = @Id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Update(params SecurityRolePoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                foreach (SecurityRolePoco poco in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Security_Roles]
                            SET [Role] = @Role,
                            [Is_Inactive] = @Is_Inactive
                             WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Role", poco.Role);
                    cmd.Parameters.AddWithValue("@Is_Inactive", poco.IsInactive);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
