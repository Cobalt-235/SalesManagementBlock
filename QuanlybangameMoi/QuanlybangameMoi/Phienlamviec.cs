using Microsoft.Extensions.Logging;
using Quanlybangame.BLL;
using Quanlybangame.DTO;

namespace QuanlybangameMoi_UI;
internal static class Phienlamviec
{
    public static readonly ILoggerFactory Bolog = LoggerFactory.Create(b => b.SetMinimumLevel(LogLevel.Debug).AddProvider(new NhatkyProvider()));
    public static readonly ILogger Log = Bolog.CreateLogger("Giaodien");
    public static CauhinhDTO Cauhinh { get; private set; } = new();
    private static CuahangBLL? dichvu;
    public static bool DaKetnoi => dichvu != null;
    public static CuahangBLL Dichvu => dichvu ?? throw new InvalidOperationException("Chưa kết nối SQL Server. Bật dịch vụ SQLEXPRESS01, khởi tạo database bằng script đi kèm rồi bấm Kết nối lại.");
    public static void DocCauhinh() => Cauhinh = CauhinhBLL.Doc();
    public static async Task Ketnoi(CauhinhDTO c, string matkhau)
    {
        dichvu = null;
        var dv = await Task.Run(() => CauhinhBLL.Ketnoi(c, matkhau, Bolog.CreateLogger<CuahangBLL>()));
        Cauhinh = c; dichvu = dv;
    }
}