using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKyTucXa.Models
{
    public class DichVuDTO
    {
		public int ID_DichVu { get; set; }
		public string TenDichVu { get; set; }
		public string DonGia { get; set; }
		public bool TrangThai { get; set; }
		public DichVuDTO(DataRow dr)
		{
			this.ID_DichVu = Convert.ToInt32(dr["ID_DichVu"]);
			this.TenDichVu = Convert.ToString(dr["TenDichVu"]).Trim();
			this.DonGia = Convert.ToString(dr["DonGia"]).Trim();
			this.TrangThai = Convert.ToBoolean(dr["TrangThai"]);
		}
	}
}
