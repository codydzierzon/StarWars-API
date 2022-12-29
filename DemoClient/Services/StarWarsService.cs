using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoClient.Extensions;
using DemoClient.Models;
using RestSharp;

namespace DemoClient.Services
{
    public class StarWarsService: IStarWarsService
    {
        private RestClient _client = new RestClient();

        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();

            var request = new RestRequest("https://swapi.dev/api/people");

            bool hasNext = true;
            while (hasNext)
            {
                try
                { 
                    var response = _client.Get<SwapiResult<Person>>(request);
                    people.AddRange(response.Results);


                    if (response.Next != null)
                    {
                        request = new RestRequest(response.Next);
                    }
                    else
                    {
                        hasNext = false;
                    }
                }
                catch (Exception e)
                {
                    hasNext = false;
                }
            }

            return people;
        }

        //public Person GetPerson(int id)
        //{
        //    string url = $"https://swapi.dev/api/people/{id}/";
        //    var request = new RestRequest(url);
        //    var response = _client.Get<Person>(request);
            

        //    return response;
        //}


        public List<Planet> GetPlanets()
        {
            List<Planet> planets = new List<Planet>();

            var request = new RestRequest("https://swapi.dev/api/planets");

            bool hasNext = true;
            while (hasNext)
            {
                try
                {
                    var response = _client.Get<SwapiResult<Planet>>(request);
                    planets.AddRange(response.Results);


                    if (response.Next != null)
                    {
                        request = new RestRequest(response.Next);
                    }
                    else
                    {
                        hasNext = false;
                    }
                }
                catch (Exception e)
                {
                    hasNext = false;
                }
            }

            return planets;
        }

        public Planet GetPlanet(int id)
        {
            string url = $"https://swapi.dev/api/planets/{id}/";
            var request = new RestRequest(url);
            var response = _client.Get<Planet>(request);


            return response;
        }

        public List<StarShip> GetStarShips()
        {
            List<StarShip> ships = new List<StarShip>();

            var request = new RestRequest("https://swapi.dev/api/starships");

            bool hasNext = true;
            while (hasNext)
            {
                try
                {
                    var response = _client.Get<SwapiResult<StarShip>>(request);
                    ships.AddRange(response.Results);


                    if (response.Next != null)
                    {
                        request = new RestRequest(response.Next);
                    }
                    else
                    {
                        hasNext = false;
                    }
                }
                catch (Exception e)
                {
                    hasNext = false;
                }
            }

            return ships;
        }

        public StarShip GetStarShip(int id)
        {
            string url = $"https://swapi.dev/api/starships/{id}/";
            var request = new RestRequest(url);
            var response = _client.Get<StarShip>(request);


            return response;
        }

        public List<Vehicle> GetVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            var request = new RestRequest("https://swapi.dev/api/vehicles");

            bool hasNext = true;
            while (hasNext)
            {
                try
                {
                    var response = _client.Get<SwapiResult<Vehicle>>(request);
                    vehicles.AddRange(response.Results);


                    if (response.Next != null)
                    {
                        request = new RestRequest(response.Next);
                    }
                    else
                    {
                        hasNext = false;
                    }
                }
                catch (Exception e)
                {
                    hasNext = false;
                }
            }

            return vehicles;
        }
        public Vehicle GetVehicle(int id)
        {
            string url = $"https://swapi.dev/api/vehicles/{id}/";
            var request = new RestRequest(url);
            var response = _client.Get<Vehicle>(request);

            return response;
        }

        public List<Film> GetFilms()
        {
            List<Film> films = new List<Film>();

            var request = new RestRequest("https://swapi.dev/api/films");

            bool hasNext = true;
            while (hasNext)
            {
                try
                {
                    var response = _client.Get<SwapiResult<Film>>(request);
                    films.AddRange(response.Results);


                    if (response.Next != null)
                    {
                        request = new RestRequest(response.Next);
                    }
                    else
                    {
                        hasNext = false;
                    }
                }
                catch (Exception e)
                {
                    hasNext = false;
                }
            }

            return films;
        }
        public Film GetFilm(int id)
        {
            string url = $"https://swapi.dev/api/films/{id}/";
            var request = new RestRequest(url);
            var response = _client.Get<Film>(request);

            return response;
        }
    }
}
