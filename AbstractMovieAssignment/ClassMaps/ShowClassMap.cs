using AbstractMovieAssignment.MediaObjects;
using CsvHelper.Configuration;

namespace AbstractMovieAssignment.ClassMaps
{
    public class ShowClassMap:ClassMap<Shows>
    {
        public ShowClassMap()
        {
            Map(m => m.Id).Index(0).Name("showId");
            Map(m => m.title).Index(1).Name("title");
            Map(m => m.season).Index(2).Name("season");
            Map(m => m.episode).Index(3).Name("episode");
            Map(m => m.writersString).Index(4).Name("writers");
        }
    }
}