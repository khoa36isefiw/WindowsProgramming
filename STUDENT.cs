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
        public bool insertStudent (int ID, string fName, string lName, DateTime birthDate, string Gender, int phoneNum, 
            string Email ,string address, string departMent, string Major ,MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO student (ID, FirstName, LastName, BirthDate," +
                " Gender, PhoneNumber, Email, Address, Department, Major, Picture)" +
                    " VALUES (@id, @fn, @ln, @birthDay, @gender,  @phone, @email, @addrs, @depart, @major, @pict)", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
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


        // create a function to update students information
        public bool updateStudent(int ID, string fName, string lName, DateTime birthDate, string Gender, int phoneNum,
            string Email, string address, string departMent, string Major, MemoryStream picture)
        {

            //SqlCommand command = new SqlCommand("UPDATE student SET FirstName=@fn, LastName=@ln, BirthDate=@birthDay," +
            //    " Gender=@gender, PhoneNumber=@phone, Email=@email, Address=@addrs," +
            //    " Department=@depart, Major=@major, Picture=@pic WHERE id = " + ID, mydb.getConnection);

            SqlCommand command = new SqlCommand("UPDATE student SET FirstName=@fn, LastName=@ln, BirthDate=@birthDay," +
            " Gender=@gender, PhoneNumber=@phone, Email=@email, Address=@addrs," +
            " Department=@depart, Major=@major, Picture=@pic WHERE ID =@id ", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
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
        public bool deleteStudent(int ID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM student WHERE id = " +
                        ID, mydb.getConnection);

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


    }
}
