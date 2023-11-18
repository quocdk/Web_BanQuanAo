using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebData.Models
{
    public class NhanVien
    {
        public Guid Id { get; set; }
        public Guid IdChucVu { get; set; }
        public string Ten { get; set; }
        public string Ho { get; set; }
        public int GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public virtual ChucVu ChucVu { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
