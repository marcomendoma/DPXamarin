using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;

namespace DPXamarin.Model
{
    public class Comic
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }                                     //id(int, optional): The unique ID of the comic resource.,
        public int digitalId { get; set; }                              //digitalId(int, optional): The ID of the digital comic representation of this comic.Will be 0 if the comic is not available digitally.,
        public string title { get; set; }                               //title(string, optional): The canonical title of the comic.,
        public double issueNumber { get; set; }                         //issueNumber (double, optional): The number of the issue in the series(will generally be 0 for collection formats).,
        public string variantDescription { get; set; }                  //variantDescription(string, optional): If the issue is a variant(e.g.an alternate cover, second printing, or director’s cut), a text description of the variant.,
        public string description { get; set; }                         //description (string, optional): The preferred description of the comic.,
        public DateTime modified { get; set; }                          //modified (Date, optional): The date the resource was most recently modified.,
        public string isbn { get; set; }                                //isbn (string, optional): The ISBN for the comic(generally only populated for collection formats).,
        public string upc { get; set; }                                 //upc(string, optional): The UPC barcode number for the comic(generally only populated for periodical formats).,
        public string diamondCode { get; set; }                         //diamondCode(string, optional): The Diamond code for the comic.,
        public string eam { get; set; }                                 //ean (string, optional): The EAN barcode for the comic.,
        public string issn { get; set; }                                //issn (string, optional): The ISSN barcode for the comic.,
        public string format { get; set; }                              //format (string, optional): The publication format of the comic e.g.comic, hardcover, trade paperback.,
        public int pageCount { get; set; }                              //pageCount (int, optional): The number of story pages in the comic.,
        public ICollection<TextObject> textObjects { get; set; }        //textObjects (Array[TextObject], optional): A set of descriptive text blurbs for the comic.,
        public string resourceURI { get; set; }                         //resourceURI (string, optional): The canonical URL identifier for this resource.,
        public ICollection<Url> urls { get; set; }                      //urls(Array[Url], optional): A set of public web site URLs for the resource.,
        public SeriesSummary series { get; set; }                       //series (SeriesSummary, optional): A summary representation of the series to which this comic belongs.,
        public ICollection<ComicSummary> variants { get; set; }         //variants (Array[ComicSummary], optional): A list of variant issues for this comic(includes the "original" issue if the current issue is a variant).,
        public ICollection<ComicSummary> collections { get; set; }      //collections(Array[ComicSummary], optional): A list of collections which include this comic(will generally be empty if the comic's format is a collection).,
        public ICollection<ComicSummary> collectedIssues { get; set; }  //collectedIssues (Array[ComicSummary], optional): A list of issues collected in this comic(will generally be empty for periodical formats such as "comic" or "magazine").,
        public ICollection<ComicDate> dates { get; set; }               //dates(Array[ComicDate], optional): A list of key dates for this comic.,
        public ICollection<ComicPrice> prices { get; set; }             //prices(Array[ComicPrice], optional): A list of prices for this comic.,
        public Image thumbnail { get; set; }                            //thumbnail(Image, optional): The representative image for this comic.,
        public ICollection<Image> images { get; set; }                  //images(Array[Image], optional): A list of promotional images associated with this comic.,
        public CreatorList creators { get; set; }                       //creators (CreatorList, optional): A resource list containing the creators associated with this comic.,
        public CharacterList characters { get; set; }                   //characters (CharacterList, optional): A resource list containing the characters which appear in this comic.,
        public StoryList stories { get; set; }                          //stories (StoryList, optional): A resource list containing the stories which appear in this comic.,
        public EventList events { get; set; }                           //events (EventList, optional): A resource list containing the events in which this comic appears.
    }
}
