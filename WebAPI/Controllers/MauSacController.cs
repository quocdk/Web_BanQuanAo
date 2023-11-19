using Microsoft.AspNetCore.Mvc;
using WebData.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MauSacController : ControllerBase
    {
        public CuaHangDbContext context = new CuaHangDbContext();
        // GET: api/<MauSacController>
        [HttpGet]
        public IEnumerable<MauSac> Get()
        {
            return context.MauSacs.ToList();
        }

        // GET api/<MauSacController>/5
        [HttpGet("get-by-id")]
        public MauSac GetById(Guid id)
        {
            return context.MauSacs.Find(id);
        }

        [HttpGet("get-by-name")]
        public IEnumerable<MauSac> GetByName(string tenMauSac)
        {
            return context.MauSacs.Where(x => x.TenMauSac.Contains(tenMauSac)).ToList();
        }

        // POST api/<MauSacController>
        [HttpPost("post-by-obj")]
        public bool PostByObj([FromBody] MauSac MauSac)
        {
            try
            {
                context.MauSacs.Add(MauSac);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost("post-by-params")]
        public bool PostByParams(string tenMauSac)
        {
            Guid id = Guid.NewGuid();
            MauSac MauSac = new MauSac
            {
                Id = id,
                TenMauSac = tenMauSac
            };
            try
            {
                context.MauSacs.Add(MauSac);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<MauSacController>/5
        [HttpPut("put-by-obj")]
        public bool PutByObj([FromBody] MauSac MauSac)
        {
            MauSac MauSacFrDb = context.MauSacs.Find(MauSac.Id);
            try
            {
                MauSacFrDb.TenMauSac = MauSac.TenMauSac;
                context.MauSacs.Update(MauSacFrDb);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // DELETE api/<MauSacController>/5
        [HttpGet("{id}")]
        public bool Delete(Guid id)
        {
            try
            {
                MauSac MauSac = context.MauSacs.Find(id);
                context.MauSacs.Remove(MauSac);
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
