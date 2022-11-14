using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKyTucXa.Models
{
    public class DiaChiDTO
    {
        public long ID_DiaChi { get; set; }
        public string Tinh { get; set; }
        public string Huyen { get; set; }
        public string Xa { get; set; }
        public string Duong { get; set; }
        public DiaChiDTO(DataRow dr)
        {
            this.ID_DiaChi= Convert.ToInt64(dr["ID_DiaChi"]);
            this.Tinh = Convert.ToString(dr["Tinh"]).Trim();
            this.Huyen = Convert.ToString(dr["Huyen"]).Trim();
            this.Xa = Convert.ToString(dr["Xa"]).Trim();
            this.Duong = Convert.ToString(dr["Duong"]).Trim();

        }


    }
}
