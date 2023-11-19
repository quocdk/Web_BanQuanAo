using Microsoft.AspNetCore.Mvc;
using WebData.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizeController : ControllerBase
    {
        public CuaHangDbContext context = new CuaHangDbContext();
        // GET: api/<SizeController>
        [HttpGet]
        public IEnumerable<Size> Get()
        {
            return context.Sizes.ToList();
        }

        // GET api/<SizeController>/5
        [HttpGet("get-by-id")]
        public Size GetById(Guid id)
        {
            return context.Sizes.Find(id);
        }

        [HttpGet("get-by-name")]
        public IEnumerable<Size> GetByName(string tenSize)
        {
            return context.Sizes.Where(x => x.TenSize.Contains(tenSize)).ToList();
        }

        // POST api/<SizeController>
        [HttpPost("post-by-obj")]
        public bool PostByObj([FromBody] Size Size)
        {
            try
            {
                context.Sizes.Add(Size);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost("post-by-params")]
        public bool PostByParams(string tenSize)
        {
            Guid id = Guid.NewGuid();
            Size Size = new Size
            {
                Id = id,
                TenSize = tenSize
            };
            try
            {
                context.Sizes.Add(Size);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<SizeController>/5
        [HttpPut("put-by-obj")]
        public bool PutByObj([FromBody] Size Size)
        {
            Size SizeFrDb = context.Sizes.Find(Size.Id);
            try
            {
                SizeFrDb.TenSize = Size.TenSize;
                context.Sizes.Update(SizeFrDb);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // DELETE api/<SizeController>/5
        [HttpGet("{id}")]
        public bool Delete(Guid id)
        {
            try
            {
                Size Size = context.Sizes.Find(id);
                context.Sizes.Remove(Size);
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
