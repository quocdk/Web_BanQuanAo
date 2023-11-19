using Microsoft.AspNetCore.Mvc;
using WebData.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GioHangChiTietController : ControllerBase
    {
        public CuaHangDbContext context = new CuaHangDbContext();
        // GET: api/<GioHangChiTietController>
        [HttpGet]
        public IEnumerable<GioHangChiTiet> Get()
        {
            return context.GioHangChiTiets.ToList();
        }

        // GET api/<GioHangChiTietController>/5
        [HttpGet("get-by-id")]
        public GioHangChiTiet GetById(Guid id)
        {
            return context.GioHangChiTiets.Find(id);
        }

        // POST api/<GioHangChiTietController>
        [HttpPost("post-by-obj")]
        public bool PostByObj([FromBody] GioHangChiTiet gioHangChiTiet)
        {
            try
            {
                context.GioHangChiTiets.Add(gioHangChiTiet);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost("post-by-params")]
        public bool PostByParams(Guid IdGioHang, Guid IdSanPhamChiTiet, int SoLuong, long DonGia, long DonGiaKhiGiam, string ImageUrl)
        {
            Guid id = Guid.NewGuid();
            GioHangChiTiet gioHangChiTiet = new GioHangChiTiet
            {
                Id = id,
                IdGioHang = IdGioHang,
                IdSanPhamChiTiet = IdSanPhamChiTiet,
                SoLuong = SoLuong,
                DonGia = DonGia,
                DonGiaKhiGiam = DonGiaKhiGiam,
                ImageUrl = ImageUrl
            };
            try
            {
                context.GioHangChiTiets.Add(gioHangChiTiet);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // PUT api/<GioHangChiTietController>/5
        [HttpPut("put-by-obj")]
        public bool PutByObj([FromBody] GioHangChiTiet gioHangChiTiet)
        {
            GioHangChiTiet gioHangChiTietFrDb = context.GioHangChiTiets.Find(gioHangChiTiet.Id);
            try
            {
                gioHangChiTietFrDb.IdGioHang = gioHangChiTiet.IdGioHang;
                gioHangChiTietFrDb.IdSanPhamChiTiet = gioHangChiTiet.IdSanPhamChiTiet;
                gioHangChiTietFrDb.SoLuong = gioHangChiTiet.SoLuong;
                gioHangChiTietFrDb.DonGia = gioHangChiTiet.DonGia;
                gioHangChiTietFrDb.DonGiaKhiGiam = gioHangChiTiet.DonGiaKhiGiam;
                gioHangChiTietFrDb.ImageUrl = gioHangChiTiet.ImageUrl;
                context.GioHangChiTiets.Update(gioHangChiTietFrDb);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // DELETE api/<GioHangChiTietController>/5
        [HttpGet("{id}")]
        public bool Delete(Guid id)
        {
            try
            {
                GioHangChiTiet gioHangChiTiet = context.GioHangChiTiets.Find(id);
                context.GioHangChiTiets.Remove(gioHangChiTiet);
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
