using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebData.Models
{
    public class GioHangChiTiet
    {
        public Guid Id { get; set; }
        public Guid IdGioHang { get; set; }
        public Guid IdSanPhamChiTiet { get; set; }
        public int SoLuong { get; set; }
        public long DonGia { get; set; }
        public long DonGiaKhiGiam { get; set; }
        public string ImageUrl { get; set; }
        public virtual GioHang GioHang { get; set; }
        public virtual SanPhamChiTiet SanPhamChiTiet { get; set; }

    }
}
