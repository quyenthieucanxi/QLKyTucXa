using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKyTucXa.Models;
using System.Data;
using QLKyTucXa.ConnectDatabase;

namespace QLKyTucXa.Controller
{
    public static class NguoiDungDAO
    {
        static Database db = new Database();
        public static bool Login(string userName, string passWord)
        {
            
            string query = $"EXEC dbo.USP_Login @USERNAME={userName} , @PASSWORD={passWord}";//, userName, passWord);
            DataTable result = db.Execute(query);
            return result.Rows.Count > 0;
        }
        public static NguoiDungDTO GetUserByUsername(string userName)
        {
            string query = string.Format("EXEC dbo.USP_GetUserByUsername @USERNAME = '{0}'", userName);
            DataTable dataTable = db.Execute(query);
            foreach (DataRow item in dataTable.Rows)
            {
                return new NguoiDungDTO(item);
            }
            return null;
        }
        public static NguoiDungDTO GetUserById(string id)
        {
            string query = string.Format("EXEC dbo.USP_GetUserById @USER_ID = {0}", id);
            DataTable dataTable = db.Execute(query);
            foreach (DataRow item in dataTable.Rows)
            {
                return new NguoiDungDTO(item);

            }
            return null;
        }
        /*public static bool AddUser(string lastName, string firstName, DateTime dob, string gender, string ssn, string phoneNumber1,
            string phoneNumber2, string email, string imagePath, string userType, string provinceName, string districtName, string communeName,
            string street, DateTime startDate, string salary)
        {
            string dobTemp = Convert.ToDateTime(dob).ToString("yyyyMMdd");
            string startDateTemp = Convert.ToDateTime(startDate).ToString("yyyyMMdd");
            string query = string.Format("EXEC dbo.USP_AddEmployee @LAST_NAME = N'{0}',@FIRST_NAME = N'{1}',@DOB = '{2}',@GENDER = N'{3}',@SSN = '{4}'," +
                "@PHONE_NUMBER_1 = '{5}',@PHONE_NUMBER_2 = '{6}', @EMAIL = '{7}', @IMAGE_PATH = '{8}', @USER_TYPE = '{9}', @PROVINCE_NAME = N'{10}', " +
                "@DISTRICT_NAME = N'{11}', @COMMUNE_NAME = N'{12}',@STREET = N'{13}', @STATR_DATE = '{14}', @SALARY = {15}",
                lastName, firstName, dobTemp, gender, ssn, phoneNumber1, phoneNumber2, email, imagePath, userType, provinceName, districtName, communeName, street,
                startDateTemp, salary);
            int result = db.Execute(query);
            return result > 0;
        }
        public static bool ChangePassword(long userId, string oldpass, string newpass)
        {
            string query = "EXEC dbo.USP_ChangePassword @USER_ID , @OLDPASS , @NEWPASS";
            int result = DataProvider.ExcuteNonQuery(query, new object[] { userId, oldpass, newpass });
            return result > 0;
        }

        public static bool AddUserLogin(string role, string username, string password)
        {
            string query = "EXECUTE USP_CREATE_LOGIN_USER @Role_Name , @Login_Name , @Password_Login";
            int result = DataProvider.ExcuteNonQuery(query, new object[] { role, username, password });
            return result > 0;
        }
        public static bool DropLoginDropUserStudent(string Ssn)
        {
            string query = string.Format("EXEC dbo.USP_DropLoginDropUserStudent @SSN = '{0}'", Ssn);
            int result = DataProvider.ExcuteNonQuery(query);
            return result > 0;
        }

        public static List<UserDTO> GetListUser()
        {
            List<UserDTO> userDTOs = new List<UserDTO>();
            string query = string.Format("EXEC dbo.USP_GetListUser");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                UserDTO userDTO = new UserDTO(item);
                userDTOs.Add(userDTO);
            }
            return userDTOs;

        }
        public static DataTable GetListStudentView(long user)
        {
            string query = string.Format("EXEC dbo.USP_GetListStudentView @USER_ID = {0}", user);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
        public static bool EditUser(string lastName, string firstName, DateTime dob, string gender, string ssn, string phoneNumber1,
            string phoneNumber2, string email, string imagePath, string userType, string provinceName, string districtName, string communeName,
            string street, long userId)
        {
            string dobTemp = Convert.ToDateTime(dob).ToString("yyyyMMdd");
            string query = string.Format("EXEC dbo.USP_EditEmployee @LAST_NAME = N'{0}',@FIRST_NAME = N'{1}',@DOB = '{2}',@GENDER = N'{3}',@SSN = '{4}'," +
                "@PHONE_NUMBER_1 = '{5}',@PHONE_NUMBER_2 = '{6}', @EMAIL = '{7}', @IMAGE_PATH = '{8}', @USER_TYPE = '{9}', @PROVINCE_NAME = N'{10}', " +
                "@DISTRICT_NAME = N'{11}', @COMMUNE_NAME = N'{12}',@STREET = N'{13}', @USER_ID = {14}",
                lastName, firstName, dobTemp, gender, ssn, phoneNumber1, phoneNumber2, email, imagePath, userType, provinceName, districtName, communeName, street, userId);
            int result = DataProvider.ExcuteNonQuery(query);
            return result > 0;
        }*/
    }
}
