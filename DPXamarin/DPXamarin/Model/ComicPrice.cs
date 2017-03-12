
namespace DPXamarin.Model
{
    public class ComicPrice
    {
        public string type { get; set; }        //type(string, optional): A description of the price(e.g.print price, digital price).,
        public float price { get; set; }        //price(float, optional): The price(all prices in USD).
    }
}
