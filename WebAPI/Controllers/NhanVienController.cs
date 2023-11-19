using Microsoft.AspNetCore.Mvc;
using WebData.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        public CuaHangDbContext context = new CuaHangDbContext();
        // GET: api/<NhanVienController>
        [HttpGet]
        public IEnumerable<NhanVien> Get()
        {
            return context.NhanViens.ToList();
        }

        // GET api/<NhanVienController>/5
        [HttpGet("get-by-id")]
        public NhanVien GetById(Guid id)
        {
            return context.NhanViens.Find(id);
        }

        [HttpGet("get-by-name")]
        public IEnumerable<NhanVien> GetByName(string Ten)
        {
            return context.NhanViens.Where(x => x.Ten.Contains(Ten)).ToList();
        }

        // POST api/<NhanVienController>
        [HttpPost("post-by-obj")]
        public bool PostByObj([FromBody] NhanVien NhanVien)
        {
            try
            {
                context.NhanViens.Add(NhanVien);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost("post-by-params")]
        public bool PostByParams(Guid IdChucVu ,string Ten, string Ho, int GioiTinh, DateTime NgaySinh, string DiaChi, string SoDienThoai, string Email, string MatKhau)
        {
            Guid id = Guid.NewGuid();
            NhanVien NhanVien = new NhanVien
            {
                Id = id,
                IdChucVu = IdChucVu,
                Ten = Ten,
                Ho = Ho,
                GioiTinh = GioiTinh,
                NgaySinh = NgaySinh,
                DiaChi = DiaChi,
                SoDienThoai = SoDienThoai,
                Email = Email,
                MatKhau = MatKhau,
            };
            try
            {
                context.NhanViens.Add(NhanVien);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<NhanVienController>/5
        [HttpPut("put-by-obj")]
        public bool PutByObj([FromBody] NhanVien NhanVien)
        {
            NhanVien NhanVienFrDb = context.NhanViens.Find(NhanVien.Id);
            try
            {

                NhanVienFrDb.IdChucVu = NhanVien.IdChucVu;
                NhanVienFrDb.Ten = NhanVien.Ten;
                NhanVienFrDb.Ho = NhanVien.Ho;
                NhanVienFrDb.GioiTinh = NhanVien.GioiTinh;
                NhanVienFrDb.NgaySinh = NhanVien.NgaySinh;
                NhanVienFrDb.DiaChi = NhanVien.DiaChi;
                NhanVienFrDb.SoDienThoai = NhanVien.SoDienThoai;
                NhanVienFrDb.Email = NhanVien.Email;
                NhanVienFrDb.MatKhau = NhanVien.MatKhau;
                context.NhanViens.Update(NhanVienFrDb);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // DELETE api/<NhanVienController>/5
        [HttpGet("{id}")]
        public bool Delete(Guid id)
        {
            try
            {
                NhanVien NhanVien = context.NhanViens.Find(id);
                context.NhanViens.Remove(NhanVien);
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
