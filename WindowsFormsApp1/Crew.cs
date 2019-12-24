using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    class Crew
    {
        Connect conn = new Connect();
        public bool insertCrew(String status, String fatherName,String cmsId, DateTime dob, DateTime doa, DateTime dotc, String initAppoint, String qualify, String Address1, String Address2, Int32 phNo1,Int32 phNo2, String email, String bloodGroup, String vision, Char gradation, String lobby, Int32 proper, String cliCodeName, String remarks )
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `biodata`(`Status`, `FatherName`, `CmsId`, `Dob`, `Doa`, `Dotc`, `InitAppoint`, `Qualify`, `Address1`, `Address2`, `PhNo1`, `PhNo2`, `Email`, `BloodGroup`, `Vision`, `Gradation`, `Lobby`, `Proper`, `CliCodeName`, `Remarks`) VALUES (@stt,@fnm,@cms,@dob,@doa,@dotc,@initApp,@qual,@add1,@add2,@ph1,@ph2,@email,@bgrp,@vis,@grad,@lob,@prop,@cli,@rem)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            //@stt,@fnm,@cms,@dob,@doa,@dotc,@initApp,@qual,@add1,@add2,@ph1,@ph2,@email,@bgrp,@vis,@grad,@lob,@prop,@cli,@rem
            
            command.Parameters.Add("@stt", MySqlDbType.VarChar).Value = status;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fatherName;
            command.Parameters.Add("@cms", MySqlDbType.VarChar).Value = cmsId;
            command.Parameters.Add("@dob", MySqlDbType.DateTime).Value = dob;
            command.Parameters.Add("@doa", MySqlDbType.DateTime).Value = doa;
            command.Parameters.Add("@dotc", MySqlDbType.DateTime).Value = dotc;
            command.Parameters.Add("@initApp", MySqlDbType.VarChar).Value = initAppoint;
            command.Parameters.Add("@qual", MySqlDbType.VarChar).Value = qualify;
            command.Parameters.Add("@add1", MySqlDbType.VarChar).Value = Address1;
            command.Parameters.Add("@add2", MySqlDbType.VarChar).Value = Address2;
            command.Parameters.Add("@ph1", MySqlDbType.Int32).Value = phNo1;
            command.Parameters.Add("@ph2", MySqlDbType.Int32).Value = phNo2;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@bgrp", MySqlDbType.VarChar).Value = bloodGroup;
            command.Parameters.Add("@vis", MySqlDbType.VarChar).Value = vision;
            command.Parameters.Add("@grad", MySqlDbType.VarChar).Value = gradation;
            command.Parameters.Add("@lob", MySqlDbType.VarChar).Value = lobby;
            command.Parameters.Add("@prop", MySqlDbType.Int32).Value = proper;
            command.Parameters.Add("@cli", MySqlDbType.VarChar).Value = cliCodeName;
            command.Parameters.Add("@rem", MySqlDbType.VarChar).Value = remarks;

            conn.openConn();

            if(command.ExecuteNonQuery() == 1)
            {
                conn.closeConn();
                return true;
            }
            else
            {
                conn.closeConn();
                return false;

            }

     
        }
        public Int32 initCrew()
        {
            MySqlCommand command = new MySqlCommand("SELECT `auto_increment` FROM INFORMATION_SCHEMA.TABLES WHERE table_name = 'biodata'",conn.GetConnection());
            conn.openConn();
            Int32 res = Convert.ToInt32( command.ExecuteScalar() );
            conn.closeConn();

            return res;
        }

        public DataRow searchcrew(Int32 crewid)
        {
           
            MySqlCommand command = new MySqlCommand("SELECT * FROM biodata where CrewId = @cid", conn.GetConnection());
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = crewid;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                DataRow result = table.Rows[0];
                return result;
            }
            else
                return null;
        }
    }
}
