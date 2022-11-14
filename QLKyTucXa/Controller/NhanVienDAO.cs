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
    public static class NhanVienDAO
    {
        static Database db;
        public static NhanVienDTO GetEmployeeById(long id)
        {
            string query = string.Format("EXEC dbo.USP_GetEmployeeById @USER_ID = {0}", id);
            DataTable dataTable = db.Execute(query);
            foreach (DataRow item in dataTable.Rows)
            {
                return new NhanVienDTO(item);

            }
            return null;
        }

        public static DataTable GetEmployees()
        {
            string query = string.Format("EXEC dbo.USP_GetListEmployeeView");
            DataTable dataTable = db.Execute(query);
            return dataTable;
        }
        public static DataTable GetEmployeesByUserId(long userId)
        {
            string query = string.Format("EXEC dbo.USP_GetEmployeeView @USER_ID = {0}", userId);
            DataTable dataTable = db.Execute(query);
            return dataTable;
        }
        public static bool UpdateSalary(long userId, string salary)
        {
            string query = string.Format("EXEC dbo.USP_UpdateSalary @USER_ID = {0}, @SALARY = {1} ", userId, salary);
            DataTable result = db.Execute(query);
            return result.Rows.Count > 0;
        }
    }
}
