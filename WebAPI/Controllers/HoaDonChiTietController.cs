using Microsoft.AspNetCore.Mvc;
using WebData.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoaDonChiTietController : ControllerBase
    {
        public CuaHangDbContext context = new CuaHangDbContext();
        // GET: api/<HoaDonChiTietController>
        [HttpGet]
        public IEnumerable<HoaDonChiTiet> Get()
        {
            return context.HoaDonChiTiets.ToList();
        }

        // GET api/<HoaDonChiTietController>/5
        [HttpGet("get-by-id")]
        public HoaDonChiTiet GetById(Guid id)
        {
            return context.HoaDonChiTiets.Find(id);
        }

        

        // POST api/<HoaDonChiTietController>
        [HttpPost("post-by-obj")]
        public bool PostByObj([FromBody] HoaDonChiTiet hoaDonChiTiet)
        {
            try
            {
                context.HoaDonChiTiets.Add(hoaDonChiTiet);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost("post-by-params")]
        public bool PostByParams(Guid IdHoaDon, Guid IdSanPhamChiTiet, int SoLuong, long DonGia)
        {
            Guid id = Guid.NewGuid();
            HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet
            {
                Id = id,
                IdHoaDon = IdHoaDon,
                IdSanPhamChiTiet=IdSanPhamChiTiet,
                SoLuong = SoLuong,
                DonGia = DonGia
            };
            try
            {
                context.HoaDonChiTiets.Add(hoaDonChiTiet);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<HoaDonChiTietController>/5
        [HttpPut("put-by-obj")]
        public bool PutByObj([FromBody] HoaDonChiTiet hoaDonChiTiet)
        {
            HoaDonChiTiet hoaDonChiTietFrDb = context.HoaDonChiTiets.Find(hoaDonChiTiet.Id);
            try
            {
                hoaDonChiTietFrDb.IdHoaDon = hoaDonChiTiet.IdHoaDon;
                hoaDonChiTietFrDb.IdSanPhamChiTiet = hoaDonChiTiet.IdSanPhamChiTiet;
                hoaDonChiTietFrDb.SoLuong = hoaDonChiTiet.SoLuong;
                hoaDonChiTietFrDb.DonGia = hoaDonChiTiet.DonGia;
                context.HoaDonChiTiets.Update(hoaDonChiTietFrDb);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // DELETE api/<HoaDonChiTietController>/5
        [HttpGet("{id}")]
        public bool Delete(Guid id)
        {
            try
            {
                HoaDonChiTiet hoaDonChiTiet = context.HoaDonChiTiets.Find(id);
                context.HoaDonChiTiets.Remove(hoaDonChiTiet);
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
