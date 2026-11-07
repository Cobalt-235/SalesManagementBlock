using Microsoft.Extensions.Logging;
using Quanlybangame.DAL;
using Quanlybangame.DTO;

namespace Quanlybangame.BLL
{
    public class CauhinhBLL
    {
        public static string Thumuc => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "QuanlybangameMoi");
        // Cấu hình ở DAL; không cần form kết nối hoặc file lưu mật khẩu.
        public static CauhinhDTO Doc() => SqlKetnoi.CauhinhMacdinh();
        public static string Kiemtra(CauhinhDTO c, string mk) => SqlKetnoi.Kiemtra(c, mk);
        public static void Khoitao(CauhinhDTO c, string mk, bool dulieumau) => SqlKetnoi.Khoitao(c, mk, dulieumau);
        public static CuahangBLL Ketnoi(CauhinhDTO c, string mk, ILogger<CuahangBLL> log)
        {
            string chuoi = SqlKetnoi.TaoChuoi(c, mk);
            SqlKetnoi.KiemtraDatabase(chuoi);
            log.LogInformation("Kết nối SQL Server thành công, database {Database}", c.Cosodulieu);
            return new CuahangBLL(new CuahangDAL(chuoi), log);
        }
    }
}
