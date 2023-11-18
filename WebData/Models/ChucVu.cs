using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebData.Models
{
    public class ChucVu
    {
        public Guid Id { get; set; }
        public string TenChucVu { get; set; }
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
