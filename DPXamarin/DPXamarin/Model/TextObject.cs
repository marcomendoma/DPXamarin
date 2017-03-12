
namespace DPXamarin.Model
{
    public class TextObject
    {
        public string type { get; set; }        //type(string, optional): The canonical type of the text object (e.g.solicit text, preview text, etc.).,
        public string language { get; set; }    //language(string, optional): The IETF language tag denoting the language the text object is written in.,
        public string text { get; set; }        //text(string, optional): The text.
    }
}
