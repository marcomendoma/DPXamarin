using System.Collections.Generic;

namespace DPXamarin.Model
{
    public class StoryList
    {
        public int available { get; set; }                      //available(int, optional): The number of total available stories in this list.Will always be greater than or equal to the "returned" value.,
        public int returned { get; set; }                       //returned(int, optional): The number of stories returned in this collection(up to 20).,
        public string collectionURI { get; set; }               //collectionURI(string, optional): The path to the full list of stories in this collection.,
        public ICollection<StorySummary> items { get; set; }    //items(Array[StorySummary], optional): The list of returned stories in this collection.
    }
}
