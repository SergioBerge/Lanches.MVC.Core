namespace Lanches.MVC.Core.Models
{
    public class LachesModels
    {
        public int ID { get; set; }
        public string Cliente { get; set; }
        public string Lanche { get; set; }
        public DateTime DateLanche { get; set; } = DateTime.Now;

    }
}
