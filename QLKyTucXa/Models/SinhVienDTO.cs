using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKyTucXa.Models
{
    public class SinhVienDTO
    {
		public long ID_SinhVien { get; set; }
		public string MSSV { get; set; }
		public int ID_Truong { get; set; }
		public string Khoa	 { get; set; }
		public string Nganh { get; set; }
		public SinhVienDTO(DataRow dr)
		{
			this.ID_SinhVien = Convert.ToInt64(dr["ID_SinhVien"]);
			this.MSSV = Convert.ToString(dr["MSSV"]).Trim();
			this.ID_Truong = Convert.ToInt32(dr["ID_Truong"]);
			this.Khoa = Convert.ToString(dr["Khoa"]).Trim();
			this.Nganh = Convert.ToString(dr["Nganh"]).Trim();
		}
	}
}
