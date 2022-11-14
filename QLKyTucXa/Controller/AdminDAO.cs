using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKyTucXa.Models;
using QLKyTucXa.ConnectDatabase;
using System.Data;
namespace QLKyTucXa.Controller
{
    public  static class AdminDAO
    {
        static Database db;
        
        public static AdminDTO GetAdminById(long id)
        {
            string query = string.Format("EXEC dbo.USP_GetAdminById @USER_ID = {0}", id);
            DataTable dataTable = db.Execute(query);
            foreach (DataRow item in dataTable.Rows)
            {
                return new AdminDTO(item);

            }
            return null;
        }
    }
}
