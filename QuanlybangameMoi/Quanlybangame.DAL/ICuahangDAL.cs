using Quanlybangame.DTO;


namespace Quanlybangame.DAL
{
    internal interface ICuahangDAL
    {
        List<SanphamDTO> TimSanpham(string tukhoa, bool chiconhang = false);
        int LuuSanpham(SanphamDTO sanpham);
        void XoaSanpham(SanphamDTO sanpham);
        List<KhachhangDTO> TimKhachhang(string tukhoa);
        int LuuKhachhang(KhachhangDTO khachhang);
        void XoaKhachhang(KhachhangDTO khachhang);
        List<HoadonDTO> TimHoadon(DateTime tungay, DateTime denngay, string tukhoa, int? khachhangId = null);
        HoadonDTO DocHoadon(int id);
        int TaoHoadon(YeucaubanDTO yeucau);
        void HuyHoadon(int id, string lydo);
        void Nhapkho(NhapkhoDTO phieu);
        List<LichsukhoDTO> DocLichsukho(int? sanphamId);
        List<DoanhthuNgayDTO> DocDoanhthu(DateTime tungay, DateTime denngay);
    }
}
