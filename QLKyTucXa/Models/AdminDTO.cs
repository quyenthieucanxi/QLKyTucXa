using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKyTucXa.Models
{
    public class AdminDTO
    {
        public long ID_Admin { get; set; }
        public AdminDTO(DataRow dr)
        {
            this.ID_Admin = Convert.ToInt64(dr["ID_Admin"]);
        }
    }
}
