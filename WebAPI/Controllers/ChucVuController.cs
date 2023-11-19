using Microsoft.AspNetCore.Mvc;
using WebData.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChucVuController : ControllerBase
    {
        public CuaHangDbContext context = new CuaHangDbContext();
        // GET: api/<ChucVuController>
        [HttpGet]
        public IEnumerable<ChucVu> Get()
        {
            return context.ChucVus.ToList();
        }

        // GET api/<ChucVuController>/5
        [HttpGet("get-by-id")]
        public ChucVu GetById(Guid id)
        {
            return context.ChucVus.Find(id);
        }

        [HttpGet("get-by-name")]
        public IEnumerable<ChucVu> GetByName(string tenChucVu)
        {
            return context.ChucVus.Where(x => x.TenChucVu.Contains(tenChucVu)).ToList();
        }
        // POST api/<ChucVuController>
        [HttpPost("post-by-obj")]
        public bool PostByObj([FromBody] ChucVu chucVu)
        {
            try
            {
                context.ChucVus.Add(chucVu);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost("post-by-params")]
        public bool PostByParams(string tenChucVu)
        {
            Guid id = Guid.NewGuid();
            ChucVu chucVu = new ChucVu
            {
                Id = id,
                TenChucVu = tenChucVu
            };
            try
            {
                context.ChucVus.Add(chucVu);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<ChucVuController>/5
        [HttpPut("put-by-obj")]
        public bool PutByObj([FromBody] ChucVu chucVu)
        {
            ChucVu chucVuFrDb = context.ChucVus.Find(chucVu.Id);
            try
            {
                chucVuFrDb.TenChucVu = chucVu.TenChucVu;
                context.ChucVus.Update(chucVuFrDb);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // DELETE api/<ChucVuController>/5
        [HttpGet("{id}")]
        public bool Delete(Guid id)
        {
            try
            {
                ChucVu chucVu = context.ChucVus.Find(id);
                context.ChucVus.Remove(chucVu);
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
