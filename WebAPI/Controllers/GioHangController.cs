using Microsoft.AspNetCore.Mvc;
using WebData.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GioHangController : ControllerBase
    {
        public CuaHangDbContext context = new CuaHangDbContext();
        // GET: api/<GioHangController>
        [HttpGet]
        public IEnumerable<GioHang> Get()
        {
            return context.GioHangs.ToList();
        }

        // GET api/<GioHangController>/5
        [HttpGet("get-by-id")]
        public GioHang GetById(Guid id)
        {
            return context.GioHangs.Find(id);
        }

        

        // POST api/<GioHangController>
        [HttpPost("post-by-obj")]
        public bool PostByObj([FromBody] GioHang gioHang)
        {
            try
            {
                context.GioHangs.Add(gioHang);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost("post-by-params")]
        public bool PostByParams(Guid IdKhachHang, DateTime NgayTao)
        {
            Guid id = Guid.NewGuid();
            GioHang gioHang = new GioHang
            {
                Id = id,
                IdKhachHang = IdKhachHang,
                NgayTao= NgayTao
            };
            try
            {
                context.GioHangs.Add(gioHang);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<GioHangController>/5
        [HttpPut("put-by-obj")]
        public bool PutByObj([FromBody] GioHang gioHang)
        {
            GioHang gioHangFrDb = context.GioHangs.Find(gioHang.Id);
            try
            {
                gioHangFrDb.IdKhachHang = gioHang.IdKhachHang;
                gioHangFrDb.NgayTao = gioHang.NgayTao;
                context.GioHangs.Update(gioHangFrDb);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // DELETE api/<GioHangController>/5
        [HttpGet("{id}")]
        public bool Delete(Guid id)
        {
            try
            {
                GioHang gioHang = context.GioHangs.Find(id);
                context.GioHangs.Remove(gioHang);
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
