using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DemoClient.Models
{
    public class StarShip
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        [JsonPropertyName("cost_in_credits")]public string CostInCredits { get; set; }
        public string Length { get; set; }
        [JsonPropertyName("max_atmosphering_speed")]public string MaxAtmospheringSpeed { get; set; }
        public string Crew { get; set; }
        public string Passengers { get; set; }
        [JsonPropertyName("cargo_capacity")]public string CargoCapacity { get; set; }
        public string Consumables { get; set; }
        [JsonPropertyName("hyperdrive_rating")]public string HyperdriveRating { get; set; }
        public string MGLT { get; set; }
        public string StarshipClass { get; set; }
        public string Url { get; set; }

        public override string ToString()
        {
            return
                $"Name:                   {Name} \nModel:                  {Model} \nManufacturer:           {Manufacturer}\nCost In Credits:        {CostInCredits}\nLength:                 {Length}\nMax Atmosphering Speed: {MaxAtmospheringSpeed}\nCrew:                   {Crew}\nPassengers:             {Passengers}\nCargo Capacity:         {CargoCapacity}\nConsumables:            {Consumables}\nHyperdrive Rating:      {HyperdriveRating}\nMGLT:                   {MGLT}\nStar Ship Class:          {StarshipClass}\nUrl:                    {Url}";
        }
    }
}
