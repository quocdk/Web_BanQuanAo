using Microsoft.AspNetCore.Mvc;
using WebData.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangController : ControllerBase
    {
        public CuaHangDbContext context = new CuaHangDbContext();
        // GET: api/<KhachHangController>
        [HttpGet]
        public IEnumerable<KhachHang> Get()
        {
            return context.KhachHangs.ToList();
        }

        // GET api/<KhachHangController>/5
        [HttpGet("get-by-id")]
        public KhachHang GetById(Guid id)
        {
            return context.KhachHangs.Find(id);
        }

        [HttpGet("get-by-name")]
        public IEnumerable<KhachHang> GetByName(string Ten)
        {
            return context.KhachHangs.Where(x => x.Ten.Contains(Ten)).ToList();
        }

        // POST api/<KhachHangController>
        [HttpPost("post-by-obj")]
        public bool PostByObj([FromBody] KhachHang KhachHang)
        {
            try
            {
                context.KhachHangs.Add(KhachHang);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost("post-by-params")]
        public bool PostByParams(string Ten, string Ho, int GioiTinh, DateTime NgaySinh, string DiaChi, string SoDienThoai, string Email, string MatKhau)
        {
            Guid id = Guid.NewGuid();
            KhachHang KhachHang = new KhachHang
            {
                Id = id,
                Ten = Ten,
                Ho = Ho,
                GioiTinh = GioiTinh,
                NgaySinh= NgaySinh,
                DiaChi = DiaChi,
                SoDienThoai= SoDienThoai,
                Email = Email,
                MatKhau = MatKhau,
            };
            try
            {
                context.KhachHangs.Add(KhachHang);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<KhachHangController>/5
        [HttpPut("put-by-obj")]
        public bool PutByObj([FromBody] KhachHang KhachHang)
        {
            KhachHang KhachHangFrDb = context.KhachHangs.Find(KhachHang.Id);
            try
            {
                KhachHangFrDb.Ten = KhachHang.Ten;
                KhachHangFrDb.Ho = KhachHang.Ho;
                KhachHangFrDb.GioiTinh = KhachHang.GioiTinh;
                KhachHangFrDb.NgaySinh = KhachHang.NgaySinh;
                KhachHangFrDb.DiaChi = KhachHang.DiaChi;
                KhachHangFrDb.SoDienThoai = KhachHang.SoDienThoai;
                KhachHangFrDb.Email = KhachHang.Email;
                KhachHangFrDb.MatKhau = KhachHang.MatKhau;
                context.KhachHangs.Update(KhachHangFrDb);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // DELETE api/<KhachHangController>/5
        [HttpGet("{id}")]
        public bool Delete(Guid id)
        {
            try
            {
                KhachHang KhachHang = context.KhachHangs.Find(id);
                context.KhachHangs.Remove(KhachHang);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        [HttpGet("dang-nhap")]
        public string DangNhap(string SoDienThoai, string MatKhau)
        {
            var taiKhoan = context.KhachHangs.FirstOrDefault(x=>x.SoDienThoai==SoDienThoai);
            if (taiKhoan != null)
            {
                if (taiKhoan.MatKhau == MatKhau)
                {
                    var sdt = taiKhoan.SoDienThoai;
                    return sdt;
                }
                else return "Mật khẩu không đúng";
            }
            else return "Số điện thoại không tồn tại";
        }
        [HttpPost("dang-ky")]
        public bool DangKy(string Ten, string Ho, int GioiTinh, DateTime NgaySinh, string DiaChi, string SoDienThoai, string Email, string MatKhau)
        {
            Guid id = Guid.NewGuid();
            KhachHang KhachHang = new KhachHang
            {
                Id = id,
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
                context.KhachHangs.Add(KhachHang);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
