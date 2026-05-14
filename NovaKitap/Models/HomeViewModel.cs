namespace NovaKitap.Models
{
    public class HomeViewModel
    {
        public List<Kitaplar> YeniCikanlar { get; set; } = new List<Kitaplar>();
        public List<Kitaplar> CokSatanlar { get; set; } = new List<Kitaplar>();
        public List<Kitaplar> Onerilenler { get; set; } = new List<Kitaplar>();

    }
}