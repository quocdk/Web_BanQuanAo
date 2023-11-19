using Microsoft.AspNetCore.Mvc;
using WebData.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        public CuaHangDbContext context = new CuaHangDbContext();
        // GET: api/<SanPhamController>
        [HttpGet]
        public IEnumerable<SanPham> Get()
        {
            return context.SanPhams.ToList();
        }

        // GET api/<SanPhamController>/5
        [HttpGet("get-by-id")]
        public SanPham GetById(Guid id)
        {
            return context.SanPhams.Find(id);
        }

        [HttpGet("get-by-name")]
        public IEnumerable<SanPham> GetByName(string tenSanPham)
        {
            return context.SanPhams.Where(x => x.TenSanPham.Contains(tenSanPham)).ToList();
        }

        // POST api/<SanPhamController>
        [HttpPost("post-by-obj")]
        public bool PostByObj([FromBody] SanPham SanPham)
        {
            try
            {
                context.SanPhams.Add(SanPham);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost("post-by-params")]
        public bool PostByParams(Guid IdThuongHieu,Guid IdLoaiSanPham, string MaSanPham, string TenSanPham)
        {
            Guid id = Guid.NewGuid();
            SanPham SanPham = new SanPham
            {
                Id = id,
                IdThuongHieu = IdThuongHieu,
                IdLoaiSanPham = IdLoaiSanPham,
                MaSanPham= MaSanPham,
                TenSanPham = TenSanPham
            };
            try
            {
                context.SanPhams.Add(SanPham);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<SanPhamController>/5
        [HttpPut("put-by-obj")]
        public bool PutByObj([FromBody] SanPham SanPham)
        {
            SanPham SanPhamFrDb = context.SanPhams.Find(SanPham.Id);
            try
            {
                SanPhamFrDb.IdThuongHieu = SanPham.IdThuongHieu;
                SanPhamFrDb.IdLoaiSanPham = SanPham.IdLoaiSanPham;
                SanPhamFrDb.MaSanPham = SanPham.MaSanPham;
                SanPhamFrDb.TenSanPham = SanPham.TenSanPham;
                context.SanPhams.Update(SanPhamFrDb);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // DELETE api/<SanPhamController>/5
        [HttpGet("{id}")]
        public bool Delete(Guid id)
        {
            try
            {
                SanPham SanPham = context.SanPhams.Find(id);
                context.SanPhams.Remove(SanPham);
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
