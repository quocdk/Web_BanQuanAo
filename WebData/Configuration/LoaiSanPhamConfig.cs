using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebData.Models;

namespace WebData.Configuration
{
    public class LoaiSanPhamConfig : IEntityTypeConfiguration<LoaiSanPham>
    {
        public void Configure(EntityTypeBuilder<LoaiSanPham> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
