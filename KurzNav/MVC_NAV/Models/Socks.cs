namespace MVC_NAV.Models
{
    public class Socks
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public SocksSize Size { get; set; }

        public decimal Price { get; set; }
        public int OnStock { get; set; }   

    }

    //public class SockDetails : Sock
    //{
    //    public Material Material { get; set; }
    //    public string Color { get; set; }
    //    public string Pattern { get; set; }
    //    public bool IsWarm { get; set; }
    //    public bool IsWaterproof { get; set; }
    //}

    public enum Material
    {
        Cotton,
        Wool,
        Synthetic
    }

    public enum SocksSize
    {
        S, //Small,
        M, //Medium,
        L, //Large
        X,
        XL,
        XXL,
        XXXL
    }

}
