using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebData.Models
{
    public class HoaDonChiTiet
    {
        public Guid Id { get; set; }
        public Guid IdHoaDon { get; set; }
        public Guid IdSanPhamChiTiet { get; set; }
        public int SoLuong { get; set; }
        public long DonGia { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPhamChiTiet SanPhamChiTiet { get; set; }

    }
}
