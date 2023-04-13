using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _20110375_HuynhDangKhoa_LoginForm
{
    public class STUDENT
    {
        MY_DB mydb = new MY_DB();
    
        public bool insertStudent (string id, string fName, string lName, DateTime birthDate, string Gender, int phoneNum, 
            string Email ,string address, string departMent, string Major ,MemoryStream picture, string hometown)
        {
            SqlCommand command = new SqlCommand("INSERT INTO student ( MSSV, FirstName, LastName, BirthDate," +
                " Gender, PhoneNumber, Email, Address, Department, Major, Picture, HomeTown)" +
                    " VALUES (@id, @fn, @ln, @birthDay, @gender,  @phone, @email, @addrs, @depart, @major, @pict, @home)", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.NChar).Value = id;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fName;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lName;
            command.Parameters.Add("@birthDay", SqlDbType.DateTime).Value = birthDate;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = Gender;
            command.Parameters.Add("@phone", SqlDbType.Int).Value = phoneNum;
            command.Parameters.Add("@email", SqlDbType.NChar).Value = Email;            
            command.Parameters.Add("@addrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@depart", SqlDbType.NVarChar).Value = departMent;
            command.Parameters.Add("@major", SqlDbType.NVarChar).Value = Major;
            command.Parameters.Add("@pict", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@home", SqlDbType.NVarChar).Value = hometown;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        //create a function to return a table students data
        public DataTable getStudents (SqlCommand command)
        {
            command.Connection = mydb.getConnection;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;

        }
        //public DataTable getStudentsByCourses(SqlCommand command)
        //{
        //    command.Connection = mydb.getConnection;

        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);

        //    return table;

        //}



        // create a function to update students information
        public bool updateStudent(string ID, string fName, string lName, DateTime birthDate, string Gender, int phoneNum,
            string Email, string address, string departMent, string Major, MemoryStream picture, string hometown)
        {

           

            SqlCommand command = new SqlCommand("UPDATE student SET  FirstName=@fn, LastName=@ln, BirthDate=@birthDay," +
            " Gender=@gender, PhoneNumber=@phone, Email=@email, Address=@addrs," +
            " Department=@depart, Major=@major, Picture=@pic, HomeTown=@home WHERE MSSV=@masv", mydb.getConnection);

                
                command.Parameters.Add("@masv", SqlDbType.NChar).Value = ID;
                command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fName;
                command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lName;
            
                command.Parameters.Add("@birthDay", SqlDbType.DateTime).Value = birthDate;
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = Gender;
                command.Parameters.Add("@phone", SqlDbType.Int).Value = phoneNum;
                command.Parameters.Add("@email", SqlDbType.NChar).Value = Email;
                command.Parameters.Add("@addrs", SqlDbType.NVarChar).Value = address;
                command.Parameters.Add("@depart", SqlDbType.NVarChar).Value = departMent;
                command.Parameters.Add("@major", SqlDbType.NVarChar).Value = Major;
                command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
                command.Parameters.Add("@home", SqlDbType.NVarChar).Value = hometown;

            mydb.openConnection();
                if ((command.ExecuteNonQuery() == 1))
                {
                    mydb.closeConnection();
                    return true;
                }
                else
                {
                    mydb.closeConnection();
                    return false;
                }

        }

        // upadate selected Course for student
        public bool updateStudentSelectedCourses(string ID,string selectedCourse)
        {
            SqlCommand command = new SqlCommand("UPDATE student SET selectedCourse=@Course WHERE MSSV=@masv", mydb.getConnection);

            command.Parameters.Add("@masv", SqlDbType.NChar).Value = ID;
            command.Parameters.Add("@Course", SqlDbType.Text).Value = selectedCourse;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }




        // create a function to delete the selected student 
        public bool deleteStudent(string mssv)
        {
            SqlCommand command = new SqlCommand("DELETE FROM student WHERE MSSV =@id ", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NChar).Value = mssv;
            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }




        #region This is use for form Statistics
        string executeCount(string query)
        {
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            String count = cmd.ExecuteScalar().ToString();  // count each rows

            mydb.closeConnection();
            return count;
        }

        public string totalStudent()
        {
            return executeCount("SELECT COUNT(*) FROM student");
        }

        public string totalMaleStudent()
        {
            return executeCount("Select Count(*) from student where Gender = 'Male'");

        }


        public string totalFemaleStudent()
        {
            return executeCount("Select Count(*) from student where Gender = 'Female'");

        }

        public String totalBirthYearStudent()
        {
            return executeCount("SELECT YEAR(BirthDate), COUNT(*) FROM student GROUP BY YEAR(BirthDate)");

        }



        #endregion

    }
}
