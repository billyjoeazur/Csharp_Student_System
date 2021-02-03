using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Csharp_Student_System
{
	class STUDENT
	{
		MY_DB db = new MY_DB();

		//function to return a table of students data
		public DataTable getStudents(MySqlCommand command)
		{
			command.Connection = db.getConnection;
			MySqlDataAdapter adapter = new MySqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);

			return table;
		}

		//-------------------MASTERAL-------------------MASTERAL-------------------MASTERAL-------------------MASTERAL-------------------MASTERAL-------------------MASTERAL-------------------MASTERAL-------------------MASTERAL-------------------

		//function to add new college student to college table
		public bool insertMasteral(string id, string fname, string mname, string lname, string gender, string course, string sy, string guardian, string contact, string address, MemoryStream picture, DateTime inputdate, MemoryStream barcode)
		{
			MySqlCommand command = new MySqlCommand("INSERT INTO `masteral`(`idno`, `fname`, `mname`, `lname`, `gender`, `course`, `sy`, `guardian`, `contact`, `address`, `picture`, `inputdate`, `barcode`) VALUES (@ID,@fn,@mn,@ln,@gdr,@crs,@sy,@gdn,@con,@addr,@pic,@inpdt,@bc)", db.getConnection);

			//@idno,@fn,@mn,@ln,@gdr,@crs,@yr,@sy,@gdn,@addr,@con,@pic
			command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
			command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
			command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname;
			command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
			command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
			command.Parameters.Add("@crs", MySqlDbType.VarChar).Value = course;
			command.Parameters.Add("@sy", MySqlDbType.VarChar).Value = sy;
			command.Parameters.Add("@gdn", MySqlDbType.VarChar).Value = guardian;
			command.Parameters.Add("@con", MySqlDbType.VarChar).Value = contact;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray();
			command.Parameters.Add("@inpdt", MySqlDbType.DateTime).Value = inputdate;
			command.Parameters.Add("@bc", MySqlDbType.Blob).Value = barcode.ToArray();

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}

		//create a function to update masteral table
		public bool updateMasteral(string id, string fname, string mname, string lname, string gender, string course, string sy, string guardian, string contact, string address, MemoryStream pic)
		{
			MySqlCommand command = new MySqlCommand("UPDATE `masteral` SET `fname`=@fn,`mname`=@mn,`lname`=@ln,`gender`=@gdr,`course`=@crs,`sy`=@sy,`guardian`=@gdn,`contact`=@con,`address`=@addr,`picture`=@pic WHERE `idno`=@ID", db.getConnection);

			//@ID,@fn,@mn,@ln,@gdr,@crs,@yr,@sy,@gdn,@addr,@con,@pic
			command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
			command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
			command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname;
			command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
			command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
			command.Parameters.Add("@crs", MySqlDbType.VarChar).Value = course;
			command.Parameters.Add("@sy", MySqlDbType.VarChar).Value = sy;
			command.Parameters.Add("@gdn", MySqlDbType.VarChar).Value = guardian;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@con", MySqlDbType.VarChar).Value = contact;
			command.Parameters.Add("@pic", MySqlDbType.Blob).Value = pic.ToArray();

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}

		//function to delete the selected masteral student
		public bool deleteMasteral(string id)
		{
			MySqlCommand command = new MySqlCommand("DELETE FROM `masteral` WHERE `idno`=" + id, db.getConnection);

			command.Parameters.Add("@idno", MySqlDbType.VarChar).Value = id;

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}


		//checking of data in masteral table if the id number is already in use
		public bool valMasteral(string id)
		{
			MySqlCommand command;
			MySqlDataReader mdr;
			db.openConnection();

			string selectQuery = ("SELECT * FROM `masteral` WHERE `idno`=" + id);
			command = new MySqlCommand(selectQuery, db.getConnection);

			mdr = command.ExecuteReader();

			if (mdr.Read())
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}

		//adding the masteral student to the printmasteral table
		public bool insertPrintMASTER(string id, string fullN, string course, string sy, string guardian, string contact, string address, MemoryStream picture, MemoryStream barcode)
		{
			MySqlCommand command = new MySqlCommand("INSERT INTO `printmasteral`(`idno`, `fullname`, `course`, `sy`, `guardian`, `contact`, `address`, `picture`, `barcode`) VALUES (@ID,@fullname,@crs,@sy,@guard,@cnt,@addr,@pic,@bc)", db.getConnection);

			//@idno,@fn,@mn,@ln,@gdr,@crs,@sy,@gdn,@addr,@con,@pic
			command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
			command.Parameters.Add("@fullname", MySqlDbType.VarChar).Value = fullN;
			command.Parameters.Add("@crs", MySqlDbType.VarChar).Value = course;
			command.Parameters.Add("@sy", MySqlDbType.VarChar).Value = sy;
			command.Parameters.Add("@guard", MySqlDbType.VarChar).Value = guardian;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = contact;
			command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray();
			command.Parameters.Add("@bc", MySqlDbType.Blob).Value = barcode.ToArray();

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}


		//checking of data in printmasteral table if the id number is already in use
		public bool valMASTERPrint(string id)
		{
			MySqlCommand command;
			MySqlDataReader mdr;
			db.openConnection();

			string selectQuery = ("SELECT * FROM `printmasteral` WHERE `idno`=" + id);
			command = new MySqlCommand(selectQuery, db.getConnection);

			mdr = command.ExecuteReader();


			if (mdr.Read())
			{
				db.closeConnection();
				return true;

			}
			else
			{
				db.closeConnection();
				return false;
			}

		}

		//-------------------COLLEGE-------------------COLLEGE-------------------COLLEGE-------------------COLLEGE-------------------COLLEGE-------------------COLLEGE-------------------COLLEGE-------------------COLLEGE-------------------

		//function to add new college student to college table
		public bool insertStudent(string id, string fname, string mname, string lname, string gender, string course, string year, string sy, string guardian, string address, string contact, MemoryStream picture, DateTime inputdate, MemoryStream barcode)
		{
			MySqlCommand command = new MySqlCommand("INSERT INTO `college`(`idno`, `fname`, `mname`, `lname`, `gender`, `course`, `year`, `sy`, `guardian`, `address`, `contact`, `picture`, `inputdate`, `barcode`) VALUES (@ID,@fn,@mn,@ln,@gdr,@crs,@yr,@sy,@gdn,@addr,@con,@pic,@inpdt,@bc)", db.getConnection);

			//@idno,@fn,@mn,@ln,@gdr,@crs,@yr,@sy,@gdn,@addr,@con,@pic
			command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
			command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
			command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname;
			command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
			command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
			command.Parameters.Add("@crs", MySqlDbType.VarChar).Value = course;
			command.Parameters.Add("@yr", MySqlDbType.VarChar).Value = year;
			command.Parameters.Add("@sy", MySqlDbType.VarChar).Value = sy;
			command.Parameters.Add("@gdn", MySqlDbType.VarChar).Value = guardian;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@con", MySqlDbType.VarChar).Value = contact;
			command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray();
			command.Parameters.Add("@inpdt", MySqlDbType.DateTime).Value = inputdate;
			command.Parameters.Add("@bc", MySqlDbType.Blob).Value = barcode.ToArray();

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}


		//create a function to update college table
		public bool updateStudent(string id, string fname, string mname, string lname, string gender, string course, string year, string sy, string guardian, string address, string contact, MemoryStream pic)
		{
			MySqlCommand command = new MySqlCommand("UPDATE `college` SET `fname`=@fn,`mname`=@mn,`lname`=@ln,`gender`=@gdr,`course`=@crs,`year`=@yr,`sy`=@sy,`guardian`=@gdn,`address`=@addr,`contact`=@con,`picture`=@pic WHERE `idno`=@ID", db.getConnection);

			//@ID,@fn,@mn,@ln,@gdr,@crs,@yr,@sy,@gdn,@addr,@con,@pic
			command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
			command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
			command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname;
			command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
			command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
			command.Parameters.Add("@crs", MySqlDbType.VarChar).Value = course;
			command.Parameters.Add("@yr", MySqlDbType.VarChar).Value = year;
			command.Parameters.Add("@sy", MySqlDbType.VarChar).Value = sy;
			command.Parameters.Add("@gdn", MySqlDbType.VarChar).Value = guardian;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@con", MySqlDbType.VarChar).Value = contact;
			command.Parameters.Add("@pic", MySqlDbType.Blob).Value = pic.ToArray();

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}


		//function to delete the selected college student
		public bool deleteStudent(string id)
		{
			MySqlCommand command = new MySqlCommand("DELETE FROM `college` WHERE `idno`=" + id, db.getConnection);

			command.Parameters.Add("@idno", MySqlDbType.VarChar).Value = id;

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}


		//checking of data in college table if the id number is already in use
		public bool valStudent(string id)
		{
			MySqlCommand command;
			MySqlDataReader mdr;
			db.openConnection();

			string selectQuery = ("SELECT * FROM `college` WHERE `idno`=" + id);
			command = new MySqlCommand(selectQuery, db.getConnection);

			mdr = command.ExecuteReader();

			if (mdr.Read())
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}


		//adding the college student to the printcollege table
		public bool insertPrintList(string id, string fullN, string course, string year, string sy, string guardian, string address, string contact, MemoryStream picture, MemoryStream barcode)
		{
			MySqlCommand command = new MySqlCommand("INSERT INTO `printcollege`(`idno`, `fullname`, `courseyear`, `sy`, `guardian`, `address`, `contact`, `picture`,`barcode`) VALUES (@ID,@fullname,@cy,@sy,@guard,@addr,@cnt,@pic,@bc)", db.getConnection);

			//@idno,@fn,@mn,@ln,@gdr,@crs,@yr,@sy,@gdn,@addr,@con,@pic
			command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
			command.Parameters.Add("@fullname", MySqlDbType.VarChar).Value = fullN;
			command.Parameters.Add("@cy", MySqlDbType.VarChar).Value = course + " - " + year;
			command.Parameters.Add("@sy", MySqlDbType.VarChar).Value = sy;
			command.Parameters.Add("@guard", MySqlDbType.VarChar).Value = guardian;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = contact;
			command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray();
			command.Parameters.Add("@bc", MySqlDbType.Blob).Value = barcode.ToArray();

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}


		//checking of data in printcollege table if the id number is already in use
		public bool valStudentPrint(string id)
		{
			MySqlCommand command;
			MySqlDataReader mdr;
			db.openConnection();

			string selectQuery = ("SELECT * FROM `printcollege` WHERE `idno`=" + id);
			command = new MySqlCommand(selectQuery, db.getConnection);

			mdr = command.ExecuteReader();


			if (mdr.Read())
			{
				db.closeConnection();
				return true;

			}
			else
			{
				db.closeConnection();
				return false;
			}

		}

		//-------------------SENIORHIGH-------------------SENIORHIGH-------------------SENIORHIGH-------------------SENIORHIGH-------------------SENIORHIGH-------------------SENIORHIGH-------------------SENIORHIGH-------------------SENIORHIGH-------------------

		//function to add new senior high student to the seniorhigh table
		public bool insertSeniorHigh(string lrn, string esc, string fname, string mname, string lname, string gender, string grade, string group, string sy, string guardian, string contact, string address, MemoryStream picture, DateTime inputdate, MemoryStream barcode)
		{
			MySqlCommand command = new MySqlCommand("INSERT INTO `seniorhigh`(`lrn`, `esc`, `fname`, `mname`, `lname`, `gender`, `grade`, `grp`, `sy`, `guardian`, `contact`, `address`, `picture`, `inputdate`, `barcode`) VALUES (@lrn,@esc,@fn,@mn,@ln,@gdr,@grd,@grp,@sy,@gdn,@con,@addr,@pic,@inpdt,@bc)", db.getConnection);

			//@lrn,@esc,@fn,@mn,@ln,@gdr,@grd,@grp,@sy,@gdn,@con,@addr,@pic
			command.Parameters.Add("@lrn", MySqlDbType.VarChar).Value = lrn;
			command.Parameters.Add("@esc", MySqlDbType.VarChar).Value = esc;
			command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
			command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname;
			command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
			command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
			command.Parameters.Add("@grd", MySqlDbType.VarChar).Value = grade;
			command.Parameters.Add("@grp", MySqlDbType.VarChar).Value = group;
			command.Parameters.Add("@sy", MySqlDbType.VarChar).Value = sy;
			command.Parameters.Add("@gdn", MySqlDbType.VarChar).Value = guardian;
			command.Parameters.Add("@con", MySqlDbType.VarChar).Value = contact;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray();
			command.Parameters.Add("@inpdt", MySqlDbType.DateTime).Value = inputdate;
			command.Parameters.Add("@bc", MySqlDbType.Blob).Value = barcode.ToArray();

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}


		//checking of data in seniorhigh table if the lrn number is already in use
		public bool valSeniorHigh(string lrn)
		{
			MySqlCommand command;
			MySqlDataReader mdr;
			db.openConnection();

			string selectQuery = ("SELECT * FROM `seniorhigh` WHERE `lrn`=" + lrn);
			command = new MySqlCommand(selectQuery, db.getConnection);

			mdr = command.ExecuteReader();

			if (mdr.Read())
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}


		//adding the student to the printseniorhigh table
		public bool insertPrintSHS(string lrn, string esc, string fullN, string gradegroup, string sy, string guardian, string contact, string address, MemoryStream picture, MemoryStream barcode)
		{
			MySqlCommand command = new MySqlCommand("INSERT INTO `printseniorhigh`(`lrn`, `esc`, `fullname`, `gradegroup`, `sy`, `guardian`, `contact`, `address`, `picture`, `barcode`) VALUES (@lrn,@esc,@fullname,@grdgrp,@sy,@guard,@cnt,@addr,@pic,@bc)", db.getConnection);

			//@lrn,@esc,@fullname,@grdgrp,@sy,@guard,@cnt,@addr,@pic
			command.Parameters.Add("@lrn", MySqlDbType.VarChar).Value = lrn;
			command.Parameters.Add("@esc", MySqlDbType.VarChar).Value = esc;
			command.Parameters.Add("@fullname", MySqlDbType.VarChar).Value = fullN;
			command.Parameters.Add("@grdgrp", MySqlDbType.VarChar).Value = gradegroup;
			command.Parameters.Add("@sy", MySqlDbType.VarChar).Value = sy;
			command.Parameters.Add("@guard", MySqlDbType.VarChar).Value = guardian;
			command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = contact;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray();
			command.Parameters.Add("@bc", MySqlDbType.Blob).Value = barcode.ToArray();

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}


		//update seniorhigh table
		public bool updateSHS(string lrn, string esc, string fname, string mname, string lname, string gender, string grade, string group, string sy, string guardian, string contact, string address, MemoryStream pic)
		{
			MySqlCommand command = new MySqlCommand("UPDATE `seniorhigh` SET `lrn`=@lrn,`esc`=@esc,`fname`=@fn,`mname`=@mn,`lname`=@ln,`gender`=@gdr,`grade`=@grd,`grp`=@grp,`sy`=@sy,`guardian`=@gdn,`contact`=@con,`address`=@addr,`picture`=@pic WHERE `lrn`=@lrn", db.getConnection);

			//@lrn,@esc,@fn,@mn,@ln,@gdr,@grd,@grp,@sy,@gdn,@con,@addr,@pic
			command.Parameters.Add("@lrn", MySqlDbType.VarChar).Value = lrn;
			command.Parameters.Add("@esc", MySqlDbType.VarChar).Value = esc;
			command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
			command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname;
			command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
			command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
			command.Parameters.Add("@grd", MySqlDbType.VarChar).Value = grade;
			command.Parameters.Add("@grp", MySqlDbType.VarChar).Value = group;
			command.Parameters.Add("@sy", MySqlDbType.VarChar).Value = sy;
			command.Parameters.Add("@gdn", MySqlDbType.VarChar).Value = guardian;
			command.Parameters.Add("@con", MySqlDbType.VarChar).Value = contact;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@pic", MySqlDbType.Blob).Value = pic.ToArray();

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}

		//function to delete the selected seniorhigh student
		public bool deleteSHS(string lrn)
		{
			MySqlCommand command = new MySqlCommand("DELETE FROM `seniorhigh` WHERE `lrn`=" + lrn, db.getConnection);

			command.Parameters.Add("@lrn", MySqlDbType.VarChar).Value = lrn;

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}


		//checking of data in printseniorhigh table if the id number is already in use
		public bool valSHSPrint(string lrn)
		{
			MySqlCommand command;
			MySqlDataReader mdr;
			db.openConnection();

			string selectQuery = ("SELECT * FROM `printseniorhigh` WHERE `lrn`=" + lrn);
			command = new MySqlCommand(selectQuery, db.getConnection);

			mdr = command.ExecuteReader();

			if (mdr.Read())
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}

		//-------------------JUNIORHIGH-------------------JUNIORHIGH-------------------JUNIORHIGH-------------------JUNIORHIGH-------------------JUNIORHIGH-------------------JUNIORHIGH-------------------JUNIORHIGH-------------------JUNIORHIGH-------------------

		//function to add new Junior High student to the juniorhigh table
		public bool insertJuniorHigh(string lrn, string esc, string fname, string mname, string lname, string gender, string grade, string group, string sy, string guardian, string contact, string address, MemoryStream picture, DateTime inputdate, MemoryStream barcode)
		{
			MySqlCommand command = new MySqlCommand("INSERT INTO `juniorhigh`(`lrn`, `esc`, `fname`, `mname`, `lname`, `gender`, `grade`, `grp`, `sy`, `guardian`, `contact`, `address`, `picture`, `inputdate`,`barcode`) VALUES (@lrn,@esc,@fn,@mn,@ln,@gdr,@grd,@grp,@sy,@gdn,@con,@addr,@pic,@inpdt,@bc)", db.getConnection);

			//@lrn,@esc,@fn,@mn,@ln,@gdr,@grd,@grp,@sy,@gdn,@con,@addr,@pic
			command.Parameters.Add("@lrn", MySqlDbType.VarChar).Value = lrn;
			command.Parameters.Add("@esc", MySqlDbType.VarChar).Value = esc;
			command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
			command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname;
			command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
			command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
			command.Parameters.Add("@grd", MySqlDbType.VarChar).Value = grade;
			command.Parameters.Add("@grp", MySqlDbType.VarChar).Value = group;
			command.Parameters.Add("@sy", MySqlDbType.VarChar).Value = sy;
			command.Parameters.Add("@gdn", MySqlDbType.VarChar).Value = guardian;
			command.Parameters.Add("@con", MySqlDbType.VarChar).Value = contact;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray();
			command.Parameters.Add("@inpdt", MySqlDbType.DateTime).Value = inputdate;
			command.Parameters.Add("@bc", MySqlDbType.Blob).Value = barcode.ToArray();

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}


		//checking of data in juniorhigh table if the lrn number is already in use
		public bool valJuniorHigh(string lrn)
		{
			MySqlCommand command;
			MySqlDataReader mdr;
			db.openConnection();

			string selectQuery = ("SELECT * FROM `juniorhigh` WHERE `lrn`=" + lrn);
			command = new MySqlCommand(selectQuery, db.getConnection);

			mdr = command.ExecuteReader();

			if (mdr.Read())
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}

		//update seniorhigh table
		public bool updateJHS(string lrn, string esc, string fname, string mname, string lname, string gender, string grade, string group, string sy, string guardian, string contact, string address, MemoryStream pic)
		{
			MySqlCommand command = new MySqlCommand("UPDATE `juniorhigh` SET `lrn`=@lrn,`esc`=@esc,`fname`=@fn,`mname`=@mn,`lname`=@ln,`gender`=@gdr,`grade`=@grd,`grp`=@grp,`sy`=@sy,`guardian`=@gdn,`contact`=@con,`address`=@addr,`picture`=@pic WHERE `lrn`=@lrn", db.getConnection);

			//@lrn,@esc,@fn,@mn,@ln,@gdr,@grd,@grp,@sy,@gdn,@con,@addr,@pic
			command.Parameters.Add("@lrn", MySqlDbType.VarChar).Value = lrn;
			command.Parameters.Add("@esc", MySqlDbType.VarChar).Value = esc;
			command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
			command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname;
			command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
			command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
			command.Parameters.Add("@grd", MySqlDbType.VarChar).Value = grade;
			command.Parameters.Add("@grp", MySqlDbType.VarChar).Value = group;
			command.Parameters.Add("@sy", MySqlDbType.VarChar).Value = sy;
			command.Parameters.Add("@gdn", MySqlDbType.VarChar).Value = guardian;
			command.Parameters.Add("@con", MySqlDbType.VarChar).Value = contact;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@pic", MySqlDbType.Blob).Value = pic.ToArray();

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}

		//function to delete the selected juniorhigh student
		public bool deleteJHS(string lrn)
		{
			MySqlCommand command = new MySqlCommand("DELETE FROM `juniorhigh` WHERE `lrn`=" + lrn, db.getConnection);

			command.Parameters.Add("@lrn", MySqlDbType.VarChar).Value = lrn;

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}


		//checking of data in printseniorhigh table if the id number is already in use
		public bool valJHSPrint(string lrn)
		{
			MySqlCommand command;
			MySqlDataReader mdr;
			db.openConnection();

			string selectQuery = ("SELECT * FROM `printjuniorhigh` WHERE `lrn`=" + lrn);
			command = new MySqlCommand(selectQuery, db.getConnection);

			mdr = command.ExecuteReader();

			if (mdr.Read())
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}


		//adding the student to the printseniorhigh table
		public bool insertPrintJHS(string lrn, string esc, string fullN, string gradegroup, string sy, string guardian, string contact, string address, MemoryStream picture, MemoryStream barcode)
		{
			MySqlCommand command = new MySqlCommand("INSERT INTO `printjuniorhigh`(`lrn`, `esc`, `fullname`, `gradegroup`, `sy`, `guardian`, `contact`, `address`, `picture`, `barcode`) VALUES (@lrn,@esc,@fullname,@grdgrp,@sy,@guard,@cnt,@addr,@pic,@bc)", db.getConnection);

			//@lrn,@esc,@fullname,@grdgrp,@sy,@guard,@cnt,@addr,@pic
			command.Parameters.Add("@lrn", MySqlDbType.VarChar).Value = lrn;
			command.Parameters.Add("@esc", MySqlDbType.VarChar).Value = esc;
			command.Parameters.Add("@fullname", MySqlDbType.VarChar).Value = fullN;
			command.Parameters.Add("@grdgrp", MySqlDbType.VarChar).Value = gradegroup;
			command.Parameters.Add("@sy", MySqlDbType.VarChar).Value = sy;
			command.Parameters.Add("@guard", MySqlDbType.VarChar).Value = guardian;
			command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = contact;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray();
			command.Parameters.Add("@bc", MySqlDbType.Blob).Value = barcode.ToArray();

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}

		//-------------------ELEMENTARY-------------------ELEMENTARY-------------------ELEMENTARY-------------------ELEMENTARY-------------------ELEMENTARY-------------------ELEMENTARY-------------------ELEMENTARY-------------------ELEMENTARY-------------------

		//function to add new elementary student to the elementary table
		public bool insertElementary(string lrn, string esc, string fname, string mname, string lname, string gender, string grade, string sy, string guardian, string contact, string address, MemoryStream picture, DateTime inputdate, MemoryStream barcoder)
		{
			MySqlCommand command = new MySqlCommand("INSERT INTO `elementary`(`lrn`, `esc`, `fname`, `mname`, `lname`, `gender`, `grade`, `sy`, `guardian`, `contact`, `address`, `picture`, `inputdate`, `barcode`) VALUES (@lrn,@esc,@fn,@mn,@ln,@gdr,@grd,@sy,@gdn,@con,@addr,@pic,@inpdt,@bc)", db.getConnection);

			//@lrn,@fn,@mn,@ln,@gdr,@grd,@sy,@gdn,@con,@addr,@pic
			command.Parameters.Add("@lrn", MySqlDbType.VarChar).Value = lrn;
			command.Parameters.Add("@esc", MySqlDbType.VarChar).Value = esc;
			command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
			command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname;
			command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
			command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
			command.Parameters.Add("@grd", MySqlDbType.VarChar).Value = grade;
			command.Parameters.Add("@sy", MySqlDbType.VarChar).Value = sy;
			command.Parameters.Add("@gdn", MySqlDbType.VarChar).Value = guardian;
			command.Parameters.Add("@con", MySqlDbType.VarChar).Value = contact;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray();
			command.Parameters.Add("@inpdt", MySqlDbType.DateTime).Value = inputdate;
			command.Parameters.Add("@bc", MySqlDbType.Blob).Value = barcoder.ToArray();

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}


		//checking of data in elementary table if the lrn number is already in use
		public bool valElementary(string lrn)
		{
			MySqlCommand command;
			MySqlDataReader mdr;
			db.openConnection();

			string selectQuery = ("SELECT * FROM `elementary` WHERE `lrn`=" + lrn);
			command = new MySqlCommand(selectQuery, db.getConnection);

			mdr = command.ExecuteReader();

			if (mdr.Read())
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}

		//update elementary table
		public bool updateELEM(string lrn, string esc, string fname, string mname, string lname, string gender, string grade, string sy, string guardian, string contact, string address, MemoryStream pic)
		{
			MySqlCommand command = new MySqlCommand("UPDATE `elementary` SET `lrn`=@lrn,`esc`=@esc,`fname`=@fn,`mname`=@mn,`lname`=@ln,`gender`=@gdr,`grade`=@grd,`sy`=@sy,`guardian`=@gdn,`contact`=@con,`address`=@addr,`picture`=@pic WHERE `lrn`=@lrn", db.getConnection);

			//@lrn,@esc,@fn,@mn,@ln,@gdr,@grd,@grp,@sy,@gdn,@con,@addr,@pic
			command.Parameters.Add("@lrn", MySqlDbType.VarChar).Value = lrn;
			command.Parameters.Add("@esc", MySqlDbType.VarChar).Value = esc;
			command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
			command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname;
			command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
			command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
			command.Parameters.Add("@grd", MySqlDbType.VarChar).Value = grade;
			command.Parameters.Add("@sy", MySqlDbType.VarChar).Value = sy;
			command.Parameters.Add("@gdn", MySqlDbType.VarChar).Value = guardian;
			command.Parameters.Add("@con", MySqlDbType.VarChar).Value = contact;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@pic", MySqlDbType.Blob).Value = pic.ToArray();

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}

		//function to delete the selected elementary student
		public bool deleteELEM(string lrn)
		{
			MySqlCommand command = new MySqlCommand("DELETE FROM `elementary` WHERE `lrn`=" + lrn, db.getConnection);

			command.Parameters.Add("@lrn", MySqlDbType.VarChar).Value = lrn;

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}

		//adding the student to the printelementary table
		public bool insertPrintELEM(string lrn, string esc, string fullN, string grade, string sy, string guardian, string contact, string address, MemoryStream picture, MemoryStream barcode)
		{
			MySqlCommand command = new MySqlCommand("INSERT INTO `printelementary`(`lrn`, `esc`, `fullname`, `grade`, `sy`, `guardian`, `contact`, `address`, `picture`, `barcode`) VALUES (@lrn,@esc,@fullname,@grd,@sy,@guard,@cnt,@addr,@pic,@bc)", db.getConnection);

			//@lrn,@fullname,@grd,@sy,@guard,@cnt,@addr,@pic
			command.Parameters.Add("@lrn", MySqlDbType.VarChar).Value = lrn;
			command.Parameters.Add("@esc", MySqlDbType.VarChar).Value = esc;
			command.Parameters.Add("@fullname", MySqlDbType.VarChar).Value = fullN;
			command.Parameters.Add("@grd", MySqlDbType.VarChar).Value = grade;
			command.Parameters.Add("@sy", MySqlDbType.VarChar).Value = sy;
			command.Parameters.Add("@guard", MySqlDbType.VarChar).Value = guardian;
			command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = contact;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray();
			command.Parameters.Add("@bc", MySqlDbType.Blob).Value = barcode.ToArray();

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}

		//checking of data in printelementary table if the id number is already in use
		public bool valELEMPrint(string lrn)
		{
			MySqlCommand command;
			MySqlDataReader mdr;
			db.openConnection();

			string selectQuery = ("SELECT * FROM `printelementary` WHERE `lrn`=" + lrn);
			command = new MySqlCommand(selectQuery, db.getConnection);

			mdr = command.ExecuteReader();

			if (mdr.Read())
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}


		//function to add new account to users table
		public bool insertUser(string user, string pass, string level)
		{
			MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`username`, `password`, `userlevel`) VALUES (@un,@pw,@ul)", db.getConnection);

			//@idno,@fn,@mn,@ln,@gdr,@crs,@yr,@sy,@gdn,@addr,@con,@pic
			command.Parameters.Add("@un", MySqlDbType.VarChar).Value = user;
			command.Parameters.Add("@pw", MySqlDbType.VarChar).Value = pass;
			command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = level;

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}


		//-----------------------EPLOYEE---------------------------

		//function to add new employee to the employee table
		public bool insertEmployee(string idno, MemoryStream qrcode, MemoryStream picture, string fname, string mname, string lname, string designation, string contactperson, string contactnumber, string address, DateTime bdate, string tin, string sss, string phil)
		{
			MySqlCommand command = new MySqlCommand("INSERT INTO `employee`(`idnumber`, `qrcode`, `photo`, `firstname`, `middlename`, `lastname`, `designation`, `contactperson`, `contactnumber`, `address`, `birthdate`, `tin`, `sss`, `phil`) VALUES (@id,@qr,@photo,@fn,@mn,@ln,@des,@cp,@cn,@addr,@bdate,@tin,@sss,@phil)", db.getConnection);

			//@id,@qr,@pic,@fn,@mn,@ln,@des,@cp,@cn,@addr,@bdate,@tin,@sss,@phil
			command.Parameters.Add("@id", MySqlDbType.VarChar).Value = idno;
			command.Parameters.Add("@qr", MySqlDbType.Blob).Value = qrcode.ToArray();
			command.Parameters.Add("@photo", MySqlDbType.Blob).Value = picture.ToArray();
			command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
			command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname;
			command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
			command.Parameters.Add("@des", MySqlDbType.VarChar).Value = designation;
			command.Parameters.Add("@cp", MySqlDbType.VarChar).Value = contactperson;
			command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = contactnumber;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@bdate", MySqlDbType.DateTime).Value = bdate;
			command.Parameters.Add("@tin", MySqlDbType.VarChar).Value = tin;
			command.Parameters.Add("@sss", MySqlDbType.VarChar).Value = sss;
			command.Parameters.Add("@phil", MySqlDbType.VarChar).Value = phil;

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}

		//create a function to update employee table
		public bool updateEmployee(string idno, MemoryStream qrcode, MemoryStream picture, string fname, string mname, string lname, string designation, string contactperson, string contactnumber, string address, DateTime bdate, string tin, string sss, string phil)
		{
			MySqlCommand command = new MySqlCommand("UPDATE `employee` SET `qrcode`=@qr, `photo`=@photo, `firstname`=@fn, `middlename`=@mn, `lastname`=@ln, `designation`=@des, `contactperson`=@cp, `contactnumber`=@cn, `address`=@addr, `birthdate`=@bdate, `tin`=@tin, `sss`=@sss, `phil`=@phil WHERE `idnumber`=@id", db.getConnection);

			//@id,@qr,@pic,@fn,@mn,@ln,@des,@cp,@cn,@addr,@bdate,@tin,@sss,@phil
			command.Parameters.Add("@id", MySqlDbType.VarChar).Value = idno;
			command.Parameters.Add("@qr", MySqlDbType.Blob).Value = qrcode.ToArray();
			command.Parameters.Add("@photo", MySqlDbType.Blob).Value = picture.ToArray();
			command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
			command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname;
			command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
			command.Parameters.Add("@des", MySqlDbType.VarChar).Value = designation;
			command.Parameters.Add("@cp", MySqlDbType.VarChar).Value = contactperson;
			command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = contactnumber;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@bdate", MySqlDbType.DateTime).Value = bdate;
			command.Parameters.Add("@tin", MySqlDbType.VarChar).Value = tin;
			command.Parameters.Add("@sss", MySqlDbType.VarChar).Value = sss;
			command.Parameters.Add("@phil", MySqlDbType.VarChar).Value = phil;

			//command.Parameters.Add("@id", MySqlDbType.String).Value = idno;

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}

		//function to delete the selected employee
		public bool deleteEmployee(string id)
		{
			MySqlCommand command = new MySqlCommand("DELETE FROM `employee` WHERE `idnumber`= @idnumber", db.getConnection);

			command.Parameters.Add("@idnumber", MySqlDbType.VarChar).Value = id;

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}

		public bool valEmployee(string id)
		{
			ManageEMPLOYEE employee = new ManageEMPLOYEE();

			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `employee` WHERE `idnumber` = @id", db.getConnection);
			command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

			adapter.SelectCommand = command;
			adapter.Fill(table);

			if (table.Rows.Count > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}






		//checking of data in employee table if the id number is already in use
		//public bool valEmployee(string id)
		//{
		//	MySqlCommand command;
		//	MySqlDataReader mdr;
		//	db.openConnection();
		//	string selectQuery = ("SELECT * FROM `employee` WHERE `idnumber`=" + id);
		//	command = new MySqlCommand(selectQuery, db.getConnection);
		//	try
		//	{
		//		mdr = command.ExecuteReader();
		//		mdr.Read();
		//		mdr.Close();
		//		db.closeConnection();
		//		return true;
		//	}
		//	catch
		//	{
		//		db.closeConnection();
		//		//mdr.Close();
		//		return false;
		//	}

		//	//mdr = command.ExecuteReader();
		//	//if (mdr.Read())
		//	//{
		//	//	db.closeConnection();
		//	//	mdr.Close();
		//	//	return true;
		//	//}
		//	//else
		//	//{
		//	//	db.closeConnection();
		//	//	mdr.Close();
		//	//	return false;
		//	//}
		//}

		//adding the employee to the printemployee table
		public bool insertPrintEMPLOYEE(string idno, MemoryStream qrcode, MemoryStream photo, string fullname, string designation, string contactperson, string contactnumber, string address, DateTime bdate, string tin, string sss, string phil)
		{
			MySqlCommand command = new MySqlCommand("INSERT INTO `printemployee`(`idnumber`, `qrcode`, `photo`, `fullname`, `designation`, `contactperson`, `contactnumber`, `address`, `birthdate`, `tin`, `sss`, `phil`) VALUES (@id,@qr,@photo,@fn,@des,@cp,@cn,@addr,@bdate,@tin,@sss,@phil)", db.getConnection);

			//@id,@qr,@photo,@fn,@des,@cp,@cn,@addr,@bdate,@tin,@sss,@phil
			command.Parameters.Add("@id", MySqlDbType.VarChar).Value = idno;
			command.Parameters.Add("@qr", MySqlDbType.Blob).Value = qrcode.ToArray();
			command.Parameters.Add("@photo", MySqlDbType.Blob).Value = photo.ToArray();
			command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fullname;
			command.Parameters.Add("@des", MySqlDbType.VarChar).Value = designation;
			command.Parameters.Add("@cp", MySqlDbType.VarChar).Value = contactperson;
			command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = contactnumber;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@bdate", MySqlDbType.DateTime).Value = bdate;
			command.Parameters.Add("@tin", MySqlDbType.VarChar).Value = tin;
			command.Parameters.Add("@sss", MySqlDbType.VarChar).Value = sss;
			command.Parameters.Add("@phil", MySqlDbType.VarChar).Value = phil;

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}

		//checking of data in printemployee table if the id number is already in use
		public bool valEMPLOYEEPrint(string id)
		{
			ManageEMPLOYEE employee = new ManageEMPLOYEE();

			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `printemployee` WHERE `idnumber` = @id", db.getConnection);
			command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

			adapter.SelectCommand = command;
			adapter.Fill(table);

			if (table.Rows.Count > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

			//MySqlCommand command;
			//MySqlDataReader mdr;
			//db.openConnection();

			//string selectQuery = ("SELECT * FROM `printemployee` WHERE `idnumber`=" + id);
			//command = new MySqlCommand(selectQuery, db.getConnection);

			//mdr = command.ExecuteReader();


			//if (mdr.Read())
			//{
			//	db.closeConnection();
			//	return true;

			//}
			//else
			//{
			//	db.closeConnection();
			//	return false;
			//}

		}
	}
}
