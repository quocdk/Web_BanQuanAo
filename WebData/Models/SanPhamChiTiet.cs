using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebData.Models
{
    public class SanPhamChiTiet
    {
        public Guid Id { get; set; }
        public Guid IdSanPham { get; set; }
        public Guid IdSize { get; set; }
        public Guid IdMauSac { get; set; }
        public int SoLuongTon { get; set; }
        public long GiaNhap { get; set; }
        public long GiaBan { get; set; }
        public virtual SanPham SanPham { get; set; }
        public virtual MauSac MauSac { get; set; }
        public virtual Size Size { get; set; }
        public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
