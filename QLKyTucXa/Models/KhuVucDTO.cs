using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKyTucXa.Models
{
    public class KhuVucDTO
    {
		public string ID_KhuVuc { get; set; }
		public string TenKhuVuc { get; set; }
		public KhuVucDTO(DataRow dr)
		{
			this.ID_KhuVuc = Convert.ToString(dr["ID_KhuVuc"]).Trim();
			this.TenKhuVuc = Convert.ToString(dr["TenKhuVuc"]).Trim();
		}
	}
}
