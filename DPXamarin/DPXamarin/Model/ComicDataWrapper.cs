
namespace DPXamarin.Model
{
    public class ComicDataWrapper
    {
        public int code { get; set; }                   //code(int, optional): The HTTP status code of the returned result.,
        public string status { get; set; }              //status (string, optional): A string description of the call status.,
        public string copyright { get; set; }           //copyright (string, optional): The copyright notice for the returned result.,
        public string attributionText { get; set; }     //attributionText(string, optional): The attribution notice for this result.Please display either this notice or the contents of the attributionHTML field on all screens which contain data from the Marvel Comics API.,
        public string attributionHTML { get; set; }     //attributionHTML (string, optional): An HTML representation of the attribution notice for this result. Please display either this notice or the contents of the attributionText field on all screens which contain data from the Marvel Comics API.,
        public ComicDataContainer data { get; set; }    //data (ComicDataContainer, optional): The results returned by the call.,
        public string etag { get; set; }                //etag (string, optional): A digest value of the content returned by the call.
    }
}
