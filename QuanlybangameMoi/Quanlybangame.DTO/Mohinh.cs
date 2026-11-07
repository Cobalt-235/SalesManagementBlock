
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
}
