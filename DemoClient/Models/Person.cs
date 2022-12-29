using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DemoClient.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        [JsonPropertyName("hair_color")]
        public string HairColor { get; set; }
        [JsonPropertyName("skin_color")] public string SkinColor { get; set; }
        [JsonPropertyName("eye_color")] public string EyeColor { get; set; }
        [JsonPropertyName("birth_year")] public string BirthYear { get; set; }
        public string Url { get; set; }
        public List<string> Films { get; set; }
        public List<string> Vehicles { get; set; }
        public List<string> Starships { get; set; }

        public override string ToString()
        {
            return
                $"Name:         {Name}\nHeight:       {Height}\nMass:         {Mass}\nHair Color:   {HairColor}\nSkin Color:   {SkinColor}\nEye Color:    {EyeColor}\nBirth Year:   {BirthYear}\nUrl:          {Url}";
        }
    }
}
