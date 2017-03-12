using System.Collections.Generic;

namespace DPXamarin.Model
{
    public class CharacterList
    {
        public int available { get; set; }                          //available(int, optional): The number of total available characters in this list.Will always be greater than or equal to the "returned" value.,
        public int returned { get; set; }                           //returned(int, optional): The number of characters returned in this collection(up to 20).,
        public string collectionURI { get; set; }                   //collectionURI(string, optional): The path to the full list of characters in this collection.,
        public ICollection<CharacterSummary> items { get; set; }    //items(Array[CharacterSummary], optional): The list of returned characters in this collection.
    }
}
