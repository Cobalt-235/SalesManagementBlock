using Quanlybangame.DAL;
using Quanlybangame.DTO;

namespace Quanlybangame.Tests;

internal sealed class DalGia : ICuahangDAL
{
    public SanphamDTO? SanphamDaLuu { get; private set; }
    public KhachhangDTO? KhachDaLuu { get; private set; }
    public YeucaubanDTO? YeucauDaLuu { get; private set; }
    public NhapkhoDTO? PhieuDaLuu { get; private set; }
    public int SolanGhi { get; private set; }
    public List<DoanhthuNgayDTO> Doanhthu { get; set; } = [];
    public Exception? LoiKhiGhi { get; set; }
    private void Ghi() { if (LoiKhiGhi != null) throw LoiKhiGhi; SolanGhi++; }
    public int LuuSanpham(SanphamDTO s) { Ghi(); SanphamDaLuu = s; return s.Id == 0 ? 1 : s.Id; }
    public int LuuKhachhang(KhachhangDTO k) { Ghi(); KhachDaLuu = k; return k.Id == 0 ? 2 : k.Id; }
    public int TaoHoadon(YeucaubanDTO y) { Ghi(); YeucauDaLuu = y; return 9; }
    public void Nhapkho(NhapkhoDTO p) { Ghi(); PhieuDaLuu = p; }
    public void XoaSanpham(SanphamDTO s) => Ghi();
    public void XoaKhachhang(KhachhangDTO k) => Ghi();
    public void HuyHoadon(int id, string lydo) => Ghi();
    public List<SanphamDTO> TimSanpham(string tukhoa, bool chiconhang = false) => [];
    public List<KhachhangDTO> TimKhachhang(string tukhoa) => [];
    public List<HoadonDTO> TimHoadon(DateTime tungay, DateTime denngay, string tukhoa, int? khachhangId = null) => [];
    public HoadonDTO DocHoadon(int id) => new() { Id = id };
    public List<LichsukhoDTO> DocLichsukho(int? id) => [];
    public List<DoanhthuNgayDTO> DocDoanhthu(DateTime tungay, DateTime denngay) => Doanhthu;
}
