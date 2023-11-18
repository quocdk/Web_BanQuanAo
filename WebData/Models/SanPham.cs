using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebData.Models
{
    public class SanPham
    {
        public Guid Id { get; set; }
        public Guid IdThuongHieu { get; set; }
        public Guid IdLoaiSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }

        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
        public virtual ThuongHieu ThuongHieu { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
    }
}
