using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 

namespace QLKyTucXa.Models
{
    public class NhanVienDTO
    {
		public long ID_NhanVien { get; set; }
		public DateTime NgayBatDau { get; set; }
		public string Luong { get; set; }
		public NhanVienDTO(DataRow dr)
		{
			this.ID_NhanVien = Convert.ToInt64(dr["ID_NhanVien"]);
			this.NgayBatDau = Convert.ToDateTime(dr["NgayBatDau"]);
			this.Luong = Convert.ToString(dr["Luong"]).Trim();
		}
	}
}
