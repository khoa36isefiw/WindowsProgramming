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
    }
}
