using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKyTucXa.Models
{
    public  class ThanNhanDTO
    {
		public long ID_NguoiDung { get; set; }
		public long ID_ThanNhan { get; set; }
		public string QuanHe { get; set; }
		public ThanNhanDTO(DataRow dr)
		{
			this.ID_NguoiDung = Convert.ToInt64(dr["ID_NguoiDung"]);
			this.ID_ThanNhan = Convert.ToInt64(dr["ID_ThanNhan"]);
			this.QuanHe = Convert.ToString(dr["QuanHe"]).Trim();
		}
	}
}
