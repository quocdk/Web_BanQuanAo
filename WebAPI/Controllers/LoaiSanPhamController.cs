using Microsoft.AspNetCore.Mvc;
using WebData.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiSanPhamController : ControllerBase
    {
        public CuaHangDbContext context = new CuaHangDbContext();
        // GET: api/<LoaiSanPhamController>
        [HttpGet]
        public IEnumerable<LoaiSanPham> Get()
        {
            return context.LoaiSanPhams.ToList();
        }

        // GET api/<LoaiSanPhamController>/5
        [HttpGet("get-by-id")]
        public LoaiSanPham GetById(Guid id)
        {
            return context.LoaiSanPhams.Find(id);
        }

        [HttpGet("get-by-name")]
        public IEnumerable<LoaiSanPham> GetByName(string tenLoaiSanPham)
        {
            return context.LoaiSanPhams.Where(x => x.TenLoaiSanPham.Contains(tenLoaiSanPham)).ToList();
        }

        // POST api/<LoaiSanPhamController>
        [HttpPost("post-by-obj")]
        public bool PostByObj([FromBody] LoaiSanPham LoaiSanPham)
        {
            try
            {
                context.LoaiSanPhams.Add(LoaiSanPham);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost("post-by-params")]
        public bool PostByParams(string tenLoaiSanPham)
        {
            Guid id = Guid.NewGuid();
            LoaiSanPham LoaiSanPham = new LoaiSanPham
            {
                Id = id,
                TenLoaiSanPham = tenLoaiSanPham
            };
            try
            {
                context.LoaiSanPhams.Add(LoaiSanPham);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<LoaiSanPhamController>/5
        [HttpPut("put-by-obj")]
        public bool PutByObj([FromBody] LoaiSanPham LoaiSanPham)
        {
            LoaiSanPham LoaiSanPhamFrDb = context.LoaiSanPhams.Find(LoaiSanPham.Id);
            try
            {
                LoaiSanPhamFrDb.TenLoaiSanPham = LoaiSanPham.TenLoaiSanPham;
                context.LoaiSanPhams.Update(LoaiSanPhamFrDb);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // DELETE api/<LoaiSanPhamController>/5
        [HttpGet("{id}")]
        public bool Delete(Guid id)
        {
            try
            {
                LoaiSanPham LoaiSanPham = context.LoaiSanPhams.Find(id);
                context.LoaiSanPhams.Remove(LoaiSanPham);
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
