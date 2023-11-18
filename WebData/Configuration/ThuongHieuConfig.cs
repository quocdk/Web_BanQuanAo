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
    public class ThuongHieuConfig : IEntityTypeConfiguration<ThuongHieu>
    {
        public void Configure(EntityTypeBuilder<ThuongHieu> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
