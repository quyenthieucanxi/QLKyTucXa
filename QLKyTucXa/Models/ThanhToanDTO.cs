using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QLKyTucXa.Models
{
    public class ThanhToanDTO
    {
		public long ID_ThanhToan { get; set; }
		public long ID_HoaDon { get; set; }
		public long ID_NhanVien { get; set; }
		public DateTime NgayThanhToan { get; set; }
		public string SoTien { get; set; }
		public ThanhToanDTO(DataRow dr)
		{
			this.ID_ThanhToan = Convert.ToInt64(dr["ID_ThanhToan"]);
			this.ID_HoaDon = Convert.ToInt64(dr["ID_HoaDon"]);
			this.ID_NhanVien = Convert.ToInt64(dr["ID_NhanVien"]);
			this.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
			this.SoTien = Convert.ToString(dr["SoTien"]).Trim();
		}
	}
}
