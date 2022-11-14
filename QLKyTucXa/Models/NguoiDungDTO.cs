using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKyTucXa.Models
{
     public class NguoiDungDTO
    {
        public long ID_NguoiDung { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SoCanCuoc { get; set; }
        public long ID_DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string LoaiNguoiDung { get; set; }
        public bool TrangThai { get; set; }
        public NguoiDungDTO (DataRow dr)
        {
            this.ID_NguoiDung = Convert.ToInt64(dr["ID_NguoiDung"]);
            this.Ho = Convert.ToString(dr["Ho"]).Trim();
            this.Ten = Convert.ToString(dr["Ten"]).Trim();
            this.NgaySinh = Convert.ToDateTime(dr["NgaySinh"]);
            this.GioiTinh = Convert.ToString(dr["GioiTinh"]).Trim();
            this.SoCanCuoc = Convert.ToString(dr["SoCanCuoc"]).Trim();
            this.ID_DiaChi = Convert.ToInt64(dr["ID_DiaChi"]);
            this.SDT = Convert.ToString(dr["SDT"]).Trim();
            this.Email = Convert.ToString(dr["Email"]).Trim();
            this.TenDangNhap = Convert.ToString(dr["TenDangNhap"]).Trim();
            this.MatKhau = Convert.ToString(dr["MatKhau"]).Trim();
            this.LoaiNguoiDung = Convert.ToString(dr["LoaiNguoiDung"]).Trim();
            this.TrangThai = Convert.ToBoolean(dr["TrangThai"]);
        }


    }
}
