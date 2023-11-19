using Microsoft.AspNetCore.Mvc;
using WebData.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamChiTietController : ControllerBase
    {
        public CuaHangDbContext context = new CuaHangDbContext();
        // GET: api/<SanPhamChiTietController>
        [HttpGet]
        public IEnumerable<SanPhamChiTiet> Get()
        {
            return context.SanPhamChiTiets.ToList();
        }

        // GET api/<SanPhamChiTietController>/5
       [HttpGet("get-by-id")]
        public SanPhamChiTiet GetById(Guid id)
        {
            return context.SanPhamChiTiets.Find(id);
        }

        

        // POST api/<SanPhamChiTietController>
        [HttpPost("post-by-obj")]
        public bool PostByObj([FromBody] SanPhamChiTiet SanPhamChiTiet)
        {
            try
            {
                context.SanPhamChiTiets.Add(SanPhamChiTiet);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost("post-by-params")]
        public bool PostByParams(Guid IdSanPham, Guid IdSize, Guid IdMauSac, int SoLuongTon, long GiaNhap, long GiaBan)
        {
            Guid id = Guid.NewGuid();
            SanPhamChiTiet SanPhamChiTiet = new SanPhamChiTiet
            {
                Id = id,
                IdSanPham = IdSanPham,
                IdSize = IdSize,
                IdMauSac = IdMauSac,
                SoLuongTon = SoLuongTon,
                GiaNhap = GiaNhap,
                GiaBan = GiaBan
            };
            try
            {
                context.SanPhamChiTiets.Add(SanPhamChiTiet);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<SanPhamChiTietController>/5
        [HttpPut("put-by-obj")]
        public bool PutByObj([FromBody] SanPhamChiTiet SanPhamChiTiet)
        {
            SanPhamChiTiet SanPhamChiTietFrDb = context.SanPhamChiTiets.Find(SanPhamChiTiet.Id);
            try
            {
                SanPhamChiTietFrDb.IdSanPham = SanPhamChiTiet.IdSanPham;
                SanPhamChiTietFrDb.IdSize = SanPhamChiTiet.IdSize;
                SanPhamChiTietFrDb.IdMauSac = SanPhamChiTiet.IdMauSac;
                SanPhamChiTietFrDb.SoLuongTon = SanPhamChiTiet.SoLuongTon;
                SanPhamChiTietFrDb.GiaNhap = SanPhamChiTiet.GiaNhap;
                SanPhamChiTietFrDb.GiaBan = SanPhamChiTiet.GiaBan;
                context.SanPhamChiTiets.Update(SanPhamChiTietFrDb);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // DELETE api/<SanPhamChiTietController>/5
        [HttpGet("{id}")]
        public bool Delete(Guid id)
        {
            try
            {
                SanPhamChiTiet SanPhamChiTiet = context.SanPhamChiTiets.Find(id);
                context.SanPhamChiTiets.Remove(SanPhamChiTiet);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
