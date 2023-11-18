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
    public class SanPhamConfig : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.ThuongHieu).WithMany(x => x.SanPhams).HasForeignKey(x => x.IdThuongHieu);
            builder.HasOne(x => x.LoaiSanPham).WithMany(x => x.SanPhams).HasForeignKey(x => x.IdLoaiSanPham);
        }
    }
}
