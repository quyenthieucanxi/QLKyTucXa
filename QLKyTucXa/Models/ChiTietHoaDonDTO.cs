using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKyTucXa.Models
{
     public class ChiTietHoaDonDTO
    {
		public long ID_ChiTietHoaDon { get; set; }
		public long ID_HoaDon { get; set; }
		public int ID_DichVu { get; set; }
		public int SoCu { get; set; }
		public int SoMoi { get; set; }
		public decimal ThanhTien { get; set; }
		public string TenDichVu { get; set; }
		public ChiTietHoaDonDTO(DataRow dr)
		{
			this.ID_ChiTietHoaDon = Convert.ToInt64(dr["ID_ChiTietHoaDon"]);
			this.ID_HoaDon = Convert.ToInt64(dr["ID_HoaDon"]);
			this.ID_DichVu = Convert.ToInt32(dr["ID_DichVu"]);
			this.SoCu = Convert.ToInt32(dr["SoCu"]);
			this.SoMoi = Convert.ToInt32(dr["SoMoi"]);
			this.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
			this.TenDichVu = Convert.ToString(dr["ServiceName"]);
		}
	}
}
