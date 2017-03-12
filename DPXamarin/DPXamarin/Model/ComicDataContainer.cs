using System.Collections.Generic;

namespace DPXamarin.Model
{
    public class ComicDataContainer
    {
        public int offset { get; set; }                     //offset(int, optional): The requested offset(number of skipped results) of the call.,
        public int limit { get; set; }                      //limit(int, optional): The requested result limit.,
        public int total { get; set; }                      //total (int, optional): The total number of resources available given the current filter set.,
        public int count { get; set; }                      //count(int, optional): The total number of results returned by this call.,
        public ICollection<Comic> results { get; set; }     //results (Array[Comic], optional): The list of comics returned by the call
    }
}
