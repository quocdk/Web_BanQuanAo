using Microsoft.AspNetCore.Mvc;
using WebData.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoaDonController : ControllerBase
    {
        public CuaHangDbContext context = new CuaHangDbContext();
        // GET: api/<HoaDonController>
        [HttpGet]
        public IEnumerable<HoaDon> Get()
        {
            return context.HoaDons.ToList();
        }

        // GET api/<HoaDonController>/5
        [HttpGet("get-by-id")]
        public HoaDon GetById(Guid id)
        {
            return context.HoaDons.Find(id);
        }

        

        // POST api/<HoaDonController>
        [HttpPost("post-by-obj")]
        public bool PostByObj([FromBody] HoaDon HoaDon)
        {
            try
            {
                context.HoaDons.Add(HoaDon);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost("post-by-params")]
        public bool PostByParams(Guid IdKhachHang, Guid IdNhanVien, DateTime NgayThanhToan, DateTime NgayShip, DateTime NgayNhan)
        {
            Guid id = Guid.NewGuid();
            HoaDon HoaDon = new HoaDon
            {
                Id = id,
                IdKhachHang = IdKhachHang,
                IdNhanVien=IdNhanVien,
                NgayThanhToan=NgayThanhToan,
                NgayShip = NgayShip,
                NgayNhan = NgayNhan
            };
            try
            {
                context.HoaDons.Add(HoaDon);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<HoaDonController>/5
        [HttpPut("put-by-obj")]
        public bool PutByObj([FromBody] HoaDon HoaDon)
        {
            HoaDon HoaDonFrDb = context.HoaDons.Find(HoaDon.Id);
            try
            {
                HoaDonFrDb.IdKhachHang = HoaDon.IdKhachHang;
                HoaDonFrDb.IdNhanVien = HoaDon.IdNhanVien;
                HoaDonFrDb.NgayThanhToan = HoaDon.NgayThanhToan;
                HoaDonFrDb.NgayShip = HoaDon.NgayShip;
                HoaDonFrDb.NgayNhan = HoaDon.NgayNhan;
                context.HoaDons.Update(HoaDonFrDb);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // DELETE api/<HoaDonController>/5
        [HttpGet("{id}")]
        public bool Delete(Guid id)
        {
            try
            {
                HoaDon HoaDon = context.HoaDons.Find(id);
                context.HoaDons.Remove(HoaDon);
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
