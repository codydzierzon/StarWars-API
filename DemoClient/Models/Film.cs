using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DemoClient.Models
{
    public class Film
    {
        public string Title { get; set; }
        [JsonPropertyName("episode_id")]public int EpisodeId { get; set; }
        public string Url { get; set; }
        [JsonPropertyName("opening_crawl")]public string OpeningCrawl { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        [JsonPropertyName("release_date")]public string ReleaseDate { get; set; }
        public List<string> Characters { get; set; }
        public List<string> Planets { get; set; }
        public List<string> Starships { get; set; }
        public List<string> Vehicles { get; set; }

        public override string ToString()
        {
            return
                $"Title:           {Title}\nEpisode:         {EpisodeId}\nUrl:             {Url}\nDirector:        {Director}\nProducer:        {Producer}\nRelease Date:    {ReleaseDate}\nOpening Credits:\n\n{OpeningCrawl}";
        }
    }
}
