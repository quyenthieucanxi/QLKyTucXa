using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QLKyTucXa.Models
{
    public class HoaDonDTO
    {
		public long ID_HoaDon { get; set; }
		public long ID_NhanVien { get; set; }
		public string ID_Phong { get; set; }
		public DateTime ThoiGianTao { get; set; }
		public string TongTien { get; set; }
		public HoaDonDTO(DataRow dr)
		{
			this.ID_HoaDon = Convert.ToInt64(dr["ID_HoaDon"]);
			this.ID_NhanVien = Convert.ToInt64(dr["ID_NhanVien"]);
			this.ID_Phong = Convert.ToString(dr["ID_Phong"]).Trim();
			this.ThoiGianTao = Convert.ToDateTime(dr["ThoiGianTao"]);
			this.TongTien = Convert.ToString(dr["TongTien"]).Trim();
		}
	}
}
