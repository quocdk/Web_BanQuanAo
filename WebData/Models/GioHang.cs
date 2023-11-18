using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebData.Models
{
    public class GioHang
    {
        public Guid Id { get; set; }
        public Guid IdKhachHang { get; set; }
        public DateTime NgayTao { get; set; }
        public virtual KhachHang KhachHang { get; set;}
        public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; set; }

    }
}
