﻿using KITTING_MST.DataStructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace KITTING_MST
{
    public class SqlOperations
    {
        public static Dictionary<string, LedOracleSpec> Nc12ToOracleSpec()
        {
            Dictionary<string, LedOracleSpec> result = new Dictionary<string, LedOracleSpec>();
            using (SqlConnection conn = new SqlConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Connection.ConnectionString = @"Data Source=MSTMS010;Initial Catalog=ConnectToMSTDB;User Id=mes;Password=mes;";
                    cmd.CommandText = @"SELECT NC12,Opis,CCT,Colective FROM ConnectToMSTDB.dbo.v_Item";
                    conn.Open();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string collective = SafeGetString(rdr, "Colective");
                            string nc12 = SafeGetString(rdr, "NC12");
                            string description = SafeGetString(rdr, "Opis");
                            int cct = SafeGetInt(rdr, "CCT");
                            
                            if (collective == "")
                            {
                                collective = nc12;
                            }

                            

                            if (!result.ContainsKey(nc12))
                            {
                                result.Add(nc12, new LedOracleSpec
                                {
                                    collective = collective,
                                    name = description,
                                    cct = cct,
                                    nc12 = nc12
                                });
                            }
                            else
                            {
                                if (result[nc12].collective == nc12)
                                {
                                    result[nc12].collective = collective;
                                    result[nc12].cct = cct;
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        private static string SafeGetString(SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            return "";
        }

        private static int SafeGetInt(SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);
            if (!reader.IsDBNull(colIndex))
                return reader.GetInt32(colIndex);
            return 0;
        }
    }
}
