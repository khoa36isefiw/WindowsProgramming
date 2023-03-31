using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20110375_HuynhDangKhoa_LoginForm.Score
{
    public class SCORE
    {
        MY_DB mydb = new MY_DB();
        Course.COURSE course = new Course.COURSE();



        // Thêm Score/ Thêm Điểm
        public bool insertScore(int studentID, int scoreID, float scoreValue, string description)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Score (student_id, course_id, student_score, description)" +
                "Values (@stu_id, @course_id, @stuScore, @desc)", mydb.getConnection);

            cmd.Parameters.Add("@stu_id", SqlDbType.Int).Value = studentID;
            cmd.Parameters.Add("@course_id", SqlDbType.Int).Value = scoreID;
            cmd.Parameters.Add("@stuScore", SqlDbType.Float).Value = scoreValue;
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


        // remove Score/ Xóa Điểm
        public bool deleteScore (int courseID, int scoreID)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Score WHERE student_id =@sid AND course_id= @cid", mydb.getConnection);
            cmd.Parameters.AddWithValue("@sid", SqlDbType.Int).Value = courseID;
            cmd.Parameters.AddWithValue("@cid", SqlDbType.Int).Value = scoreID;
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

        //ktra trùng, tương tự các phần trước
        public bool studentScoreExist(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM  Score WHERE student_id = @sid AND course_id = @cid", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if ((table.Rows.Count) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // hàm lấy điểm của một student
        public DataTable getStudentScore()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
           
            command.CommandText = "SELECT Score.student_id as StudentID , student.FirstName as FirstName, " +
                "student.LastName as LastName, Score.course_id as CourseID, Course.label, " +
                "round(Score.student_score,3) as Score FROM student " +
                "INNER JOIN Score on student.ID = Score.student_id INNER JOIN " +
                "Course on Score.course_id = Course.id order by Course.label";
           

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }


        // tính điểm trung bình
        public DataTable getAverageCourse()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = mydb.getConnection;

            cmd.CommandText = "Select Course.label, AVG(Score.student_score) as AverageGrade from Course, " +
                "Score where Course.id = Score.course_id " +
                "Group By Course.label";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //Lấy bảng điểm môn học và 1 số thông tin cơ bản: mssv-fname-lname-courseID-CourseName-student_score
        public DataTable getCourseScore(int courseID)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT Score.student_id, student.FirstName, student.LastName, Score.course_id, Course.label, Score.student_score" +
                            "FROM student INNER JOIN score on student.ID = Score.student_id INNER JOIN course on Score.course_id = Course.id WHERE Score.course_id = " + courseID);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getStudentScore(int studentID)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT Score.student_id, student.FirstName, student.LastName, " +
                "Score.course_id, Course.label, Score.student_score " +
                "FROM student JOIN Score on student.ID = Score.student_id " +
                "INNER JOIN Course on Score.course_id = Course.id WHERE Score.student_id = " + studentID);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public DataTable getAllCourseScoreAndResult()
        {
            SqlCommand command = new SqlCommand("SELECT ID , FirstName, LastName FROM student", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            DataTable tableCourse = new DataTable();
            tableCourse = course.getAllCourses();

            //lấy khóa học theo chiều ngang
            for (int i = 0; i < tableCourse.Rows.Count; i++)
            {
                DataColumn CourseNamecolumn = new DataColumn();
                CourseNamecolumn.ColumnName = tableCourse.Rows[i]["label"].ToString();
                table.Columns.Add(CourseNamecolumn);
            }
            //lấy điểm của từng khóa học dựa theo id của học sinh
            DataTable tableScore = new DataTable();
            tableScore = this.getStudentScore();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int c = 0; c < tableScore.Rows.Count; c++)
                {
                    if (table.Rows[i]["id"].ToString() == tableScore.Rows[c]["StudentID"].ToString())
                    {
                        for (int k = 3; k < table.Columns.Count; k++)
                        {
                            if (table.Columns[k].ColumnName == tableScore.Rows[c]["label"].ToString())
                            {
                                //string coursename = table.Columns[k].ColumnName;
                                //table.Rows[i][coursename] = tableScore.Rows[c]["student_score"].ToString();
                                table.Rows[i][k] = tableScore.Rows[c]["Score"].ToString();
                                break;
                            }
                        }
                    }
                }
            }

            table.Columns.Add("AVG_Score", typeof(float));
            table.Columns.Add("Result", typeof(string));
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int count = 0;
                float sum = 0;
                for (int j = 3; j < table.Columns.Count - 2; j++)
                {
                    float temp;
                    string coursename = table.Columns[j].ColumnName;
                    if (float.TryParse(table.Rows[i][coursename].ToString(), out temp))
                    {
                        sum += temp;
                        count++;
                    }
                }

                float avg = sum / count;
                Math.Round(avg, 2);
                table.Rows[i]["AVG_Score"] = Math.Round(avg, 2);

                if (avg < 5) table.Rows[i]["Result"] = "Fail";
                if (avg >= 5 && avg <= 6.5) table.Rows[i]["Result"] = "Average";
                if (avg > 6.5 && avg <= 7.9) table.Rows[i]["Result"] = "Good";
                if (avg >= 8) table.Rows[i]["Result"] = "Excellent";
                if (count == 0) table.Rows[i]["Result"] = "Drop Out Of University!";
                if (avg.ToString() == "NaN") table.Rows[i]["AVG_Score"] = 0;
            }

            return table;
        }
    }
}
