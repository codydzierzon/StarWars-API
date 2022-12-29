using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoClient.Models;

namespace DemoClient.Services
{
    public interface IStarWarsService
    {
        List<Person> GetPeople();

        //Person GetPerson(int id);

        List<Planet> GetPlanets();
        Planet GetPlanet(int id);
        List<StarShip> GetStarShips();
        StarShip GetStarShip(int id);
    }
}
