﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebData.Models
{
    public class ThuongHieu
    {
        public Guid Id { get; set; }
        public string TenThuongHieu { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }

    }
}
