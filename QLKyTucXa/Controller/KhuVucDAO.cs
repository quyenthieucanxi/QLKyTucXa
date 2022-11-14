using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKyTucXa.ConnectDatabase;
using QLKyTucXa.Models;
using System.Data;

namespace QLKyTucXa.Controller
{
    public static class KhuVucDAO
    {
        static Database db =new Database() ;
       
        public static List<KhuVucDTO> GetListSector()
        {
            string query = string.Format("EXEC dbo.USP_GetListSector");
            DataTable dataTable = db.Execute(query);
            List<KhuVucDTO> ListKhuVuc = new List<KhuVucDTO>();
            foreach (DataRow item in dataTable.Rows)
            {
                KhuVucDTO KhuVuc = new KhuVucDTO(item);
                ListKhuVuc.Add(KhuVuc);
            }
            return ListKhuVuc;
        }

    }
}
