using DemoClient.Models;
using DemoClient.Services;
using DemoClient.UI;
using System;
using System.Security.Cryptography.X509Certificates;
using DemoClient.Extensions;

namespace DemoClient;

public class StarWarsApplication
{
    private StarWarsService _star = new StarWarsService();
    public List<Person> _people = null;
    private List<StarShip> _ships = null;
    private List<Planet> _planets = null;
    private List<Vehicle> _vehicles = null;
    private List<Film> _films = null;

    public void Run()
    {
        UserInput.ClearScreen();
        AsciiArt.PrintStarWars();
        AsciiArt.PrintLightSaber();

        while (true)
        {

            UserInput.MainMenu();
            int selection = int.Parse(Console.ReadLine());
            UserInput.ClearScreen();

            switch (selection)
            {
                case 0:
                    AsciiArt.PrintDroid();
                    return;
                case 1:
                    AsciiArt.Darth();
                    GetPeople();
                    UserInput.CharacterSelection();
                    int characterSelection = int.Parse(Console.ReadLine());
                    GetPerson(characterSelection);
                    break;
                case 2:
                    AsciiArt.DeathStar();
                    GetPlanets();
                    UserInput.PlanetSelection();
                    int planetSelection = int.Parse(Console.ReadLine());
                    GetPlanet(planetSelection);
                    break;
                case 3:
                    AsciiArt.StarShip();
                    GetShips();
                    UserInput.ShipSelection();
                    int shipSelection = int.Parse(Console.ReadLine());
                    GetShip(shipSelection);
                    break;
                case 4:
                    AsciiArt.Walker();
                    GetVehicles();
                    UserInput.VehicleSelection();
                    int vehicleSelection = int.Parse(Console.ReadLine());
                    GetVehicle(vehicleSelection);
                    break;
                case 5:
                    GetFilms();
                    UserInput.FilmSelection();
                    int filmSelection = int.Parse(Console.ReadLine());
                    GetFilm(filmSelection);
                    break;
                default:
                    AsciiArt.PrintDroid();
                    break;
            }

            UserInput.PauseOnScreen();

            UserInput.ClearScreen();
        }
    }

    public void GetPeople()
    {
        
        if (_people == null)
        {
             _people = _star.GetPeople();
        }

        foreach (var person in _people)
        {
            int personNum = person.Url.GetId();
            Console.WriteLine($"{personNum}) {person.Name}");

        }

    }

    private Person SortById(int id)
    {

        var person = from p in _people
            where p.Url.GetId() == id
            select p;

        return person.FirstOrDefault();
    }


    public void GetPerson(int id)
    {
        UserInput.ClearScreen();
        AsciiArt.PrintLightSaber();
        Console.WriteLine();

        var person = SortById(id);

        Console.WriteLine(person.ToString());
        if (person.Starships.Count > 0)
        {
            AsciiArt.PrintLightSaber();
            Console.WriteLine();
            Console.WriteLine("Star Ships Flown In:");
        }
        foreach (var ship in person.Starships)
        {
            int shipNum = ship.GetId();
            GetShipName(shipNum);
        }
        if (person.Vehicles.Count > 0)
        {
            AsciiArt.PrintLightSaber();
            Console.WriteLine();
            Console.WriteLine("Vehicles Driven:");
        }
        foreach (var vehicle in person.Vehicles)
        {
            int vehicleNum = vehicle.GetId();
            GetVehicleName(vehicleNum);
        }
        if (person.Films.Count > 0)
        {
            AsciiArt.PrintLightSaber();
            Console.WriteLine();
            Console.WriteLine("Films Stared In:");
        }
        foreach (var film in person.Films)
        {
            int filmNum = film.GetId();
            GetFilmName(filmNum);
        }

    }

    public void GetPlanets()
    {
        if (_planets == null)
        {
            _planets = _star.GetPlanets();
        }
        
        
        foreach (var planet in _planets)
        {
            int planetNum = planet.Url.GetId();
            Console.WriteLine($"{planetNum}) {planet.Name}");
        }
        
    }
    public void GetPlanet(int id)
    {
        UserInput.ClearScreen();
        AsciiArt.PrintLightSaber();

        var planet = _star.GetPlanet(id);

        Console.WriteLine(planet.ToString());
    }

    public void GetShips()
    {
        if (_ships == null)
        {
            _ships = _star.GetStarShips();
        }

        foreach (var ship in _ships)
        {
            int shipNum = ship.Url.GetId();
            Console.WriteLine($"{shipNum}) {ship.Name}");
        }

    }

    public void GetShip(int id)
    {
        UserInput.ClearScreen();
        AsciiArt.PrintLightSaber();

        var ship = _star.GetStarShip(id);

        Console.WriteLine(ship.ToString());
    }

    public void GetShipName(int id)
    {

        var ship = _star.GetStarShip(id);

        Console.WriteLine($"{ship.Name}");
    }

    public void GetVehicles()
    {
        if (_vehicles == null)
        {
            _vehicles = _star.GetVehicles();
        }

        foreach (var vehicle in _vehicles)
        {
            int vehicleNum = vehicle.Url.GetId();
            Console.WriteLine($"{vehicleNum}) {vehicle.Name}");
        }

    }

    public void GetVehicle(int id)
    {
        UserInput.ClearScreen();
        AsciiArt.PrintLightSaber();
        Console.WriteLine();

        var vehicle = _star.GetVehicle(id);

        Console.WriteLine(vehicle.ToString());
    }
    public void GetVehicleName(int id)
    {

        var vehicle = _star.GetVehicle(id);

        Console.WriteLine($"{vehicle.Name}");
    }
    public void GetFilms()
    {
        if (_films == null)
        {
            _films = _star.GetFilms();
        }

        foreach (var film in _films)
        {
            int filmNum = film.Url.GetId();
            Console.WriteLine($"{filmNum}) {film.Title}");
        }

    }

    public void GetFilm(int id)
    {
        UserInput.ClearScreen();
        AsciiArt.PrintLightSaber();
        Console.WriteLine();

        var film = _star.GetFilm(id);

        Console.WriteLine(film.ToString());
        if (film.Characters.Count > 0)
        {
            AsciiArt.PrintLightSaber();
            Console.WriteLine();
            Console.WriteLine("Characters In Movie:");
        }
        foreach (var character in film.Characters)
        {
            int charNum = character.GetId();
            GetCharacterName(charNum);
        }

        if (film.Starships.Count > 0)
        {
            AsciiArt.PrintLightSaber();
            Console.WriteLine();
            Console.WriteLine("Star Ships In Movie:");
        }
        foreach (var ship in film.Starships)
        {
            int shipNum = ship.GetId();
            GetShipName(shipNum);
        }
        if (film.Vehicles.Count > 0)
        {
            AsciiArt.PrintLightSaber();
            Console.WriteLine();
            Console.WriteLine("Vehicles In Movie:");
        }
        foreach (var vehicle in film.Vehicles)
        {
            int vehicleNum = vehicle.GetId();
            GetVehicleName(vehicleNum);
        }
    }
    public void GetFilmName(int id)
    {

        var film = _star.GetFilm(id);

        Console.WriteLine($"{film.Title}");
    }

    public void GetCharacterName(int id)
    {
        var character = SortById(id);

        Console.WriteLine($"{character.Name}");
    }
}