using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DemoClient.Models
{
    public class Planet
    {
        public string Name { get; set; }
        [JsonPropertyName("rotation_period")]public string RotationPeriod { get; set; }
        [JsonPropertyName("orbital_period")] public string OrbitalPeriod { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }
        [JsonPropertyName("surface_water")]public string SurfaceWater { get; set; }
        public string Population { get; set; }
        public string Url { get; set; }

        public override string ToString()
        {
            return
                $"Name:            {Name,-10} \nRotation Period: {RotationPeriod,-16} \nOrbital Period:  {OrbitalPeriod,-15} \nDiameter:        {Diameter,-9} \nClimate:         {Climate,-9} \nGravity:         {Gravity,-11} \nTerrain:         {Terrain,-30} \nSurface Water:   {SurfaceWater, -10} \nPoplation:       {Population, -10} \nUrl:             {Url}";
        }
    }
}
