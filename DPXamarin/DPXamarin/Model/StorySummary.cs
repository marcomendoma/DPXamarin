
namespace DPXamarin.Model
{
    public class StorySummary
    {
        public string resourceURI { get; set; }     //resourceURI(string, optional): The path to the individual story resource.,
        public string name { get; set; }            //name(string, optional): The canonical name of the story.,
        public string type { get; set; }            //type (string, optional): The type of the story(interior or cover).
    }
}
