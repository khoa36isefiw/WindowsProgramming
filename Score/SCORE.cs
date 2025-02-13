﻿using System;
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
        public bool insertScore(string studentID, int scoreID, float scoreValue, string description)
        {
            #region student id kieu int
            /*SqlCommand cmd = new SqlCommand("INSERT INTO Score (student_id, course_id, student_score, description)" +
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
            }*/

            #endregion


            #region student id by String
                SqlCommand cmd = new SqlCommand("INSERT INTO SCORE2 (student_id, course_id, student_score, description)" +
                  "Values (@stu_id, @course_id, @stuScore, @desc)", mydb.getConnection);

                cmd.Parameters.Add("@stu_id", SqlDbType.NChar).Value = studentID;
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
            #endregion

        }


        // remove Score/ Xóa Điểm
        public bool deleteScore (string courseID, int scoreID)
        {
            #region studentID int
            //SqlCommand cmd = new SqlCommand("DELETE FROM Score WHERE student_id =@sid AND course_id= @cid", mydb.getConnection);
            //cmd.Parameters.AddWithValue("@sid", SqlDbType.Int).Value = courseID;
            //cmd.Parameters.AddWithValue("@cid", SqlDbType.Int).Value = scoreID;
            //mydb.openConnection();

            //if (cmd.ExecuteNonQuery() == 1)
            //{
            //    mydb.closeConnection();
            //    return true;
            //}
            //else
            //{
            //    mydb.closeConnection();
            //    return false;
            //}

            #endregion

            SqlCommand cmd = new SqlCommand("DELETE FROM SCORE2 WHERE student_id =@sid AND course_id= @cid", mydb.getConnection);
            cmd.Parameters.AddWithValue("@sid", SqlDbType.NChar).Value = courseID;
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
        public bool studentScoreExist(string studentID, int courseID)
        {
            #region student id kieu int
            //SqlCommand command = new SqlCommand("SELECT * FROM  Score WHERE student_id = @sid AND course_id = @cid", mydb.getConnection);
            //command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            //command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;

            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable table = new DataTable();
            //adapter.Fill(table);

            //if ((table.Rows.Count) == 0)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
            #endregion

            SqlCommand command = new SqlCommand("SELECT * FROM  SCORE2 WHERE student_id = @sid AND course_id = @cid", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.NChar).Value = studentID;
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



            //// KIEU STRING CHO STUDENT ID

            /*
             
            "SELECT score.student_id as StudentID , std.fname as FirstName, std.lname as LastName, 
            score.course_id as CourseID, course.label, round(score.student_score,3) as Score FROM std INNER JOIN 
            score on std.id = score.student_id INNER JOIN course on score.course_id = Course.id order by course.label";
             
             */
            //command.CommandText = "SELECT score.student_id as StudentID ,
            //std.fname as FirstName, std.lname as LastName, score.course_id as CourseID,
            //course.label, round(score.student_score,3) as Score FROM std
            //INNER JOIN score on std.id = score.student_id INNER JOIN course on score.course_id = Course.id order by course.label";

            command.CommandText = "SELECT SCORE2.student_id as 'StudentID', student.FirstName as 'First Name', " +
                "student.LastName as 'Last Name', SCORE2.course_id as 'Course ID', Course.label as 'Course Name', " +
                "round(SCORE2.student_score,3) as Score22 FROM student " +
                "INNER JOIN SCORE2 on student.MSSV = SCORE2.student_id INNER JOIN " +
                "Course on SCORE2.course_id = Course.id" +
                " order by Course.label";

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

            // KIEU IN CHO STUDENT ID
            //cmd.CommandText = "Select Course.label, AVG(Score.student_score) as AverageGrade from Course, " +
            //    "Score where Course.id = Score.course_id " +
            //    "Group By Course.label";

            // KIEN STRING  CHO STUDENT ID
            
            cmd.CommandText = "Select Course.label, AVG(SCORE2.student_score) as 'Average Grade' from Course, " +
                "SCORE2 where Course.id = SCORE2.course_id " +
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
            //command.CommandText = ("SELECT Score.student_id, student.FirstName, student.LastName, Score.course_id, Course.label, Score.student_score" +
            //                "FROM student INNER JOIN score on student.ID = Score.student_id INNER JOIN course on Score.course_id = Course.id WHERE Score.course_id = " + courseID);


            // KIEU STRING
            command.CommandText = ("SELECT SCORE2.student_id as 'Student ID', student.FirstName 'First Name', student.LastName 'Last Name'," +
                " SCORE2.course_id, Course.label, SCORE2.student_score" +
                            "FROM student INNER JOIN SCORE2 on student.MSSV = SCORE2.student_id " +
                            "INNER JOIN course on SCORE2.course_id = Course.id WHERE SCORE2.course_id = " + courseID);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getStudentScore(int studentID)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            
            // KIEU STRING 
            
            command.CommandText = ("SELECT SCORE2.student_id, student.FirstName, student.LastName, " +
                    "SCORE2.course_id, Course.label, SCORE2.student_score " +
                    "FROM student JOIN SCORE2 on student.ID = SCORE2.student_id " +
                    "INNER JOIN Course on SCORE2.course_id = Course.id WHERE SCORE2.student_id = " + studentID);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public DataTable getAllCourseScoreAndResult()
        {
            SqlCommand command = new SqlCommand("SELECT MSSV, FirstName, LastName FROM student", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            DataTable tableCourse = new DataTable();
            tableCourse = course.getAllCourses();

            //lấy khóa học theo chiều ngang add vào trong datagridview
            for (int i = 0; i < tableCourse.Rows.Count; i++)
            {
                DataColumn CourseNamecolumn = new DataColumn();
                CourseNamecolumn.ColumnName = tableCourse.Rows[i]["label"].ToString();
                table.Columns.Add(CourseNamecolumn);
            }

            //lấy điểm của từng khóa học dựa theo mssv của học sinh
            DataTable tableScore = new DataTable();
            tableScore = this.getStudentScore();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int c = 0; c < tableScore.Rows.Count; c++)
                {
                    //if (table.Rows[i]["MSSV"].ToString() != tableScore.Rows[c]["StudentID"].ToString())
                    
                    // sai ngay cau dieu kien
                    if (table.Rows[i]["MSSV"].ToString().Trim() == tableScore.Rows[c]["StudentID"].ToString().Trim())
                    {
                        for (int k = 3; k < table.Columns.Count; k++)
                        {
                            if (table.Columns[k].ColumnName == tableScore.Rows[c]["Course Name"].ToString())
                            {
                                
                                table.Rows[i][k] = tableScore.Rows[c]["Score22"].ToString();
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
