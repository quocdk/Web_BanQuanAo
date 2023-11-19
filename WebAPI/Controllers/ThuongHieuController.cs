using Microsoft.AspNetCore.Mvc;
using WebData.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThuongHieuController : ControllerBase
    {
        public CuaHangDbContext context = new CuaHangDbContext();
        // GET: api/<ThuongHieuController>
        [HttpGet]
        public IEnumerable<ThuongHieu> Get()
        {
            return context.ThuongHieus.ToList();
        }

        // GET api/<ThuongHieuController>/5
        [HttpGet("get-by-id")]
        public ThuongHieu GetById(Guid id)
        {
            return context.ThuongHieus.Find(id);
        }

        [HttpGet("get-by-name")]
        public IEnumerable<ThuongHieu> GetByName(string tenThuongHieu)
        {
            return context.ThuongHieus.Where(x => x.TenThuongHieu.Contains(tenThuongHieu)).ToList();
        }

        // POST api/<ThuongHieuController>
        [HttpPost("post-by-obj")]
        public bool PostByObj([FromBody] ThuongHieu ThuongHieu)
        {
            try
            {
                context.ThuongHieus.Add(ThuongHieu);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost("post-by-params")]
        public bool PostByParams(string tenThuongHieu)
        {
            Guid id = Guid.NewGuid();
            ThuongHieu ThuongHieu = new ThuongHieu
            {
                Id = id,
                TenThuongHieu = tenThuongHieu
            };
            try
            {
                context.ThuongHieus.Add(ThuongHieu);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<ThuongHieuController>/5
        [HttpPut("put-by-obj")]
        public bool PutByObj([FromBody] ThuongHieu ThuongHieu)
        {
            ThuongHieu ThuongHieuFrDb = context.ThuongHieus.Find(ThuongHieu.Id);
            try
            {
                ThuongHieuFrDb.TenThuongHieu = ThuongHieu.TenThuongHieu;
                context.ThuongHieus.Update(ThuongHieuFrDb);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // DELETE api/<ThuongHieuController>/5
        [HttpGet("{id}")]
        public bool Delete(Guid id)
        {
            try
            {
                ThuongHieu ThuongHieu = context.ThuongHieus.Find(id);
                context.ThuongHieus.Remove(ThuongHieu);
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
