using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace Csharp_Student_System
{
	class DashboardClass
	{
		MY_DB db = new MY_DB();

		public void deleteGrade7group(string val, string grade)
		{
			if(grade == "Grade 7")
			{
				MySqlCommand command = new MySqlCommand("DELETE FROM `grade7group` WHERE `val` = @val", db.getConnection);
				command.Parameters.Add("@val", MySqlDbType.VarChar).Value = val;
				db.openConnection();
				if (command.ExecuteNonQuery() == 1)
				{
					db.closeConnection();
				}
				else
				{
					db.closeConnection();
				}
			}
			else if (grade == "Grade 8")
			{
				MySqlCommand command = new MySqlCommand("DELETE FROM `grade8group` WHERE `val` = @val", db.getConnection);
				command.Parameters.Add("@val", MySqlDbType.VarChar).Value = val;
				db.openConnection();
				if (command.ExecuteNonQuery() == 1)
				{
					db.closeConnection();
				}
				else
				{
					db.closeConnection();
				}
			}
			else if (grade == "Grade 9")
			{
				MySqlCommand command = new MySqlCommand("DELETE FROM `grade9group` WHERE `val` = @val", db.getConnection);
				command.Parameters.Add("@val", MySqlDbType.VarChar).Value = val;
				db.openConnection();
				if (command.ExecuteNonQuery() == 1)
				{
					db.closeConnection();
				}
				else
				{
					db.closeConnection();
				}
			}
			else if (grade == "Grade 10")
			{
				MySqlCommand command = new MySqlCommand("DELETE FROM `grade10group` WHERE `val` = @val", db.getConnection);
				command.Parameters.Add("@val", MySqlDbType.VarChar).Value = val;
				db.openConnection();
				if (command.ExecuteNonQuery() == 1)
				{
					db.closeConnection();
				}
				else
				{
					db.closeConnection();
				}
			}
		}

		public void insertGrade7group(string value, string grade)
		{
			if(grade == "Grade 7")
			{
				MySqlCommand command = new MySqlCommand("INSERT INTO `grade7group`(`val`) VALUES (@val)", db.getConnection);
				command.Parameters.Add("@val", MySqlDbType.VarChar).Value = value;
				db.openConnection();
				if (command.ExecuteNonQuery() == 1)
				{
					db.closeConnection();
				}
				else
				{
					db.closeConnection();
				}
			}
			else if (grade == "Grade 8")
			{
				MySqlCommand command = new MySqlCommand("INSERT INTO `grade8group`(`val`) VALUES (@val)", db.getConnection);
				command.Parameters.Add("@val", MySqlDbType.VarChar).Value = value;
				db.openConnection();
				if (command.ExecuteNonQuery() == 1)
				{
					db.closeConnection();
				}
				else
				{
					db.closeConnection();
				}
			}
			else if (grade == "Grade 9")
			{
				MySqlCommand command = new MySqlCommand("INSERT INTO `grade9group`(`val`) VALUES (@val)", db.getConnection);
				command.Parameters.Add("@val", MySqlDbType.VarChar).Value = value;
				db.openConnection();
				if (command.ExecuteNonQuery() == 1)
				{
					db.closeConnection();
				}
				else
				{
					db.closeConnection();
				}
			}
			else if (grade == "Grade 10")
			{
				MySqlCommand command = new MySqlCommand("INSERT INTO `grade10group`(`val`) VALUES (@val)", db.getConnection);
				command.Parameters.Add("@val", MySqlDbType.VarChar).Value = value;
				db.openConnection();
				if (command.ExecuteNonQuery() == 1)
				{
					db.closeConnection();
				}
				else
				{
					db.closeConnection();
				}
			}

		}

	}
}
