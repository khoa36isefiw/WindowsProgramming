using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _20110375_HuynhDangKhoa_LoginForm.Course
{
    public class COURSE
    {
        MY_DB mydb = new MY_DB();


        // function to insert a new course
        public bool insertCourse(int id, string courseName, int hoursNumber, string description)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Course (id, label, period, description)" +
                "Values (@icd, @name, @time, @desc)", mydb.getConnection);

            cmd.Parameters.Add("@icd", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = courseName;
            cmd.Parameters.Add("@time", SqlDbType.Int).Value = hoursNumber;
            cmd.Parameters.Add("@desc", SqlDbType.Text).Value = description;

            mydb.openConnection();
            if ((cmd.ExecuteNonQuery() == 1))
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

        // remove a course
               
        public bool deleteCourse(int courseID)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Course WHERE id =@cid ", mydb.getConnection);
            cmd.Parameters.AddWithValue("@cid", SqlDbType.NVarChar).Value = courseID;
            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
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

        // update - edit course
        // create a function to update students information
        public bool updateCourse(int courseID, string courseName, int hours, string descript)
        {



            SqlCommand command = new SqlCommand("UPDATE Course SET label=@name, period=@hours, description=@des " +
                "WHERE id =@icd ", mydb.getConnection);

            command.Parameters.Add("@icd", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = courseName;
            command.Parameters.Add("@hours", SqlDbType.Int).Value = hours;

            command.Parameters.Add("@des", SqlDbType.Text).Value = descript;

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

        //create a function to return a course by ID
        public DataTable getCourseByID(int courseID)
        {
            SqlCommand cmd = new SqlCommand("select * from Course where id=@cid", mydb.getConnection);
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            
            DataTable table = new DataTable();
            
            adapter.Fill(table);

            return table;
        }

        //create a function to return all data from course
        public DataTable getAllCourses()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // find course if they have the same name
        public bool checkCCourseName(string courseName, int courseID = 0)
        {
            // id <> @cID để phân biệt xem có tồn tại không? Chỉ là parameters
            SqlCommand cmd = new SqlCommand("Select * FROM Course WHERE label=@cName AND id<>@id", mydb.getConnection);

            cmd.Parameters.Add("@cName", SqlDbType.NVarChar).Value = courseName;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = courseID;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if(table.Rows.Count > 0) // phát hiện nếu có trùng tên
            {
                return true;
            }
            else
            {
                return false;
                
            }

        }

        public bool checkCourseID( int courseID = 0)
        {
            // id <> @cID để phân biệt xem có tồn tại không? Chỉ là parameters
            SqlCommand cmd = new SqlCommand("Select * FROM Course WHERE id <> @icd", mydb.getConnection);

            
            cmd.Parameters.Add("@icd", SqlDbType.Int).Value = courseID;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0) // phát hiện nếu có trùng tên
            {
                return true;
            }
            else
            {
                return false;

            }

        }

        string execCount(string querry)
        {
            SqlCommand cmd = new SqlCommand(querry, mydb.getConnection);
            mydb.openConnection();
            string count = cmd.ExecuteScalar().ToString();
            //string count = command.ExecuteNonQuery().ToString();
            mydb.closeConnection();
            return count;
        }

        public string totalCourse()
        {
            return execCount("SELECT COUNT(*) FROM Course");
        }
        

    }
}
