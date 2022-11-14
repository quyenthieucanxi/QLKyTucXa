using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKyTucXa.Models
{
    public class PhongDTO
    {
		public string ID_Phong { get; set; }
		public string ID_KhuVuc { get; set; }
		public int ID_LoaiPhong { get; set; }
		public PhongDTO(DataRow dr)
		{
			this.ID_Phong = Convert.ToString(dr["ID_Phong"]).Trim();
			this.ID_KhuVuc = Convert.ToString(dr["ID_KhuVuc"]).Trim();
			this.ID_LoaiPhong = Convert.ToInt32(dr["ID_LoaiPhong"]);
		}
	}
}
