using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKyTucXa.Models
{
    public class TruongDTO
    {
        public long ID_Truong { get; set; }
        public string TenTruong { get; set; }
        public string MaTruong { get; set; }
        public TruongDTO (DataRow dr)
        {
            this.ID_Truong = Convert.ToInt32(dr["ID_Truong"]);
            this.TenTruong = Convert.ToString(dr["TenTruong"]);
            this.MaTruong = Convert.ToString(dr["MaTruong"]);
        }
    }
}
