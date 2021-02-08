using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Student_System
{
	class MainCharts
	{
		MY_DB db = new MY_DB();

		public int GetElementary()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `elementary` ", db.getConnection);
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetJuniorHigh()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `juniorhigh` ", db.getConnection);
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetSeniorHigh()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `seniorhigh` ", db.getConnection);
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetCollege()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `college` ", db.getConnection);
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetMaster()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `masteral` ", db.getConnection);
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetGrade1()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `elementary` WHERE `grade` = @grade", db.getConnection);
			command.Parameters.Add("@grade", MySqlDbType.VarChar).Value = "Grade 1";
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetGrade2()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `elementary` WHERE `grade` = @grade", db.getConnection);
			command.Parameters.Add("@grade", MySqlDbType.VarChar).Value = "Grade 2";
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetGrade3()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `elementary` WHERE `grade` = @grade", db.getConnection);
			command.Parameters.Add("@grade", MySqlDbType.VarChar).Value = "Grade 3";
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetGrade4()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `elementary` WHERE `grade` = @grade", db.getConnection);
			command.Parameters.Add("@grade", MySqlDbType.VarChar).Value = "Grade 4";
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetGrade5()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `elementary` WHERE `grade` = @grade", db.getConnection);
			command.Parameters.Add("@grade", MySqlDbType.VarChar).Value = "Grade 5";
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetGrade6()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `elementary` WHERE `grade` = @grade", db.getConnection);
			command.Parameters.Add("@grade", MySqlDbType.VarChar).Value = "Grade 6";
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetGrade7()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `juniorhigh` WHERE `grade` = @grade", db.getConnection);
			command.Parameters.Add("@grade", MySqlDbType.VarChar).Value = "Grade 7";
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetGrade8()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `juniorhigh` WHERE `grade` = @grade", db.getConnection);
			command.Parameters.Add("@grade", MySqlDbType.VarChar).Value = "Grade 8";
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetGrade9()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `juniorhigh` WHERE `grade` = @grade", db.getConnection);
			command.Parameters.Add("@grade", MySqlDbType.VarChar).Value = "Grade 9";
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetGrade10()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `juniorhigh` WHERE `grade` = @grade", db.getConnection);
			command.Parameters.Add("@grade", MySqlDbType.VarChar).Value = "Grade 10";
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetGrade11()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `seniorhigh` WHERE `grade` = @grade", db.getConnection);
			command.Parameters.Add("@grade", MySqlDbType.VarChar).Value = "Grade 11";
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetGrade12()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `seniorhigh` WHERE `grade` = @grade", db.getConnection);
			command.Parameters.Add("@grade", MySqlDbType.VarChar).Value = "Grade 12";
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetCollege1()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `college` WHERE `year` = @year", db.getConnection);
			command.Parameters.Add("@year", MySqlDbType.VarChar).Value = "I";
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetCollege2()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `college` WHERE `year` = @year", db.getConnection);
			command.Parameters.Add("@year", MySqlDbType.VarChar).Value = "II";
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetCollege3()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `college` WHERE `year` = @year", db.getConnection);
			command.Parameters.Add("@year", MySqlDbType.VarChar).Value = "III";
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetCollege4()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `college` WHERE `year` = @year", db.getConnection);
			command.Parameters.Add("@year", MySqlDbType.VarChar).Value = "IV";
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetPsychology()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `masteral` WHERE `course` = @course", db.getConnection);
			command.Parameters.Add("@course", MySqlDbType.VarChar).Value = "Psychology";
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}

		public int GetEducationalManagement()
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `masteral` WHERE `course` = @course", db.getConnection);
			command.Parameters.Add("@course", MySqlDbType.VarChar).Value = "Educational Management";
			adapter.SelectCommand = command;
			adapter.Fill(table);

			int total = table.Rows.Count;
			return total;
		}
	}
}
