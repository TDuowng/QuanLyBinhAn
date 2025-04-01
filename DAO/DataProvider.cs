using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set => instance = value;
        }

        private DataProvider() { }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(con);
        }

        private string con = @"Data Source=LAPTOP-J2TR54TC;Initial Catalog=Quan_Ly_Binh_An;Integrated Security=True"; // chuỗi kết nối 

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection); //câu truy vấn thực thi

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);//trung gian thực hiện câu truy vấn lấy dữ liệu
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection); //câu truy vấn thực thi

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.Add(new SqlParameter(item, parameter[i] ?? DBNull.Value));
                            //cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection); //câu truy vấn thực thi

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteScalar();
                connection.Close();
            }
            return data;


        }

        public int ExecuteStoredProcedure(string spName, SqlParameter[] parameters)
        {
            int result = 0;

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(spName, connection);
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                result = command.ExecuteNonQuery();

                connection.Close();
            }

            return result;
        }

        public DataTable ExecuteStoredProcedureWithReturn(string spName, SqlParameter[] parameters)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(spName, connection);
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }
    }
}
