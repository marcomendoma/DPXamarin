using System.Collections.Generic;

namespace DPXamarin.Model
{
    public class EventList
    {
        public int available { get; set; }                      //available(int, optional): The number of total available events in this list.Will always be greater than or equal to the "returned" value.,
        public int returned { get; set; }                       //returned(int, optional): The number of events returned in this collection(up to 20).,
        public string collectionURI { get; set; }               //collectionURI(string, optional): The path to the full list of events in this collection.,
        public ICollection<EventSummary> items { get; set; }    //items(Array[EventSummary], optional): The list of returned events in this collection.
    }
}
