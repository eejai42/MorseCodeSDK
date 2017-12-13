/************************************************
 CODEE42 - AUTO GENERATED FILE - DO NOT OVERWRITE
 ************************************************
 Created By: EJ Alexandra - 2016
             An Abstract Level, llc
 License:    Mozilla Public License 2.0
 ************************************************
 CODEE42 - AUTO GENERATED FILE - DO NOT OVERWRITE
 ************************************************/
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;

using MorseCodeSDK.Lib.DataClasses;

using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.SqlDataManagement
{
    public partial class SqlDataManager : IDisposable
    {
        public SqlDataManager() : this(SqlDataManager.LastConnectionString) 
        {
            this.Schema = "dbo";
        }
    
        public SqlDataManager(String connectionString)
        {
            this.Schema = "dbo";
            this.ConnectionString = connectionString;
            if (String.IsNullOrEmpty(this.ConnectionString))
            {
                this.ConnectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            }
        }

        public SqlDataManager(String dataSourceName, String dbName) 
        {
            this.Schema = "dbo";
            this.DataSourceName = dataSourceName;
            this.DBName = dbName;
        }
        
        public void Dispose() 
        {
            this.IsDisposed = true;
        }
        
        public static string LastConnectionString { get; set; }
        public string ConnectionString { get; set; }
        public String DataSourceName { get; set; }
        public String DBName { get; set; }
        public Boolean IsDisposed { get; set; }
        public String Schema { get; set; }
        

  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Cable cable)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Cable] (CableId, Name, Description)
                                    VALUES (@CableId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(cable.CableId, null)) cmd.Parameters.AddWithValue("@CableId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@CableId", cable.CableId);
                
                  
                if (ReferenceEquals(cable.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", cable.Name);
                
                  
                if (ReferenceEquals(cable.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", cable.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Cable cable)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = cable.CableId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Cable WHERE CableId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(cable);
                else return this.Insert(cable);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllCables<T>()
            where T : Cable, new()
        {
            return this.GetAllCables<T>(String.Empty);
        }

        
        public List<T> GetAllCables<T>(String whereClause)
            where T : Cable, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Cable]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T cable = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("CableId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          cable.CableId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          cable.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          cable.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(cable);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Cable
        /// </summary>
        /// <returns></returns>
        public int Update(Cable cable)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Cable] SET 
                                    Name = @Name,Description = @Description
                                    WHERE CableId = @CableId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(cable.CableId, null)) cmd.Parameters.AddWithValue("@CableId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@CableId", cable.CableId);
                 //TEXT
                
                if (ReferenceEquals(cable.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", cable.Name);
                 //TEXT
                
                if (ReferenceEquals(cable.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", cable.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Cable
        /// </summary>
        /// <returns></returns>
        public int Delete(Cable cable)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Cable] 
                                    WHERE CableId = @CableId", this.Schema);
                                    
                
                if (ReferenceEquals(cable.CableId, null)) cmd.Parameters.AddWithValue("@CableId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@CableId", cable.CableId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Mnemonic mnemonic)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Mnemonic] (MnemonicId, Name, Description)
                                    VALUES (@MnemonicId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(mnemonic.MnemonicId, null)) cmd.Parameters.AddWithValue("@MnemonicId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@MnemonicId", mnemonic.MnemonicId);
                
                  
                if (ReferenceEquals(mnemonic.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", mnemonic.Name);
                
                  
                if (ReferenceEquals(mnemonic.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", mnemonic.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Mnemonic mnemonic)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = mnemonic.MnemonicId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Mnemonic WHERE MnemonicId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(mnemonic);
                else return this.Insert(mnemonic);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllMnemonics<T>()
            where T : Mnemonic, new()
        {
            return this.GetAllMnemonics<T>(String.Empty);
        }

        
        public List<T> GetAllMnemonics<T>(String whereClause)
            where T : Mnemonic, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Mnemonic]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T mnemonic = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("MnemonicId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          mnemonic.MnemonicId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          mnemonic.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          mnemonic.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(mnemonic);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Mnemonic
        /// </summary>
        /// <returns></returns>
        public int Update(Mnemonic mnemonic)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Mnemonic] SET 
                                    Name = @Name,Description = @Description
                                    WHERE MnemonicId = @MnemonicId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(mnemonic.MnemonicId, null)) cmd.Parameters.AddWithValue("@MnemonicId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@MnemonicId", mnemonic.MnemonicId);
                 //TEXT
                
                if (ReferenceEquals(mnemonic.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", mnemonic.Name);
                 //TEXT
                
                if (ReferenceEquals(mnemonic.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", mnemonic.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Mnemonic
        /// </summary>
        /// <returns></returns>
        public int Delete(Mnemonic mnemonic)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Mnemonic] 
                                    WHERE MnemonicId = @MnemonicId", this.Schema);
                                    
                
                if (ReferenceEquals(mnemonic.MnemonicId, null)) cmd.Parameters.AddWithValue("@MnemonicId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@MnemonicId", mnemonic.MnemonicId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Chart chart)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Chart] (ChartId, Name, Description)
                                    VALUES (@ChartId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(chart.ChartId, null)) cmd.Parameters.AddWithValue("@ChartId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@ChartId", chart.ChartId);
                
                  
                if (ReferenceEquals(chart.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", chart.Name);
                
                  
                if (ReferenceEquals(chart.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", chart.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Chart chart)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = chart.ChartId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Chart WHERE ChartId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(chart);
                else return this.Insert(chart);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllCharts<T>()
            where T : Chart, new()
        {
            return this.GetAllCharts<T>(String.Empty);
        }

        
        public List<T> GetAllCharts<T>(String whereClause)
            where T : Chart, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Chart]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T chart = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("ChartId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          chart.ChartId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          chart.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          chart.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(chart);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Chart
        /// </summary>
        /// <returns></returns>
        public int Update(Chart chart)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Chart] SET 
                                    Name = @Name,Description = @Description
                                    WHERE ChartId = @ChartId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(chart.ChartId, null)) cmd.Parameters.AddWithValue("@ChartId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@ChartId", chart.ChartId);
                 //TEXT
                
                if (ReferenceEquals(chart.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", chart.Name);
                 //TEXT
                
                if (ReferenceEquals(chart.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", chart.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Chart
        /// </summary>
        /// <returns></returns>
        public int Delete(Chart chart)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Chart] 
                                    WHERE ChartId = @ChartId", this.Schema);
                                    
                
                if (ReferenceEquals(chart.ChartId, null)) cmd.Parameters.AddWithValue("@ChartId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@ChartId", chart.ChartId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Code code)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Code] (CodeId, Name, Description)
                                    VALUES (@CodeId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(code.CodeId, null)) cmd.Parameters.AddWithValue("@CodeId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@CodeId", code.CodeId);
                
                  
                if (ReferenceEquals(code.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", code.Name);
                
                  
                if (ReferenceEquals(code.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", code.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Code code)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = code.CodeId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Code WHERE CodeId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(code);
                else return this.Insert(code);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllCodes<T>()
            where T : Code, new()
        {
            return this.GetAllCodes<T>(String.Empty);
        }

        
        public List<T> GetAllCodes<T>(String whereClause)
            where T : Code, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Code]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T code = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("CodeId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          code.CodeId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          code.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          code.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(code);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Code
        /// </summary>
        /// <returns></returns>
        public int Update(Code code)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Code] SET 
                                    Name = @Name,Description = @Description
                                    WHERE CodeId = @CodeId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(code.CodeId, null)) cmd.Parameters.AddWithValue("@CodeId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@CodeId", code.CodeId);
                 //TEXT
                
                if (ReferenceEquals(code.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", code.Name);
                 //TEXT
                
                if (ReferenceEquals(code.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", code.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Code
        /// </summary>
        /// <returns></returns>
        public int Delete(Code code)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Code] 
                                    WHERE CodeId = @CodeId", this.Schema);
                                    
                
                if (ReferenceEquals(code.CodeId, null)) cmd.Parameters.AddWithValue("@CodeId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@CodeId", code.CodeId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Listener listener)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Listener] (ListenerId, Name, Description)
                                    VALUES (@ListenerId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(listener.ListenerId, null)) cmd.Parameters.AddWithValue("@ListenerId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@ListenerId", listener.ListenerId);
                
                  
                if (ReferenceEquals(listener.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", listener.Name);
                
                  
                if (ReferenceEquals(listener.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", listener.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Listener listener)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = listener.ListenerId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Listener WHERE ListenerId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(listener);
                else return this.Insert(listener);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllListeners<T>()
            where T : Listener, new()
        {
            return this.GetAllListeners<T>(String.Empty);
        }

        
        public List<T> GetAllListeners<T>(String whereClause)
            where T : Listener, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Listener]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T listener = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("ListenerId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          listener.ListenerId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          listener.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          listener.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(listener);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Listener
        /// </summary>
        /// <returns></returns>
        public int Update(Listener listener)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Listener] SET 
                                    Name = @Name,Description = @Description
                                    WHERE ListenerId = @ListenerId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(listener.ListenerId, null)) cmd.Parameters.AddWithValue("@ListenerId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@ListenerId", listener.ListenerId);
                 //TEXT
                
                if (ReferenceEquals(listener.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", listener.Name);
                 //TEXT
                
                if (ReferenceEquals(listener.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", listener.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Listener
        /// </summary>
        /// <returns></returns>
        public int Delete(Listener listener)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Listener] 
                                    WHERE ListenerId = @ListenerId", this.Schema);
                                    
                
                if (ReferenceEquals(listener.ListenerId, null)) cmd.Parameters.AddWithValue("@ListenerId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@ListenerId", listener.ListenerId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Observer observer)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Observer] (ObserverId, Name, Description)
                                    VALUES (@ObserverId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(observer.ObserverId, null)) cmd.Parameters.AddWithValue("@ObserverId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@ObserverId", observer.ObserverId);
                
                  
                if (ReferenceEquals(observer.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", observer.Name);
                
                  
                if (ReferenceEquals(observer.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", observer.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Observer observer)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = observer.ObserverId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Observer WHERE ObserverId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(observer);
                else return this.Insert(observer);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllObservers<T>()
            where T : Observer, new()
        {
            return this.GetAllObservers<T>(String.Empty);
        }

        
        public List<T> GetAllObservers<T>(String whereClause)
            where T : Observer, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Observer]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T observer = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("ObserverId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          observer.ObserverId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          observer.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          observer.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(observer);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Observer
        /// </summary>
        /// <returns></returns>
        public int Update(Observer observer)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Observer] SET 
                                    Name = @Name,Description = @Description
                                    WHERE ObserverId = @ObserverId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(observer.ObserverId, null)) cmd.Parameters.AddWithValue("@ObserverId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@ObserverId", observer.ObserverId);
                 //TEXT
                
                if (ReferenceEquals(observer.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", observer.Name);
                 //TEXT
                
                if (ReferenceEquals(observer.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", observer.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Observer
        /// </summary>
        /// <returns></returns>
        public int Delete(Observer observer)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Observer] 
                                    WHERE ObserverId = @ObserverId", this.Schema);
                                    
                
                if (ReferenceEquals(observer.ObserverId, null)) cmd.Parameters.AddWithValue("@ObserverId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@ObserverId", observer.ObserverId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Equipment equipment)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Equipment] (EquipmentId, Name, Description)
                                    VALUES (@EquipmentId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(equipment.EquipmentId, null)) cmd.Parameters.AddWithValue("@EquipmentId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@EquipmentId", equipment.EquipmentId);
                
                  
                if (ReferenceEquals(equipment.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", equipment.Name);
                
                  
                if (ReferenceEquals(equipment.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", equipment.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Equipment equipment)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = equipment.EquipmentId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Equipment WHERE EquipmentId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(equipment);
                else return this.Insert(equipment);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllEquipments<T>()
            where T : Equipment, new()
        {
            return this.GetAllEquipments<T>(String.Empty);
        }

        
        public List<T> GetAllEquipments<T>(String whereClause)
            where T : Equipment, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Equipment]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T equipment = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("EquipmentId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          equipment.EquipmentId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          equipment.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          equipment.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(equipment);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Equipment
        /// </summary>
        /// <returns></returns>
        public int Update(Equipment equipment)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Equipment] SET 
                                    Name = @Name,Description = @Description
                                    WHERE EquipmentId = @EquipmentId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(equipment.EquipmentId, null)) cmd.Parameters.AddWithValue("@EquipmentId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@EquipmentId", equipment.EquipmentId);
                 //TEXT
                
                if (ReferenceEquals(equipment.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", equipment.Name);
                 //TEXT
                
                if (ReferenceEquals(equipment.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", equipment.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Equipment
        /// </summary>
        /// <returns></returns>
        public int Delete(Equipment equipment)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Equipment] 
                                    WHERE EquipmentId = @EquipmentId", this.Schema);
                                    
                
                if (ReferenceEquals(equipment.EquipmentId, null)) cmd.Parameters.AddWithValue("@EquipmentId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@EquipmentId", equipment.EquipmentId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Inventor inventor)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Inventor] (InventorId, Name, Description)
                                    VALUES (@InventorId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(inventor.InventorId, null)) cmd.Parameters.AddWithValue("@InventorId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@InventorId", inventor.InventorId);
                
                  
                if (ReferenceEquals(inventor.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", inventor.Name);
                
                  
                if (ReferenceEquals(inventor.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", inventor.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Inventor inventor)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = inventor.InventorId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Inventor WHERE InventorId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(inventor);
                else return this.Insert(inventor);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllInventors<T>()
            where T : Inventor, new()
        {
            return this.GetAllInventors<T>(String.Empty);
        }

        
        public List<T> GetAllInventors<T>(String whereClause)
            where T : Inventor, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Inventor]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T inventor = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("InventorId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          inventor.InventorId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          inventor.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          inventor.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(inventor);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Inventor
        /// </summary>
        /// <returns></returns>
        public int Update(Inventor inventor)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Inventor] SET 
                                    Name = @Name,Description = @Description
                                    WHERE InventorId = @InventorId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(inventor.InventorId, null)) cmd.Parameters.AddWithValue("@InventorId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@InventorId", inventor.InventorId);
                 //TEXT
                
                if (ReferenceEquals(inventor.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", inventor.Name);
                 //TEXT
                
                if (ReferenceEquals(inventor.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", inventor.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Inventor
        /// </summary>
        /// <returns></returns>
        public int Delete(Inventor inventor)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Inventor] 
                                    WHERE InventorId = @InventorId", this.Schema);
                                    
                
                if (ReferenceEquals(inventor.InventorId, null)) cmd.Parameters.AddWithValue("@InventorId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@InventorId", inventor.InventorId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Telegraph telegraph)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Telegraph] (TelegraphId, Name, Description)
                                    VALUES (@TelegraphId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(telegraph.TelegraphId, null)) cmd.Parameters.AddWithValue("@TelegraphId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@TelegraphId", telegraph.TelegraphId);
                
                  
                if (ReferenceEquals(telegraph.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", telegraph.Name);
                
                  
                if (ReferenceEquals(telegraph.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", telegraph.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Telegraph telegraph)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = telegraph.TelegraphId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Telegraph WHERE TelegraphId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(telegraph);
                else return this.Insert(telegraph);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllTelegraphs<T>()
            where T : Telegraph, new()
        {
            return this.GetAllTelegraphs<T>(String.Empty);
        }

        
        public List<T> GetAllTelegraphs<T>(String whereClause)
            where T : Telegraph, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Telegraph]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T telegraph = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("TelegraphId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          telegraph.TelegraphId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          telegraph.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          telegraph.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(telegraph);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Telegraph
        /// </summary>
        /// <returns></returns>
        public int Update(Telegraph telegraph)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Telegraph] SET 
                                    Name = @Name,Description = @Description
                                    WHERE TelegraphId = @TelegraphId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(telegraph.TelegraphId, null)) cmd.Parameters.AddWithValue("@TelegraphId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@TelegraphId", telegraph.TelegraphId);
                 //TEXT
                
                if (ReferenceEquals(telegraph.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", telegraph.Name);
                 //TEXT
                
                if (ReferenceEquals(telegraph.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", telegraph.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Telegraph
        /// </summary>
        /// <returns></returns>
        public int Delete(Telegraph telegraph)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Telegraph] 
                                    WHERE TelegraphId = @TelegraphId", this.Schema);
                                    
                
                if (ReferenceEquals(telegraph.TelegraphId, null)) cmd.Parameters.AddWithValue("@TelegraphId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@TelegraphId", telegraph.TelegraphId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Alphabet alphabet)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Alphabet] (AlphabetId, Name, Description)
                                    VALUES (@AlphabetId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(alphabet.AlphabetId, null)) cmd.Parameters.AddWithValue("@AlphabetId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@AlphabetId", alphabet.AlphabetId);
                
                  
                if (ReferenceEquals(alphabet.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", alphabet.Name);
                
                  
                if (ReferenceEquals(alphabet.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", alphabet.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Alphabet alphabet)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = alphabet.AlphabetId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Alphabet WHERE AlphabetId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(alphabet);
                else return this.Insert(alphabet);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllAlphabets<T>()
            where T : Alphabet, new()
        {
            return this.GetAllAlphabets<T>(String.Empty);
        }

        
        public List<T> GetAllAlphabets<T>(String whereClause)
            where T : Alphabet, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Alphabet]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T alphabet = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("AlphabetId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          alphabet.AlphabetId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          alphabet.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          alphabet.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(alphabet);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Alphabet
        /// </summary>
        /// <returns></returns>
        public int Update(Alphabet alphabet)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Alphabet] SET 
                                    Name = @Name,Description = @Description
                                    WHERE AlphabetId = @AlphabetId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(alphabet.AlphabetId, null)) cmd.Parameters.AddWithValue("@AlphabetId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@AlphabetId", alphabet.AlphabetId);
                 //TEXT
                
                if (ReferenceEquals(alphabet.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", alphabet.Name);
                 //TEXT
                
                if (ReferenceEquals(alphabet.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", alphabet.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Alphabet
        /// </summary>
        /// <returns></returns>
        public int Delete(Alphabet alphabet)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Alphabet] 
                                    WHERE AlphabetId = @AlphabetId", this.Schema);
                                    
                
                if (ReferenceEquals(alphabet.AlphabetId, null)) cmd.Parameters.AddWithValue("@AlphabetId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@AlphabetId", alphabet.AlphabetId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Punctuation punctuation)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Punctuation] (PunctuationId, Name, Description)
                                    VALUES (@PunctuationId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(punctuation.PunctuationId, null)) cmd.Parameters.AddWithValue("@PunctuationId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@PunctuationId", punctuation.PunctuationId);
                
                  
                if (ReferenceEquals(punctuation.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", punctuation.Name);
                
                  
                if (ReferenceEquals(punctuation.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", punctuation.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Punctuation punctuation)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = punctuation.PunctuationId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Punctuation WHERE PunctuationId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(punctuation);
                else return this.Insert(punctuation);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllPunctuations<T>()
            where T : Punctuation, new()
        {
            return this.GetAllPunctuations<T>(String.Empty);
        }

        
        public List<T> GetAllPunctuations<T>(String whereClause)
            where T : Punctuation, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Punctuation]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T punctuation = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("PunctuationId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          punctuation.PunctuationId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          punctuation.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          punctuation.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(punctuation);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Punctuation
        /// </summary>
        /// <returns></returns>
        public int Update(Punctuation punctuation)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Punctuation] SET 
                                    Name = @Name,Description = @Description
                                    WHERE PunctuationId = @PunctuationId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(punctuation.PunctuationId, null)) cmd.Parameters.AddWithValue("@PunctuationId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@PunctuationId", punctuation.PunctuationId);
                 //TEXT
                
                if (ReferenceEquals(punctuation.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", punctuation.Name);
                 //TEXT
                
                if (ReferenceEquals(punctuation.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", punctuation.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Punctuation
        /// </summary>
        /// <returns></returns>
        public int Delete(Punctuation punctuation)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Punctuation] 
                                    WHERE PunctuationId = @PunctuationId", this.Schema);
                                    
                
                if (ReferenceEquals(punctuation.PunctuationId, null)) cmd.Parameters.AddWithValue("@PunctuationId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@PunctuationId", punctuation.PunctuationId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Radio radio)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Radio] (RadioId, Name, Description)
                                    VALUES (@RadioId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(radio.RadioId, null)) cmd.Parameters.AddWithValue("@RadioId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@RadioId", radio.RadioId);
                
                  
                if (ReferenceEquals(radio.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", radio.Name);
                
                  
                if (ReferenceEquals(radio.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", radio.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Radio radio)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = radio.RadioId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Radio WHERE RadioId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(radio);
                else return this.Insert(radio);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllRadios<T>()
            where T : Radio, new()
        {
            return this.GetAllRadios<T>(String.Empty);
        }

        
        public List<T> GetAllRadios<T>(String whereClause)
            where T : Radio, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Radio]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T radio = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("RadioId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          radio.RadioId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          radio.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          radio.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(radio);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Radio
        /// </summary>
        /// <returns></returns>
        public int Update(Radio radio)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Radio] SET 
                                    Name = @Name,Description = @Description
                                    WHERE RadioId = @RadioId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(radio.RadioId, null)) cmd.Parameters.AddWithValue("@RadioId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@RadioId", radio.RadioId);
                 //TEXT
                
                if (ReferenceEquals(radio.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", radio.Name);
                 //TEXT
                
                if (ReferenceEquals(radio.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", radio.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Radio
        /// </summary>
        /// <returns></returns>
        public int Delete(Radio radio)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Radio] 
                                    WHERE RadioId = @RadioId", this.Schema);
                                    
                
                if (ReferenceEquals(radio.RadioId, null)) cmd.Parameters.AddWithValue("@RadioId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@RadioId", radio.RadioId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Character character)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Character] (CharacterId, Name, Description)
                                    VALUES (@CharacterId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(character.CharacterId, null)) cmd.Parameters.AddWithValue("@CharacterId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@CharacterId", character.CharacterId);
                
                  
                if (ReferenceEquals(character.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", character.Name);
                
                  
                if (ReferenceEquals(character.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", character.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Character character)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = character.CharacterId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Character WHERE CharacterId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(character);
                else return this.Insert(character);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllCharacters<T>()
            where T : Character, new()
        {
            return this.GetAllCharacters<T>(String.Empty);
        }

        
        public List<T> GetAllCharacters<T>(String whereClause)
            where T : Character, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Character]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T character = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("CharacterId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          character.CharacterId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          character.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          character.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(character);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Character
        /// </summary>
        /// <returns></returns>
        public int Update(Character character)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Character] SET 
                                    Name = @Name,Description = @Description
                                    WHERE CharacterId = @CharacterId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(character.CharacterId, null)) cmd.Parameters.AddWithValue("@CharacterId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@CharacterId", character.CharacterId);
                 //TEXT
                
                if (ReferenceEquals(character.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", character.Name);
                 //TEXT
                
                if (ReferenceEquals(character.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", character.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Character
        /// </summary>
        /// <returns></returns>
        public int Delete(Character character)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Character] 
                                    WHERE CharacterId = @CharacterId", this.Schema);
                                    
                
                if (ReferenceEquals(character.CharacterId, null)) cmd.Parameters.AddWithValue("@CharacterId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@CharacterId", character.CharacterId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Duration duration)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Duration] (DurationId, Name, Description)
                                    VALUES (@DurationId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(duration.DurationId, null)) cmd.Parameters.AddWithValue("@DurationId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@DurationId", duration.DurationId);
                
                  
                if (ReferenceEquals(duration.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", duration.Name);
                
                  
                if (ReferenceEquals(duration.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", duration.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Duration duration)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = duration.DurationId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Duration WHERE DurationId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(duration);
                else return this.Insert(duration);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllDurations<T>()
            where T : Duration, new()
        {
            return this.GetAllDurations<T>(String.Empty);
        }

        
        public List<T> GetAllDurations<T>(String whereClause)
            where T : Duration, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Duration]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T duration = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("DurationId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          duration.DurationId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          duration.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          duration.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(duration);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Duration
        /// </summary>
        /// <returns></returns>
        public int Update(Duration duration)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Duration] SET 
                                    Name = @Name,Description = @Description
                                    WHERE DurationId = @DurationId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(duration.DurationId, null)) cmd.Parameters.AddWithValue("@DurationId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@DurationId", duration.DurationId);
                 //TEXT
                
                if (ReferenceEquals(duration.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", duration.Name);
                 //TEXT
                
                if (ReferenceEquals(duration.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", duration.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Duration
        /// </summary>
        /// <returns></returns>
        public int Delete(Duration duration)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Duration] 
                                    WHERE DurationId = @DurationId", this.Schema);
                                    
                
                if (ReferenceEquals(duration.DurationId, null)) cmd.Parameters.AddWithValue("@DurationId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@DurationId", duration.DurationId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Unit unit)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Unit] (UnitId, Name, Description)
                                    VALUES (@UnitId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(unit.UnitId, null)) cmd.Parameters.AddWithValue("@UnitId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@UnitId", unit.UnitId);
                
                  
                if (ReferenceEquals(unit.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", unit.Name);
                
                  
                if (ReferenceEquals(unit.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", unit.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Unit unit)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = unit.UnitId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Unit WHERE UnitId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(unit);
                else return this.Insert(unit);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllUnits<T>()
            where T : Unit, new()
        {
            return this.GetAllUnits<T>(String.Empty);
        }

        
        public List<T> GetAllUnits<T>(String whereClause)
            where T : Unit, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Unit]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T unit = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("UnitId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          unit.UnitId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          unit.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          unit.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(unit);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Unit
        /// </summary>
        /// <returns></returns>
        public int Update(Unit unit)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Unit] SET 
                                    Name = @Name,Description = @Description
                                    WHERE UnitId = @UnitId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(unit.UnitId, null)) cmd.Parameters.AddWithValue("@UnitId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@UnitId", unit.UnitId);
                 //TEXT
                
                if (ReferenceEquals(unit.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", unit.Name);
                 //TEXT
                
                if (ReferenceEquals(unit.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", unit.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Unit
        /// </summary>
        /// <returns></returns>
        public int Delete(Unit unit)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Unit] 
                                    WHERE UnitId = @UnitId", this.Schema);
                                    
                
                if (ReferenceEquals(unit.UnitId, null)) cmd.Parameters.AddWithValue("@UnitId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@UnitId", unit.UnitId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Transmission transmission)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Transmission] (TransmissionId, Name, Description)
                                    VALUES (@TransmissionId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(transmission.TransmissionId, null)) cmd.Parameters.AddWithValue("@TransmissionId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@TransmissionId", transmission.TransmissionId);
                
                  
                if (ReferenceEquals(transmission.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", transmission.Name);
                
                  
                if (ReferenceEquals(transmission.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", transmission.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Transmission transmission)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = transmission.TransmissionId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Transmission WHERE TransmissionId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(transmission);
                else return this.Insert(transmission);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllTransmissions<T>()
            where T : Transmission, new()
        {
            return this.GetAllTransmissions<T>(String.Empty);
        }

        
        public List<T> GetAllTransmissions<T>(String whereClause)
            where T : Transmission, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Transmission]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T transmission = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("TransmissionId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          transmission.TransmissionId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          transmission.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          transmission.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(transmission);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Transmission
        /// </summary>
        /// <returns></returns>
        public int Update(Transmission transmission)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Transmission] SET 
                                    Name = @Name,Description = @Description
                                    WHERE TransmissionId = @TransmissionId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(transmission.TransmissionId, null)) cmd.Parameters.AddWithValue("@TransmissionId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@TransmissionId", transmission.TransmissionId);
                 //TEXT
                
                if (ReferenceEquals(transmission.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", transmission.Name);
                 //TEXT
                
                if (ReferenceEquals(transmission.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", transmission.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Transmission
        /// </summary>
        /// <returns></returns>
        public int Delete(Transmission transmission)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Transmission] 
                                    WHERE TransmissionId = @TransmissionId", this.Schema);
                                    
                
                if (ReferenceEquals(transmission.TransmissionId, null)) cmd.Parameters.AddWithValue("@TransmissionId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@TransmissionId", transmission.TransmissionId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Word word)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Word] (WordId, Name, Description)
                                    VALUES (@WordId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(word.WordId, null)) cmd.Parameters.AddWithValue("@WordId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@WordId", word.WordId);
                
                  
                if (ReferenceEquals(word.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", word.Name);
                
                  
                if (ReferenceEquals(word.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", word.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Word word)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = word.WordId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Word WHERE WordId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(word);
                else return this.Insert(word);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllWords<T>()
            where T : Word, new()
        {
            return this.GetAllWords<T>(String.Empty);
        }

        
        public List<T> GetAllWords<T>(String whereClause)
            where T : Word, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Word]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T word = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("WordId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          word.WordId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          word.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          word.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(word);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Word
        /// </summary>
        /// <returns></returns>
        public int Update(Word word)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Word] SET 
                                    Name = @Name,Description = @Description
                                    WHERE WordId = @WordId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(word.WordId, null)) cmd.Parameters.AddWithValue("@WordId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@WordId", word.WordId);
                 //TEXT
                
                if (ReferenceEquals(word.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", word.Name);
                 //TEXT
                
                if (ReferenceEquals(word.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", word.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Word
        /// </summary>
        /// <returns></returns>
        public int Delete(Word word)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Word] 
                                    WHERE WordId = @WordId", this.Schema);
                                    
                
                if (ReferenceEquals(word.WordId, null)) cmd.Parameters.AddWithValue("@WordId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@WordId", word.WordId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Delimiter delimiter)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Delimiter] (DelimiterId, Name, Description)
                                    VALUES (@DelimiterId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(delimiter.DelimiterId, null)) cmd.Parameters.AddWithValue("@DelimiterId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@DelimiterId", delimiter.DelimiterId);
                
                  
                if (ReferenceEquals(delimiter.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", delimiter.Name);
                
                  
                if (ReferenceEquals(delimiter.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", delimiter.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Delimiter delimiter)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = delimiter.DelimiterId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Delimiter WHERE DelimiterId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(delimiter);
                else return this.Insert(delimiter);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllDelimiters<T>()
            where T : Delimiter, new()
        {
            return this.GetAllDelimiters<T>(String.Empty);
        }

        
        public List<T> GetAllDelimiters<T>(String whereClause)
            where T : Delimiter, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Delimiter]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T delimiter = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("DelimiterId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          delimiter.DelimiterId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          delimiter.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          delimiter.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(delimiter);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Delimiter
        /// </summary>
        /// <returns></returns>
        public int Update(Delimiter delimiter)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Delimiter] SET 
                                    Name = @Name,Description = @Description
                                    WHERE DelimiterId = @DelimiterId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(delimiter.DelimiterId, null)) cmd.Parameters.AddWithValue("@DelimiterId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@DelimiterId", delimiter.DelimiterId);
                 //TEXT
                
                if (ReferenceEquals(delimiter.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", delimiter.Name);
                 //TEXT
                
                if (ReferenceEquals(delimiter.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", delimiter.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Delimiter
        /// </summary>
        /// <returns></returns>
        public int Delete(Delimiter delimiter)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Delimiter] 
                                    WHERE DelimiterId = @DelimiterId", this.Schema);
                                    
                
                if (ReferenceEquals(delimiter.DelimiterId, null)) cmd.Parameters.AddWithValue("@DelimiterId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@DelimiterId", delimiter.DelimiterId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Space space)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Space] (SpaceId, Name, Description)
                                    VALUES (@SpaceId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(space.SpaceId, null)) cmd.Parameters.AddWithValue("@SpaceId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@SpaceId", space.SpaceId);
                
                  
                if (ReferenceEquals(space.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", space.Name);
                
                  
                if (ReferenceEquals(space.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", space.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Space space)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = space.SpaceId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Space WHERE SpaceId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(space);
                else return this.Insert(space);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllSpaces<T>()
            where T : Space, new()
        {
            return this.GetAllSpaces<T>(String.Empty);
        }

        
        public List<T> GetAllSpaces<T>(String whereClause)
            where T : Space, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Space]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T space = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("SpaceId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          space.SpaceId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          space.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          space.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(space);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Space
        /// </summary>
        /// <returns></returns>
        public int Update(Space space)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Space] SET 
                                    Name = @Name,Description = @Description
                                    WHERE SpaceId = @SpaceId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(space.SpaceId, null)) cmd.Parameters.AddWithValue("@SpaceId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@SpaceId", space.SpaceId);
                 //TEXT
                
                if (ReferenceEquals(space.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", space.Name);
                 //TEXT
                
                if (ReferenceEquals(space.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", space.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Space
        /// </summary>
        /// <returns></returns>
        public int Delete(Space space)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Space] 
                                    WHERE SpaceId = @SpaceId", this.Schema);
                                    
                
                if (ReferenceEquals(space.SpaceId, null)) cmd.Parameters.AddWithValue("@SpaceId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@SpaceId", space.SpaceId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Speed speed)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Speed] (SpeedId, Name, Description)
                                    VALUES (@SpeedId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(speed.SpeedId, null)) cmd.Parameters.AddWithValue("@SpeedId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@SpeedId", speed.SpeedId);
                
                  
                if (ReferenceEquals(speed.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", speed.Name);
                
                  
                if (ReferenceEquals(speed.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", speed.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Speed speed)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = speed.SpeedId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Speed WHERE SpeedId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(speed);
                else return this.Insert(speed);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllSpeeds<T>()
            where T : Speed, new()
        {
            return this.GetAllSpeeds<T>(String.Empty);
        }

        
        public List<T> GetAllSpeeds<T>(String whereClause)
            where T : Speed, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Speed]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T speed = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("SpeedId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          speed.SpeedId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          speed.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          speed.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(speed);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Speed
        /// </summary>
        /// <returns></returns>
        public int Update(Speed speed)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Speed] SET 
                                    Name = @Name,Description = @Description
                                    WHERE SpeedId = @SpeedId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(speed.SpeedId, null)) cmd.Parameters.AddWithValue("@SpeedId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@SpeedId", speed.SpeedId);
                 //TEXT
                
                if (ReferenceEquals(speed.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", speed.Name);
                 //TEXT
                
                if (ReferenceEquals(speed.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", speed.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Speed
        /// </summary>
        /// <returns></returns>
        public int Delete(Speed speed)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Speed] 
                                    WHERE SpeedId = @SpeedId", this.Schema);
                                    
                
                if (ReferenceEquals(speed.SpeedId, null)) cmd.Parameters.AddWithValue("@SpeedId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@SpeedId", speed.SpeedId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Occurrence occurrence)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Occurrence] (OccurrenceId, Name, Description)
                                    VALUES (@OccurrenceId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(occurrence.OccurrenceId, null)) cmd.Parameters.AddWithValue("@OccurrenceId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@OccurrenceId", occurrence.OccurrenceId);
                
                  
                if (ReferenceEquals(occurrence.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", occurrence.Name);
                
                  
                if (ReferenceEquals(occurrence.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", occurrence.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Occurrence occurrence)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = occurrence.OccurrenceId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Occurrence WHERE OccurrenceId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(occurrence);
                else return this.Insert(occurrence);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllOccurrences<T>()
            where T : Occurrence, new()
        {
            return this.GetAllOccurrences<T>(String.Empty);
        }

        
        public List<T> GetAllOccurrences<T>(String whereClause)
            where T : Occurrence, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Occurrence]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T occurrence = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("OccurrenceId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          occurrence.OccurrenceId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          occurrence.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          occurrence.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(occurrence);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Occurrence
        /// </summary>
        /// <returns></returns>
        public int Update(Occurrence occurrence)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Occurrence] SET 
                                    Name = @Name,Description = @Description
                                    WHERE OccurrenceId = @OccurrenceId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(occurrence.OccurrenceId, null)) cmd.Parameters.AddWithValue("@OccurrenceId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@OccurrenceId", occurrence.OccurrenceId);
                 //TEXT
                
                if (ReferenceEquals(occurrence.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", occurrence.Name);
                 //TEXT
                
                if (ReferenceEquals(occurrence.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", occurrence.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Occurrence
        /// </summary>
        /// <returns></returns>
        public int Delete(Occurrence occurrence)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Occurrence] 
                                    WHERE OccurrenceId = @OccurrenceId", this.Schema);
                                    
                
                if (ReferenceEquals(occurrence.OccurrenceId, null)) cmd.Parameters.AddWithValue("@OccurrenceId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@OccurrenceId", occurrence.OccurrenceId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Decoding decoding)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Decoding] (DecodingId, Name, Description)
                                    VALUES (@DecodingId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(decoding.DecodingId, null)) cmd.Parameters.AddWithValue("@DecodingId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@DecodingId", decoding.DecodingId);
                
                  
                if (ReferenceEquals(decoding.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", decoding.Name);
                
                  
                if (ReferenceEquals(decoding.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", decoding.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Decoding decoding)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = decoding.DecodingId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Decoding WHERE DecodingId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(decoding);
                else return this.Insert(decoding);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllDecodings<T>()
            where T : Decoding, new()
        {
            return this.GetAllDecodings<T>(String.Empty);
        }

        
        public List<T> GetAllDecodings<T>(String whereClause)
            where T : Decoding, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Decoding]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T decoding = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("DecodingId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          decoding.DecodingId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          decoding.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          decoding.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(decoding);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Decoding
        /// </summary>
        /// <returns></returns>
        public int Update(Decoding decoding)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Decoding] SET 
                                    Name = @Name,Description = @Description
                                    WHERE DecodingId = @DecodingId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(decoding.DecodingId, null)) cmd.Parameters.AddWithValue("@DecodingId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@DecodingId", decoding.DecodingId);
                 //TEXT
                
                if (ReferenceEquals(decoding.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", decoding.Name);
                 //TEXT
                
                if (ReferenceEquals(decoding.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", decoding.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Decoding
        /// </summary>
        /// <returns></returns>
        public int Delete(Decoding decoding)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Decoding] 
                                    WHERE DecodingId = @DecodingId", this.Schema);
                                    
                
                if (ReferenceEquals(decoding.DecodingId, null)) cmd.Parameters.AddWithValue("@DecodingId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@DecodingId", decoding.DecodingId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Device device)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Device] (DeviceId, Name, Description)
                                    VALUES (@DeviceId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(device.DeviceId, null)) cmd.Parameters.AddWithValue("@DeviceId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@DeviceId", device.DeviceId);
                
                  
                if (ReferenceEquals(device.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", device.Name);
                
                  
                if (ReferenceEquals(device.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", device.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Device device)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = device.DeviceId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Device WHERE DeviceId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(device);
                else return this.Insert(device);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllDevices<T>()
            where T : Device, new()
        {
            return this.GetAllDevices<T>(String.Empty);
        }

        
        public List<T> GetAllDevices<T>(String whereClause)
            where T : Device, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Device]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T device = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("DeviceId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          device.DeviceId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          device.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          device.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(device);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Device
        /// </summary>
        /// <returns></returns>
        public int Update(Device device)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Device] SET 
                                    Name = @Name,Description = @Description
                                    WHERE DeviceId = @DeviceId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(device.DeviceId, null)) cmd.Parameters.AddWithValue("@DeviceId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@DeviceId", device.DeviceId);
                 //TEXT
                
                if (ReferenceEquals(device.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", device.Name);
                 //TEXT
                
                if (ReferenceEquals(device.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", device.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Device
        /// </summary>
        /// <returns></returns>
        public int Delete(Device device)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Device] 
                                    WHERE DeviceId = @DeviceId", this.Schema);
                                    
                
                if (ReferenceEquals(device.DeviceId, null)) cmd.Parameters.AddWithValue("@DeviceId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@DeviceId", device.DeviceId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Alternative alternative)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Alternative] (AlternativeId, Name, Description)
                                    VALUES (@AlternativeId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(alternative.AlternativeId, null)) cmd.Parameters.AddWithValue("@AlternativeId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@AlternativeId", alternative.AlternativeId);
                
                  
                if (ReferenceEquals(alternative.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", alternative.Name);
                
                  
                if (ReferenceEquals(alternative.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", alternative.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Alternative alternative)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = alternative.AlternativeId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Alternative WHERE AlternativeId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(alternative);
                else return this.Insert(alternative);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllAlternatives<T>()
            where T : Alternative, new()
        {
            return this.GetAllAlternatives<T>(String.Empty);
        }

        
        public List<T> GetAllAlternatives<T>(String whereClause)
            where T : Alternative, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Alternative]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T alternative = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("AlternativeId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          alternative.AlternativeId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          alternative.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          alternative.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(alternative);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Alternative
        /// </summary>
        /// <returns></returns>
        public int Update(Alternative alternative)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Alternative] SET 
                                    Name = @Name,Description = @Description
                                    WHERE AlternativeId = @AlternativeId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(alternative.AlternativeId, null)) cmd.Parameters.AddWithValue("@AlternativeId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@AlternativeId", alternative.AlternativeId);
                 //TEXT
                
                if (ReferenceEquals(alternative.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", alternative.Name);
                 //TEXT
                
                if (ReferenceEquals(alternative.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", alternative.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Alternative
        /// </summary>
        /// <returns></returns>
        public int Delete(Alternative alternative)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Alternative] 
                                    WHERE AlternativeId = @AlternativeId", this.Schema);
                                    
                
                if (ReferenceEquals(alternative.AlternativeId, null)) cmd.Parameters.AddWithValue("@AlternativeId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@AlternativeId", alternative.AlternativeId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Speech speech)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Speech] (SpeechId, Name, Description)
                                    VALUES (@SpeechId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(speech.SpeechId, null)) cmd.Parameters.AddWithValue("@SpeechId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@SpeechId", speech.SpeechId);
                
                  
                if (ReferenceEquals(speech.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", speech.Name);
                
                  
                if (ReferenceEquals(speech.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", speech.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Speech speech)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = speech.SpeechId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Speech WHERE SpeechId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(speech);
                else return this.Insert(speech);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllSpeechs<T>()
            where T : Speech, new()
        {
            return this.GetAllSpeechs<T>(String.Empty);
        }

        
        public List<T> GetAllSpeechs<T>(String whereClause)
            where T : Speech, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Speech]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T speech = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("SpeechId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          speech.SpeechId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          speech.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          speech.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(speech);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Speech
        /// </summary>
        /// <returns></returns>
        public int Update(Speech speech)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Speech] SET 
                                    Name = @Name,Description = @Description
                                    WHERE SpeechId = @SpeechId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(speech.SpeechId, null)) cmd.Parameters.AddWithValue("@SpeechId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@SpeechId", speech.SpeechId);
                 //TEXT
                
                if (ReferenceEquals(speech.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", speech.Name);
                 //TEXT
                
                if (ReferenceEquals(speech.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", speech.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Speech
        /// </summary>
        /// <returns></returns>
        public int Delete(Speech speech)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Speech] 
                                    WHERE SpeechId = @SpeechId", this.Schema);
                                    
                
                if (ReferenceEquals(speech.SpeechId, null)) cmd.Parameters.AddWithValue("@SpeechId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@SpeechId", speech.SpeechId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Example example)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Example] (ExampleId, Name, Description)
                                    VALUES (@ExampleId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(example.ExampleId, null)) cmd.Parameters.AddWithValue("@ExampleId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@ExampleId", example.ExampleId);
                
                  
                if (ReferenceEquals(example.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", example.Name);
                
                  
                if (ReferenceEquals(example.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", example.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Example example)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = example.ExampleId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Example WHERE ExampleId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(example);
                else return this.Insert(example);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllExamples<T>()
            where T : Example, new()
        {
            return this.GetAllExamples<T>(String.Empty);
        }

        
        public List<T> GetAllExamples<T>(String whereClause)
            where T : Example, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Example]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T example = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("ExampleId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          example.ExampleId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          example.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          example.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(example);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Example
        /// </summary>
        /// <returns></returns>
        public int Update(Example example)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Example] SET 
                                    Name = @Name,Description = @Description
                                    WHERE ExampleId = @ExampleId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(example.ExampleId, null)) cmd.Parameters.AddWithValue("@ExampleId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@ExampleId", example.ExampleId);
                 //TEXT
                
                if (ReferenceEquals(example.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", example.Name);
                 //TEXT
                
                if (ReferenceEquals(example.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", example.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Example
        /// </summary>
        /// <returns></returns>
        public int Delete(Example example)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Example] 
                                    WHERE ExampleId = @ExampleId", this.Schema);
                                    
                
                if (ReferenceEquals(example.ExampleId, null)) cmd.Parameters.AddWithValue("@ExampleId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@ExampleId", example.ExampleId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Emergency emergency)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Emergency] (EmergencyId, Name, Description)
                                    VALUES (@EmergencyId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(emergency.EmergencyId, null)) cmd.Parameters.AddWithValue("@EmergencyId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@EmergencyId", emergency.EmergencyId);
                
                  
                if (ReferenceEquals(emergency.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", emergency.Name);
                
                  
                if (ReferenceEquals(emergency.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", emergency.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Emergency emergency)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = emergency.EmergencyId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Emergency WHERE EmergencyId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(emergency);
                else return this.Insert(emergency);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllEmergencies<T>()
            where T : Emergency, new()
        {
            return this.GetAllEmergencies<T>(String.Empty);
        }

        
        public List<T> GetAllEmergencies<T>(String whereClause)
            where T : Emergency, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Emergency]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T emergency = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("EmergencyId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          emergency.EmergencyId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          emergency.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          emergency.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(emergency);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Emergency
        /// </summary>
        /// <returns></returns>
        public int Update(Emergency emergency)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Emergency] SET 
                                    Name = @Name,Description = @Description
                                    WHERE EmergencyId = @EmergencyId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(emergency.EmergencyId, null)) cmd.Parameters.AddWithValue("@EmergencyId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@EmergencyId", emergency.EmergencyId);
                 //TEXT
                
                if (ReferenceEquals(emergency.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", emergency.Name);
                 //TEXT
                
                if (ReferenceEquals(emergency.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", emergency.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Emergency
        /// </summary>
        /// <returns></returns>
        public int Delete(Emergency emergency)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Emergency] 
                                    WHERE EmergencyId = @EmergencyId", this.Schema);
                                    
                
                if (ReferenceEquals(emergency.EmergencyId, null)) cmd.Parameters.AddWithValue("@EmergencyId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@EmergencyId", emergency.EmergencyId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Telecommunication telecommunication)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Telecommunication] (TelecommunicationId, Name, Description)
                                    VALUES (@TelecommunicationId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(telecommunication.TelecommunicationId, null)) cmd.Parameters.AddWithValue("@TelecommunicationId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@TelecommunicationId", telecommunication.TelecommunicationId);
                
                  
                if (ReferenceEquals(telecommunication.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", telecommunication.Name);
                
                  
                if (ReferenceEquals(telecommunication.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", telecommunication.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Telecommunication telecommunication)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = telecommunication.TelecommunicationId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Telecommunication WHERE TelecommunicationId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(telecommunication);
                else return this.Insert(telecommunication);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllTelecommunications<T>()
            where T : Telecommunication, new()
        {
            return this.GetAllTelecommunications<T>(String.Empty);
        }

        
        public List<T> GetAllTelecommunications<T>(String whereClause)
            where T : Telecommunication, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Telecommunication]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T telecommunication = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("TelecommunicationId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          telecommunication.TelecommunicationId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          telecommunication.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          telecommunication.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(telecommunication);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Telecommunication
        /// </summary>
        /// <returns></returns>
        public int Update(Telecommunication telecommunication)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Telecommunication] SET 
                                    Name = @Name,Description = @Description
                                    WHERE TelecommunicationId = @TelecommunicationId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(telecommunication.TelecommunicationId, null)) cmd.Parameters.AddWithValue("@TelecommunicationId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@TelecommunicationId", telecommunication.TelecommunicationId);
                 //TEXT
                
                if (ReferenceEquals(telecommunication.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", telecommunication.Name);
                 //TEXT
                
                if (ReferenceEquals(telecommunication.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", telecommunication.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Telecommunication
        /// </summary>
        /// <returns></returns>
        public int Delete(Telecommunication telecommunication)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Telecommunication] 
                                    WHERE TelecommunicationId = @TelecommunicationId", this.Schema);
                                    
                
                if (ReferenceEquals(telecommunication.TelecommunicationId, null)) cmd.Parameters.AddWithValue("@TelecommunicationId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@TelecommunicationId", telecommunication.TelecommunicationId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(User user)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[User] (UserId, Name, Description)
                                    VALUES (@UserId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(user.UserId, null)) cmd.Parameters.AddWithValue("@UserId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@UserId", user.UserId);
                
                  
                if (ReferenceEquals(user.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", user.Name);
                
                  
                if (ReferenceEquals(user.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", user.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(User user)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = user.UserId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM User WHERE UserId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(user);
                else return this.Insert(user);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllUsers<T>()
            where T : User, new()
        {
            return this.GetAllUsers<T>(String.Empty);
        }

        
        public List<T> GetAllUsers<T>(String whereClause)
            where T : User, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[User]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T user = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("UserId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          user.UserId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          user.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          user.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(user);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified User
        /// </summary>
        /// <returns></returns>
        public int Update(User user)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[User] SET 
                                    Name = @Name,Description = @Description
                                    WHERE UserId = @UserId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(user.UserId, null)) cmd.Parameters.AddWithValue("@UserId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@UserId", user.UserId);
                 //TEXT
                
                if (ReferenceEquals(user.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", user.Name);
                 //TEXT
                
                if (ReferenceEquals(user.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", user.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified User
        /// </summary>
        /// <returns></returns>
        public int Delete(User user)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[User] 
                                    WHERE UserId = @UserId", this.Schema);
                                    
                
                if (ReferenceEquals(user.UserId, null)) cmd.Parameters.AddWithValue("@UserId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@UserId", user.UserId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Technology technology)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Technology] (TechnologyId, Name, Description)
                                    VALUES (@TechnologyId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(technology.TechnologyId, null)) cmd.Parameters.AddWithValue("@TechnologyId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@TechnologyId", technology.TechnologyId);
                
                  
                if (ReferenceEquals(technology.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", technology.Name);
                
                  
                if (ReferenceEquals(technology.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", technology.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Technology technology)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = technology.TechnologyId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Technology WHERE TechnologyId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(technology);
                else return this.Insert(technology);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllTechnologies<T>()
            where T : Technology, new()
        {
            return this.GetAllTechnologies<T>(String.Empty);
        }

        
        public List<T> GetAllTechnologies<T>(String whereClause)
            where T : Technology, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Technology]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T technology = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("TechnologyId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          technology.TechnologyId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          technology.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          technology.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(technology);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Technology
        /// </summary>
        /// <returns></returns>
        public int Update(Technology technology)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Technology] SET 
                                    Name = @Name,Description = @Description
                                    WHERE TechnologyId = @TechnologyId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(technology.TechnologyId, null)) cmd.Parameters.AddWithValue("@TechnologyId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@TechnologyId", technology.TechnologyId);
                 //TEXT
                
                if (ReferenceEquals(technology.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", technology.Name);
                 //TEXT
                
                if (ReferenceEquals(technology.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", technology.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Technology
        /// </summary>
        /// <returns></returns>
        public int Delete(Technology technology)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Technology] 
                                    WHERE TechnologyId = @TechnologyId", this.Schema);
                                    
                
                if (ReferenceEquals(technology.TechnologyId, null)) cmd.Parameters.AddWithValue("@TechnologyId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@TechnologyId", technology.TechnologyId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Timing timing)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Timing] (TimingId, Name, Description)
                                    VALUES (@TimingId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(timing.TimingId, null)) cmd.Parameters.AddWithValue("@TimingId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@TimingId", timing.TimingId);
                
                  
                if (ReferenceEquals(timing.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", timing.Name);
                
                  
                if (ReferenceEquals(timing.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", timing.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Timing timing)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = timing.TimingId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Timing WHERE TimingId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(timing);
                else return this.Insert(timing);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllTimings<T>()
            where T : Timing, new()
        {
            return this.GetAllTimings<T>(String.Empty);
        }

        
        public List<T> GetAllTimings<T>(String whereClause)
            where T : Timing, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Timing]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T timing = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("TimingId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          timing.TimingId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          timing.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          timing.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(timing);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Timing
        /// </summary>
        /// <returns></returns>
        public int Update(Timing timing)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Timing] SET 
                                    Name = @Name,Description = @Description
                                    WHERE TimingId = @TimingId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(timing.TimingId, null)) cmd.Parameters.AddWithValue("@TimingId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@TimingId", timing.TimingId);
                 //TEXT
                
                if (ReferenceEquals(timing.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", timing.Name);
                 //TEXT
                
                if (ReferenceEquals(timing.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", timing.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Timing
        /// </summary>
        /// <returns></returns>
        public int Delete(Timing timing)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Timing] 
                                    WHERE TimingId = @TimingId", this.Schema);
                                    
                
                if (ReferenceEquals(timing.TimingId, null)) cmd.Parameters.AddWithValue("@TimingId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@TimingId", timing.TimingId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Cablecode cablecode)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Cablecode] (CablecodeId, Name, Description)
                                    VALUES (@CablecodeId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(cablecode.CablecodeId, null)) cmd.Parameters.AddWithValue("@CablecodeId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@CablecodeId", cablecode.CablecodeId);
                
                  
                if (ReferenceEquals(cablecode.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", cablecode.Name);
                
                  
                if (ReferenceEquals(cablecode.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", cablecode.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Cablecode cablecode)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = cablecode.CablecodeId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Cablecode WHERE CablecodeId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(cablecode);
                else return this.Insert(cablecode);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllCablecodes<T>()
            where T : Cablecode, new()
        {
            return this.GetAllCablecodes<T>(String.Empty);
        }

        
        public List<T> GetAllCablecodes<T>(String whereClause)
            where T : Cablecode, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Cablecode]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T cablecode = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("CablecodeId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          cablecode.CablecodeId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          cablecode.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          cablecode.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(cablecode);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Cablecode
        /// </summary>
        /// <returns></returns>
        public int Update(Cablecode cablecode)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Cablecode] SET 
                                    Name = @Name,Description = @Description
                                    WHERE CablecodeId = @CablecodeId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(cablecode.CablecodeId, null)) cmd.Parameters.AddWithValue("@CablecodeId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@CablecodeId", cablecode.CablecodeId);
                 //TEXT
                
                if (ReferenceEquals(cablecode.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", cablecode.Name);
                 //TEXT
                
                if (ReferenceEquals(cablecode.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", cablecode.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Cablecode
        /// </summary>
        /// <returns></returns>
        public int Delete(Cablecode cablecode)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Cablecode] 
                                    WHERE CablecodeId = @CablecodeId", this.Schema);
                                    
                
                if (ReferenceEquals(cablecode.CablecodeId, null)) cmd.Parameters.AddWithValue("@CablecodeId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@CablecodeId", cablecode.CablecodeId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Display display)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Display] (DisplayId, Name, Description)
                                    VALUES (@DisplayId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(display.DisplayId, null)) cmd.Parameters.AddWithValue("@DisplayId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@DisplayId", display.DisplayId);
                
                  
                if (ReferenceEquals(display.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", display.Name);
                
                  
                if (ReferenceEquals(display.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", display.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Display display)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = display.DisplayId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Display WHERE DisplayId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(display);
                else return this.Insert(display);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllDisplaies<T>()
            where T : Display, new()
        {
            return this.GetAllDisplaies<T>(String.Empty);
        }

        
        public List<T> GetAllDisplaies<T>(String whereClause)
            where T : Display, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Display]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T display = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("DisplayId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          display.DisplayId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          display.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          display.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(display);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Display
        /// </summary>
        /// <returns></returns>
        public int Update(Display display)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Display] SET 
                                    Name = @Name,Description = @Description
                                    WHERE DisplayId = @DisplayId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(display.DisplayId, null)) cmd.Parameters.AddWithValue("@DisplayId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@DisplayId", display.DisplayId);
                 //TEXT
                
                if (ReferenceEquals(display.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", display.Name);
                 //TEXT
                
                if (ReferenceEquals(display.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", display.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Display
        /// </summary>
        /// <returns></returns>
        public int Delete(Display display)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Display] 
                                    WHERE DisplayId = @DisplayId", this.Schema);
                                    
                
                if (ReferenceEquals(display.DisplayId, null)) cmd.Parameters.AddWithValue("@DisplayId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@DisplayId", display.DisplayId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Tone tone)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Tone] (ToneId, Name, Description)
                                    VALUES (@ToneId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(tone.ToneId, null)) cmd.Parameters.AddWithValue("@ToneId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@ToneId", tone.ToneId);
                
                  
                if (ReferenceEquals(tone.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", tone.Name);
                
                  
                if (ReferenceEquals(tone.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", tone.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Tone tone)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = tone.ToneId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Tone WHERE ToneId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(tone);
                else return this.Insert(tone);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllTones<T>()
            where T : Tone, new()
        {
            return this.GetAllTones<T>(String.Empty);
        }

        
        public List<T> GetAllTones<T>(String whereClause)
            where T : Tone, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Tone]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T tone = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("ToneId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          tone.ToneId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          tone.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          tone.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(tone);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Tone
        /// </summary>
        /// <returns></returns>
        public int Update(Tone tone)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Tone] SET 
                                    Name = @Name,Description = @Description
                                    WHERE ToneId = @ToneId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(tone.ToneId, null)) cmd.Parameters.AddWithValue("@ToneId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@ToneId", tone.ToneId);
                 //TEXT
                
                if (ReferenceEquals(tone.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", tone.Name);
                 //TEXT
                
                if (ReferenceEquals(tone.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", tone.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Tone
        /// </summary>
        /// <returns></returns>
        public int Delete(Tone tone)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Tone] 
                                    WHERE ToneId = @ToneId", this.Schema);
                                    
                
                if (ReferenceEquals(tone.ToneId, null)) cmd.Parameters.AddWithValue("@ToneId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@ToneId", tone.ToneId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Light light)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Light] (LightId, Name, Description)
                                    VALUES (@LightId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(light.LightId, null)) cmd.Parameters.AddWithValue("@LightId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@LightId", light.LightId);
                
                  
                if (ReferenceEquals(light.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", light.Name);
                
                  
                if (ReferenceEquals(light.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", light.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Light light)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = light.LightId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Light WHERE LightId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(light);
                else return this.Insert(light);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllLights<T>()
            where T : Light, new()
        {
            return this.GetAllLights<T>(String.Empty);
        }

        
        public List<T> GetAllLights<T>(String whereClause)
            where T : Light, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Light]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T light = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("LightId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          light.LightId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          light.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          light.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(light);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Light
        /// </summary>
        /// <returns></returns>
        public int Update(Light light)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Light] SET 
                                    Name = @Name,Description = @Description
                                    WHERE LightId = @LightId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(light.LightId, null)) cmd.Parameters.AddWithValue("@LightId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@LightId", light.LightId);
                 //TEXT
                
                if (ReferenceEquals(light.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", light.Name);
                 //TEXT
                
                if (ReferenceEquals(light.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", light.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Light
        /// </summary>
        /// <returns></returns>
        public int Delete(Light light)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Light] 
                                    WHERE LightId = @LightId", this.Schema);
                                    
                
                if (ReferenceEquals(light.LightId, null)) cmd.Parameters.AddWithValue("@LightId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@LightId", light.LightId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Click click)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Click] (ClickId, Name, Description)
                                    VALUES (@ClickId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(click.ClickId, null)) cmd.Parameters.AddWithValue("@ClickId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@ClickId", click.ClickId);
                
                  
                if (ReferenceEquals(click.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", click.Name);
                
                  
                if (ReferenceEquals(click.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", click.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Click click)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = click.ClickId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Click WHERE ClickId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(click);
                else return this.Insert(click);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllClicks<T>()
            where T : Click, new()
        {
            return this.GetAllClicks<T>(String.Empty);
        }

        
        public List<T> GetAllClicks<T>(String whereClause)
            where T : Click, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Click]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T click = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("ClickId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          click.ClickId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          click.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          click.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(click);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Click
        /// </summary>
        /// <returns></returns>
        public int Update(Click click)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Click] SET 
                                    Name = @Name,Description = @Description
                                    WHERE ClickId = @ClickId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(click.ClickId, null)) cmd.Parameters.AddWithValue("@ClickId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@ClickId", click.ClickId);
                 //TEXT
                
                if (ReferenceEquals(click.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", click.Name);
                 //TEXT
                
                if (ReferenceEquals(click.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", click.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Click
        /// </summary>
        /// <returns></returns>
        public int Delete(Click click)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Click] 
                                    WHERE ClickId = @ClickId", this.Schema);
                                    
                
                if (ReferenceEquals(click.ClickId, null)) cmd.Parameters.AddWithValue("@ClickId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@ClickId", click.ClickId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Signal signal)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Signal] (SignalId, Name, Description)
                                    VALUES (@SignalId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(signal.SignalId, null)) cmd.Parameters.AddWithValue("@SignalId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@SignalId", signal.SignalId);
                
                  
                if (ReferenceEquals(signal.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", signal.Name);
                
                  
                if (ReferenceEquals(signal.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", signal.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Signal signal)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = signal.SignalId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Signal WHERE SignalId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(signal);
                else return this.Insert(signal);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllSignals<T>()
            where T : Signal, new()
        {
            return this.GetAllSignals<T>(String.Empty);
        }

        
        public List<T> GetAllSignals<T>(String whereClause)
            where T : Signal, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Signal]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T signal = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("SignalId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          signal.SignalId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          signal.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          signal.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(signal);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Signal
        /// </summary>
        /// <returns></returns>
        public int Update(Signal signal)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Signal] SET 
                                    Name = @Name,Description = @Description
                                    WHERE SignalId = @SignalId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(signal.SignalId, null)) cmd.Parameters.AddWithValue("@SignalId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@SignalId", signal.SignalId);
                 //TEXT
                
                if (ReferenceEquals(signal.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", signal.Name);
                 //TEXT
                
                if (ReferenceEquals(signal.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", signal.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Signal
        /// </summary>
        /// <returns></returns>
        public int Delete(Signal signal)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Signal] 
                                    WHERE SignalId = @SignalId", this.Schema);
                                    
                
                if (ReferenceEquals(signal.SignalId, null)) cmd.Parameters.AddWithValue("@SignalId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@SignalId", signal.SignalId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Sequence sequence)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Sequence] (SequenceId, Name, Description)
                                    VALUES (@SequenceId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(sequence.SequenceId, null)) cmd.Parameters.AddWithValue("@SequenceId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@SequenceId", sequence.SequenceId);
                
                  
                if (ReferenceEquals(sequence.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", sequence.Name);
                
                  
                if (ReferenceEquals(sequence.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", sequence.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Sequence sequence)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = sequence.SequenceId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Sequence WHERE SequenceId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(sequence);
                else return this.Insert(sequence);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllSequences<T>()
            where T : Sequence, new()
        {
            return this.GetAllSequences<T>(String.Empty);
        }

        
        public List<T> GetAllSequences<T>(String whereClause)
            where T : Sequence, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Sequence]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T sequence = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("SequenceId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          sequence.SequenceId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          sequence.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          sequence.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(sequence);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Sequence
        /// </summary>
        /// <returns></returns>
        public int Update(Sequence sequence)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Sequence] SET 
                                    Name = @Name,Description = @Description
                                    WHERE SequenceId = @SequenceId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(sequence.SequenceId, null)) cmd.Parameters.AddWithValue("@SequenceId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@SequenceId", sequence.SequenceId);
                 //TEXT
                
                if (ReferenceEquals(sequence.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", sequence.Name);
                 //TEXT
                
                if (ReferenceEquals(sequence.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", sequence.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Sequence
        /// </summary>
        /// <returns></returns>
        public int Delete(Sequence sequence)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Sequence] 
                                    WHERE SequenceId = @SequenceId", this.Schema);
                                    
                
                if (ReferenceEquals(sequence.SequenceId, null)) cmd.Parameters.AddWithValue("@SequenceId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@SequenceId", sequence.SequenceId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(TelegraphOperator telegraphOperator)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[TelegraphOperator] (TelegraphOperatorId, Name, Description)
                                    VALUES (@TelegraphOperatorId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(telegraphOperator.TelegraphOperatorId, null)) cmd.Parameters.AddWithValue("@TelegraphOperatorId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@TelegraphOperatorId", telegraphOperator.TelegraphOperatorId);
                
                  
                if (ReferenceEquals(telegraphOperator.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", telegraphOperator.Name);
                
                  
                if (ReferenceEquals(telegraphOperator.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", telegraphOperator.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(TelegraphOperator telegraphOperator)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = telegraphOperator.TelegraphOperatorId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM TelegraphOperator WHERE TelegraphOperatorId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(telegraphOperator);
                else return this.Insert(telegraphOperator);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllTelegraphOperators<T>()
            where T : TelegraphOperator, new()
        {
            return this.GetAllTelegraphOperators<T>(String.Empty);
        }

        
        public List<T> GetAllTelegraphOperators<T>(String whereClause)
            where T : TelegraphOperator, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[TelegraphOperator]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T telegraphOperator = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("TelegraphOperatorId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          telegraphOperator.TelegraphOperatorId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          telegraphOperator.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          telegraphOperator.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(telegraphOperator);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified TelegraphOperator
        /// </summary>
        /// <returns></returns>
        public int Update(TelegraphOperator telegraphOperator)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[TelegraphOperator] SET 
                                    Name = @Name,Description = @Description
                                    WHERE TelegraphOperatorId = @TelegraphOperatorId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(telegraphOperator.TelegraphOperatorId, null)) cmd.Parameters.AddWithValue("@TelegraphOperatorId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@TelegraphOperatorId", telegraphOperator.TelegraphOperatorId);
                 //TEXT
                
                if (ReferenceEquals(telegraphOperator.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", telegraphOperator.Name);
                 //TEXT
                
                if (ReferenceEquals(telegraphOperator.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", telegraphOperator.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified TelegraphOperator
        /// </summary>
        /// <returns></returns>
        public int Delete(TelegraphOperator telegraphOperator)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[TelegraphOperator] 
                                    WHERE TelegraphOperatorId = @TelegraphOperatorId", this.Schema);
                                    
                
                if (ReferenceEquals(telegraphOperator.TelegraphOperatorId, null)) cmd.Parameters.AddWithValue("@TelegraphOperatorId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@TelegraphOperatorId", telegraphOperator.TelegraphOperatorId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Country country)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Country] (CountryId, Name, Description)
                                    VALUES (@CountryId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(country.CountryId, null)) cmd.Parameters.AddWithValue("@CountryId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@CountryId", country.CountryId);
                
                  
                if (ReferenceEquals(country.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", country.Name);
                
                  
                if (ReferenceEquals(country.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", country.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Country country)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = country.CountryId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Country WHERE CountryId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(country);
                else return this.Insert(country);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllCountries<T>()
            where T : Country, new()
        {
            return this.GetAllCountries<T>(String.Empty);
        }

        
        public List<T> GetAllCountries<T>(String whereClause)
            where T : Country, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Country]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T country = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("CountryId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          country.CountryId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          country.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          country.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(country);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Country
        /// </summary>
        /// <returns></returns>
        public int Update(Country country)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Country] SET 
                                    Name = @Name,Description = @Description
                                    WHERE CountryId = @CountryId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(country.CountryId, null)) cmd.Parameters.AddWithValue("@CountryId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@CountryId", country.CountryId);
                 //TEXT
                
                if (ReferenceEquals(country.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", country.Name);
                 //TEXT
                
                if (ReferenceEquals(country.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", country.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Country
        /// </summary>
        /// <returns></returns>
        public int Delete(Country country)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Country] 
                                    WHERE CountryId = @CountryId", this.Schema);
                                    
                
                if (ReferenceEquals(country.CountryId, null)) cmd.Parameters.AddWithValue("@CountryId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@CountryId", country.CountryId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Content content)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Content] (ContentId, Name, Description)
                                    VALUES (@ContentId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(content.ContentId, null)) cmd.Parameters.AddWithValue("@ContentId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@ContentId", content.ContentId);
                
                  
                if (ReferenceEquals(content.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", content.Name);
                
                  
                if (ReferenceEquals(content.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", content.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Content content)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = content.ContentId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Content WHERE ContentId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(content);
                else return this.Insert(content);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllContents<T>()
            where T : Content, new()
        {
            return this.GetAllContents<T>(String.Empty);
        }

        
        public List<T> GetAllContents<T>(String whereClause)
            where T : Content, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Content]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T content = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("ContentId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          content.ContentId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          content.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          content.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(content);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Content
        /// </summary>
        /// <returns></returns>
        public int Update(Content content)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Content] SET 
                                    Name = @Name,Description = @Description
                                    WHERE ContentId = @ContentId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(content.ContentId, null)) cmd.Parameters.AddWithValue("@ContentId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@ContentId", content.ContentId);
                 //TEXT
                
                if (ReferenceEquals(content.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", content.Name);
                 //TEXT
                
                if (ReferenceEquals(content.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", content.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Content
        /// </summary>
        /// <returns></returns>
        public int Delete(Content content)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Content] 
                                    WHERE ContentId = @ContentId", this.Schema);
                                    
                
                if (ReferenceEquals(content.ContentId, null)) cmd.Parameters.AddWithValue("@ContentId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@ContentId", content.ContentId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Variant variant)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Variant] (VariantId, Name, Description)
                                    VALUES (@VariantId, @Name, @Description)", this.Schema);

                
                  
                if (ReferenceEquals(variant.VariantId, null)) cmd.Parameters.AddWithValue("@VariantId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@VariantId", variant.VariantId);
                
                  
                if (ReferenceEquals(variant.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", variant.Name);
                
                  
                if (ReferenceEquals(variant.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", variant.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Variant variant)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = variant.VariantId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM Variant WHERE VariantId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(variant);
                else return this.Insert(variant);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllVariants<T>()
            where T : Variant, new()
        {
            return this.GetAllVariants<T>(String.Empty);
        }

        
        public List<T> GetAllVariants<T>(String whereClause)
            where T : Variant, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Variant]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T variant = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("VariantId");
                      if (!reader.IsDBNull(propertyIndex)) //GUID
                      {
                          
                          variant.VariantId = reader.GetGuid(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          variant.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          variant.Description = reader.GetString(propertyIndex);
                      }
                   
                    results.Add(variant);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Variant
        /// </summary>
        /// <returns></returns>
        public int Update(Variant variant)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Variant] SET 
                                    Name = @Name,Description = @Description
                                    WHERE VariantId = @VariantId", this.Schema);

                 //GUID
                
                if (ReferenceEquals(variant.VariantId, null)) cmd.Parameters.AddWithValue("@VariantId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@VariantId", variant.VariantId);
                 //TEXT
                
                if (ReferenceEquals(variant.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", variant.Name);
                 //TEXT
                
                if (ReferenceEquals(variant.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", variant.Description);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Variant
        /// </summary>
        /// <returns></returns>
        public int Delete(Variant variant)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Variant] 
                                    WHERE VariantId = @VariantId", this.Schema);
                                    
                
                if (ReferenceEquals(variant.VariantId, null)) cmd.Parameters.AddWithValue("@VariantId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@VariantId", variant.VariantId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

                  
            
            

        public object LastIdentity { get; set; }
        public string ExecuteAsUser { get; set; }
        
        private SqlConnection CreateSqlConnection() 
        {
            if (String.IsNullOrEmpty(this.ConnectionString))
            {
                SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
                scsb.DataSource = this.DataSourceName;
                scsb.InitialCatalog = this.DBName;
                scsb.IntegratedSecurity = true;
                this.ConnectionString = scsb.ConnectionString;
            }
            
            SqlDataManager.LastConnectionString = this.ConnectionString;
            
            return new SqlConnection(this.ConnectionString);
        }
        
        
        private void InitializeConnection(SqlConnection conn)
        {
            conn.Open();
            if (!String.IsNullOrEmpty(this.ExecuteAsUser))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = String.Format("EXECUTE AS USER='{0}'", this.ExecuteAsUser);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

      