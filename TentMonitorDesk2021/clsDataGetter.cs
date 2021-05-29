using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TentMonitorDesk2021
{
    public class clsDataGetter : IDisposable
    {
        public SqlConnection conn;
        string cnStr;

        public clsDataGetter(string connStr = "")
        {
            conn = new System.Data.SqlClient.SqlConnection(connStr);
            cnStr = connStr;
        }

        public System.Data.SqlClient.SqlDataReader GetDataReader(string sql, SqlConnection newConn = null, bool isStoredProc = false)
        {
            System.Data.SqlClient.SqlDataReader dr = null;
            if (newConn == null)
            {
                newConn = conn;
            }

            if (newConn.State != ConnectionState.Open && newConn.State != ConnectionState.Connecting)
            {
                newConn.Open();
            }

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, newConn);
            if (isStoredProc)
                cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 3600;
            try
            {
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                newConn.Close();
            }
            return dr;
        }

        public System.Data.SqlClient.SqlDataReader GetDataReaderSP(string sql, List<SqlParameter> parameters, SqlConnection newConn = null)
        {
            System.Data.SqlClient.SqlDataReader dr = null;
            if (newConn == null)
            {
                newConn = conn;
            }

            if (newConn.State != ConnectionState.Open && newConn.State != ConnectionState.Connecting)
            {
                newConn.Open();
            }

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, newConn);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (var parm in parameters)
            {
                cmd.Parameters.Add(parm);
            }
            cmd.CommandTimeout = 3600;
            try
            {
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                newConn.Close();
            }
            return dr;
        }



        public void KillReader(SqlDataReader dr)
        {
            if (dr != null)
            {
                dr.Close();
                dr.Dispose();
            }
        }
        public DataSet GetDataSet(string sql)
        {
            System.Data.SqlClient.SqlConnection conn3 = new System.Data.SqlClient.SqlConnection(cnStr);
            System.Data.SqlClient.SqlDataAdapter adapt = new System.Data.SqlClient.SqlDataAdapter(sql, conn3);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            conn3.Close();
            conn3.Dispose();
            conn3 = null;
            return ds;
        }

        public int GetDateDiff(DateTime start, DateTime end, string type = "day")
        {
            string sql;
            sql = "SELECT DATEDIFF(" + type + ",'" + start.ToShortDateString() + "','" + end.ToShortDateString() + "')";
            return GetScalarInteger(sql);
        }


        public int GetScalarInteger(string sql)
        {
            int x = -1;
            System.Data.SqlClient.SqlConnection conn3 = new System.Data.SqlClient.SqlConnection(cnStr);
            conn3.Open();
            SqlCommand cmd = new SqlCommand(sql, conn3);
            try
            {
                x = (int)cmd.ExecuteScalar();
            }
            catch
            {
                x = -1;
            }
            conn3.Close();
            conn3.Dispose();
            conn3 = null;
            return x;
        }

        public bool GetScalarBoolean(string sql)
        {
            bool x;
            System.Data.SqlClient.SqlConnection conn3 = new System.Data.SqlClient.SqlConnection(cnStr);
            conn3.Open();
            SqlCommand cmd = new SqlCommand(sql, conn3);
            x = (bool)cmd.ExecuteScalar();
            conn3.Close();
            conn3.Dispose();
            conn3 = null;
            return x;
        }
        public decimal GetScalarDecimal(string sql)
        {
            decimal x = 0.0M;
            System.Data.SqlClient.SqlConnection conn3 = new System.Data.SqlClient.SqlConnection(cnStr);
            conn3.Open();
            SqlCommand cmd = new SqlCommand(sql, conn3);
            object result = cmd.ExecuteScalar();
            if (result == null)
            {
                return -1.0M;
            }
            try
            {
                x = (decimal)result;
            }
            catch
            {
                x = -1.0M;
            }
            conn3.Close();
            conn3.Dispose();
            conn3 = null;
            return x;
        }

        public DateTime GetScalarDate(string sql)
        {
            DateTime x;
            System.Data.SqlClient.SqlConnection conn3 = new System.Data.SqlClient.SqlConnection(cnStr);
            conn3.Open();
            SqlCommand cmd = new SqlCommand(sql, conn3);
            object result = cmd.ExecuteScalar();
            if (result == DBNull.Value)
            {
                return DateTime.Parse("1/1/1900");
            }
            else
            {
                x = (DateTime)result;
            }
            conn3.Close();
            conn3.Dispose();
            conn3 = null;
            return x;
        }

        public string GetScalarJson(int productID)
        {
            string json = "";
            string cmdName = "sp_GetRates";
            System.Data.SqlClient.SqlConnection conn3 = new System.Data.SqlClient.SqlConnection(cnStr);
            conn3.Open();
            SqlCommand cmd = new SqlCommand(cmdName, conn3);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@prodID", productID);
            cmd.ExecuteNonQuery();

            object result = "";

            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess);
            try
            {
                while (reader.Read())
                {
                    result = result + reader.GetString(0);
                }
            }
            catch
            {
                return "";
            }

            if (result == null)
            {
                return "";
            }
            if (result.ToString() == "")
            {
                json = "";
            }
            else
            {
                json = (string)result;
            }
            conn3.Close();
            conn3.Dispose();
            conn3 = null;

            return json;
        }

        public string GetScalarString(string sql)
        {
            string x = "";
            System.Data.SqlClient.SqlConnection conn3 = new System.Data.SqlClient.SqlConnection(cnStr);
            conn3.Open();
            SqlCommand cmd = new SqlCommand(sql, conn3);
            object result = cmd.ExecuteScalar();
            if (result == null)
            {
                return "";
            }
            if (result.ToString() == "")
            {
                x = "";
            }
            else
            {
                x = (string)result;
            }
            conn3.Close();
            conn3.Dispose();
            conn3 = null;
            return x;
        }

        public decimal GetScalarDouble(string sql)
        {
            decimal x = 0.0M;
            System.Data.SqlClient.SqlConnection conn3 = new System.Data.SqlClient.SqlConnection(cnStr);
            conn3.Open();
            SqlCommand cmd = new SqlCommand(sql, conn3);
            decimal result = (decimal)(double)cmd.ExecuteScalar();
            if (result == 0)
            {
                x = 0.0M;
            }
            else
            {
                x = result;
            }
            conn3.Close();
            conn3.Dispose();
            conn3 = null;
            return x;
        }


        public string GetScalarXML(string sql, int enrollID, string transType)
        {
            string x = "";
            System.Data.SqlClient.SqlConnection conn3 = new System.Data.SqlClient.SqlConnection(cnStr);
            conn3.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn3;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@enrollment_id", enrollID);
            cmd.Parameters.AddWithValue("@transType", transType);

            string result = "";

            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess);

            while (reader.Read())
            {
                result = result + reader.GetString(0);
            }

            if (result == null)
            {
                x = "";
                conn3.Close();
                conn3.Dispose();
                conn3 = null;
                return x;
            }
            if (result.ToString() == "")
            {
                x = "";
            }
            else
            {
                x = result.ToString();
            }
            conn3.Close();
            conn3.Dispose();
            conn3 = null;
            return x;
        }
        public bool HasData(string sql, SqlConnection newConn = null)
        {
            System.Data.SqlClient.SqlDataReader dr;
            if (newConn == null)
            {
                newConn = conn;
            }

            if (newConn.State != System.Data.ConnectionState.Open)
            {
                newConn.Open();
            }

            SqlCommand cmd = new SqlCommand(sql, newConn);
            cmd.CommandTimeout = 3600;
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    newConn.Close();
                    return true;
                }
                else
                {
                    dr.Close();
                    newConn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                newConn.Close();
                return false;
            }
        }

        public void RunCommand(string sql)
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandTimeout = 6000000;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
        }

        public void RunCommandSP(string sql,List<SqlParameter> parms)
        {
            if (conn.State != ConnectionState.Open && conn.State != ConnectionState.Connecting)
            {
                conn.Open();
            }

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (var parm in parms)
            {
                cmd.Parameters.Add(parm);
            }
            cmd.CommandTimeout = 3600;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
            }
        }
        public int RunCommandSPOutput(string sql, List<SqlParameter> parms)
        {
            if (conn.State != ConnectionState.Open && conn.State != ConnectionState.Connecting)
            {
                conn.Open();
            }

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (var parm in parms)
            {
                cmd.Parameters.Add(parm);
            }
            cmd.CommandTimeout = 3600;
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                return -1;
            }
        }
        public void RunCommandWithEx(string sql, SqlConnection newConn = null)
        {
            if (newConn == null)
            {
                newConn = conn;
            }

            if (newConn.State != System.Data.ConnectionState.Open)
            {
                newConn.Open();
            }

            SqlCommand cmd = new SqlCommand(sql, newConn);
            cmd.CommandTimeout = 6000000;
            try
            {
                cmd.ExecuteNonQuery();
                newConn.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        internal string FSQ(string v)
        {
            if (v != null)
                return v.Replace("'", "''");
            else
                return "";
        }
        public string MapBoolean(bool val)
        {
            if (val)
                return "1";
            return "0";
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn = null;
            }
        }
    }
}



