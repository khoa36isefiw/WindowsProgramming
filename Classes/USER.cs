using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20110375_HuynhDangKhoa_LoginForm
{
    public class USER
    {
        MY_DB mydb = new MY_DB();
        #region Student
        public bool insertUser(string userName, string userPass, string userFName, string userLName, string userGender, int phoneNum,
            string userEmail)
        {
            SqlCommand command = new SqlCommand("INSERT INTO user_login (userName, userPassword, userFName, userLName," +
                " userGender, userPhone, userEmail) "+
                    " VALUES (@usrName, @usrPass, @usrFName, @usrLName, @usrGender,  @usrPhone, @usrEmail)", mydb.getConnection);

            command.Parameters.Add("@usrName", SqlDbType.NChar).Value = userName;
            command.Parameters.Add("@usrPass", SqlDbType.NChar).Value = userPass;
            command.Parameters.Add("@usrFName", SqlDbType.NVarChar).Value = userFName;
            command.Parameters.Add("@usrLName", SqlDbType.NVarChar).Value = userLName;
            command.Parameters.Add("@usrGender", SqlDbType.NChar).Value = userGender;
            command.Parameters.Add("@usrPhone", SqlDbType.Int).Value = phoneNum;
            command.Parameters.Add("@usrEmail", SqlDbType.NChar).Value = userEmail;
       

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


        // update password when we reset password
        public bool updateResetPassWord(string pass, string email)
        {
            SqlCommand command = new SqlCommand("UPDATE user_login SET userPassword=@pass WHERE userEmail =@email ", mydb.getConnection);

            command.Parameters.Add("@pass", SqlDbType.NChar).Value = pass;
            command.Parameters.Add("@email", SqlDbType.NChar).Value = email;

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
        public bool deleteUser(string user)
        {
            SqlCommand command = new SqlCommand("DELETE FROM user_login WHERE userName =@id ", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NChar).Value = user;
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

        #endregion



        #region Human Resource
        public bool insertHumanResource(int id, string fname, string lname, string username, string password, MemoryStream picture, string email)
        {
            SqlCommand command = new SqlCommand("INSERT INTO HumanResource (id, f_name, l_name, uname, pwd, fig, gmail)" +
                " VALUES (@id ,@fn, @ln, @un, @pw, @pic, @gm)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pw", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@gm", SqlDbType.VarChar).Value = email;
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
        public bool updateHumanResource(int id, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE HumanResource SET f_name = @fn, l_name = @ln, uname = @un , pwd = @pass, fig = @pic WHERE id = @uid", mydb.getConnection);
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uid", SqlDbType.Int).Value = id;

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
        public bool CheckHRID(int UserID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HumanResource where id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = UserID;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }
        public bool CheckHRUserName(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HumanResource where uname = @un", mydb.getConnection);
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }
        public bool CheckHRUserNameForEdit(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HumanResource where uname = @un", mydb.getConnection);
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 1)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }
        public DataTable GetHR(int Global_ID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HumanResource Where id = @HRID", mydb.getConnection);
            command.Parameters.Add("@HRID", SqlDbType.Int).Value = Global_ID;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        #endregion
    }
}
