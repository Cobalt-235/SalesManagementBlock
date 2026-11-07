using System.Data;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;
using Quanlybangame.DTO;

namespace Quanlybangame.DAL;
public static partial class SqlKetnoi
{
    public static CauhinhDTO CauhinhMacdinh() => new()
    {
        Maychu = @".",
        Cosodulieu = "QuanLyBanGameMoi",
        XacthucWindows = true,
        TinChungchi = true
    };

    [GeneratedRegex("^[A-Za-z][A-Za-z0-9_]{0,63}$")]
    private static partial Regex TenDatabase();

    public static string TaoChuoi(CauhinhDTO cauhinh, string matkhau, bool master = false)
    {
        if (string.IsNullOrWhiteSpace(cauhinh.Maychu)) throw new ArgumentException("Vui lòng nhập tên máy chủ SQL Server.");
        if (!TenDatabase().IsMatch(cauhinh.Cosodulieu)) throw new ArgumentException("Tên database phải bắt đầu bằng chữ, chỉ gồm chữ không dấu, số và dấu gạch dưới, tối đa 64 ký tự.");
        var b = new SqlConnectionStringBuilder
        {
            DataSource = cauhinh.Maychu.Trim(),
            InitialCatalog = master ? "master" : cauhinh.Cosodulieu,
            IntegratedSecurity = cauhinh.XacthucWindows,
            TrustServerCertificate = cauhinh.TinChungchi,
            Encrypt = SqlConnectionEncryptOption.Mandatory,
            ConnectTimeout = 6,
            ApplicationName = "QuanlybangameMoi",
            PersistSecurityInfo = false
        };
        if (!cauhinh.XacthucWindows) { b.UserID = cauhinh.Taikhoan; b.Password = matkhau; }
        return b.ConnectionString;
    }

    public static string Kiemtra(CauhinhDTO cauhinh, string matkhau)
    {
        using var c = new SqlConnection(TaoChuoi(cauhinh, matkhau, true)); c.Open();
        using var l = new SqlCommand("SELECT CAST(SERVERPROPERTY('ProductVersion') AS nvarchar(80)) + N' • ' + CAST(SERVERPROPERTY('Edition') AS nvarchar(120));", c);
        return Convert.ToString(l.ExecuteScalar()) ?? "SQL Server";
    }

    public static void KiemtraDatabase(string chuoiketnoi)
    {
        using var c = new SqlConnection(chuoiketnoi); c.Open();
        using var l = new SqlCommand("IF OBJECT_ID(N'dbo.Phienbanhethong',N'U') IS NULL THROW 50001,N'Chưa có cấu trúc dữ liệu. Hãy chạy Database/Khoitao_QuanLyBanGameMoi.sql trong SSMS.',1; SELECT Phienban FROM dbo.Phienbanhethong;", c);
        if (Convert.ToInt32(l.ExecuteScalar()) != 1) throw new InvalidOperationException("Database không đúng phiên bản ứng dụng.");
    }
     public static void Khoitao(CauhinhDTO cauhinh, string matkhau, bool dulieumau)
    {
        using (var c = new SqlConnection(TaoChuoi(cauhinh, matkhau, true)))
        {
            c.Open();
            using var l = new SqlCommand("IF DB_ID(@ten) IS NULL EXEC(N'CREATE DATABASE [' + @ten + N']');", c) { CommandTimeout = 60 };
            l.Parameters.Add("@ten", SqlDbType.NVarChar, 64).Value = cauhinh.Cosodulieu;
            l.ExecuteNonQuery();
        }
        using var cs = new SqlConnection(TaoChuoi(cauhinh, matkhau)); cs.Open();
        using var t = cs.BeginTransaction();
        using (var khoa = new SqlCommand("DECLARE @r int; EXEC @r = sys.sp_getapplock @Resource=N'QuanlybangameMoi_Init',@LockMode='Exclusive',@LockOwner='Transaction',@LockTimeout=10000; IF @r<0 THROW 50001,N'Có phiên khác đang khởi tạo dữ liệu.',1;", cs, t)) khoa.ExecuteNonQuery();
        foreach (var ten in dulieumau ? new[] { "001_cautruc.sql", "002_dulieumau.sql" } : new[] { "001_cautruc.sql" })
        {
            using var s = Assembly.GetExecutingAssembly().GetManifestResourceStream($"Quanlybangame.DAL.Sql.{ten}") ?? throw new InvalidOperationException("Thiếu tài nguyên SQL.");
            using var r = new StreamReader(s);
            using var l = new SqlCommand(r.ReadToEnd(), cs, t) { CommandTimeout = 60 }; l.ExecuteNonQuery();
        }
        t.Commit();
    }
}
