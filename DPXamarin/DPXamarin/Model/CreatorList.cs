using System.Collections.Generic;

namespace DPXamarin.Model
{
    public class CreatorList
    {
        public int available { get; set; }                      //available(int, optional): The number of total available creators in this list.Will always be greater than or equal to the "returned" value.,
        public int returned { get; set; }                       //returned(int, optional): The number of creators returned in this collection(up to 20).,
        public string collectionURI { get; set; }               //collectionURI(string, optional): The path to the full list of creators in this collection.,
        public ICollection<CreatorSummary> items { get; set; }  //items(Array[CreatorSummary], optional): The list of returned creators in this collection.
    }
}
