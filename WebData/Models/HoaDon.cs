using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebData.Models
{
    public class HoaDon
    {
        public Guid Id { get; set; }
        public Guid IdKhachHang { get; set; }
        public Guid IdNhanVien { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public DateTime NgayShip { get; set; }
        public DateTime NgayNhan { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    }
}
