
namespace Quanlybangame.DTO
{
    public sealed class SanphamDTO
    {
        public int Id { get; set; }
        public string Ma { get; set; } = "";
        public string Ten { get; set; } = "";
        public string Theloai { get; set; } = "";
        public string Nentang { get; set; } = "PC";
        public string Nhaphathanh { get; set; } = "";
        public decimal Gianhap { get; set; }
        public decimal Giaban { get; set; }
        public int Tonkho { get; set; }
        public int TonToithieu { get; set; } = 5;
        public bool Dangban { get; set; } = true;
        public string Mota { get; set; } = "";
        public byte[] Phienban { get; set; } = [];
        public string Trangthai => !Dangban ? "Ngừng bán" : Tonkho == 0 ? "Hết hàng" : Tonkho <= TonToithieu ? "Sắp hết" : "Còn hàng";
        public string Hienthi => $"{Ma} • {Ten} [{Nentang}]";
    }
    public sealed class KhachhangDTO
    {
        public int Id { get; set; }
        public string Ma { get; set; } = "";
        public string Hoten { get; set; } = "";
        public string Dienthoai { get; set; } = "";
        public string Email { get; set; } = "";
        public string Diachi { get; set; } = "";
        public byte[] Phienban { get; set; } = [];
        public override string ToString() => Id == 0 ? "Khách lẻ" : $"{Ma} • {Hoten}";
    }
    public sealed class DongbanDTO
    {
        public int SanphamId { get; set; }
        public string Ma { get; set; } = "";
        public string Ten { get; set; } = "";
        public decimal Dongia { get; set; }
        public int Soluong { get; set; }
        public decimal Thanhtien => Dongia * Soluong;
    }


    public sealed class YeucaubanDTO
    {
        public Guid YeucauId { get; set; } = Guid.NewGuid();
        public string MaBam { get; set; } = "";
        public int? KhachhangId { get; set; }
        public decimal Giamgia { get; set; }
        public string Ghichu { get; set; } = "";
        public List<DongbanDTO> Chitiet { get; set; } = [];
    }

    public sealed class HoadonDTO
    {
        public int Id { get; set; }
        public string Ma => $"HD{Id:000000}";
        public DateTime Ngaylap { get; set; }
        public string Khachhang { get; set; } = "Khách lẻ";
        public string Dienthoai { get; set; } = "";
        public decimal Tamtinh { get; set; }
        public decimal Giamgia { get; set; }
        public decimal Tongtien { get; set; }
        public string Trangthai { get; set; } = "Đã thanh toán";
        public string Ghichu { get; set; } = "";
        public string LydoHuy { get; set; } = "";
        public List<DongbanDTO> Chitiet { get; set; } = [];
    }

    public sealed class NhapkhoDTO
    {
        public Guid YeucauId { get; set; } = Guid.NewGuid();
        public string MaBam { get; set; } = "";
        public int SanphamId { get; set; }
        public int Soluong { get; set; }
        public decimal Dongia { get; set; }
        public string Nhacungcap { get; set; } = "";
        public string Ghichu { get; set; } = "";
    }
}
