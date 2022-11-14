using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QLKyTucXa.Models
{
    public class LoaiPhongDTO
    {
		public int ID_LoaiPhong { get; set; }
		public string TenLoaiPhong { get; set; }
		public string Gia { get; set; }
		public string DienTich { get; set; }
		public int SucChua { get; set; }
		public LoaiPhongDTO(DataRow dr)
		{
			this.ID_LoaiPhong = Convert.ToInt32(dr["ID_LoaiPhong"]);
			this.TenLoaiPhong = Convert.ToString(dr["TenLoaiPhong"]).Trim();
			this.Gia = Convert.ToString(dr["Gia"]).Trim();
			this.DienTich = Convert.ToString(dr["DienTich"]).Trim();
			this.SucChua = Convert.ToInt32(dr["SucChua"]);
		}
	}
}
