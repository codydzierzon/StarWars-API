using System.Threading.Channels;
using Console = System.Console;

namespace DemoClient.UI;

public class AsciiArt
{
    public static void PrintStarWars()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"     _");
        Console.WriteLine(@" ___| |_ __ _ _ __  __      ____ _ _ __ ___");
        Console.WriteLine(@"/ __| __/ _` | '__| \ \ /\ / / _` | '__/ __|");
        Console.WriteLine(@"\__ \ || (_| | |     \ V  V / (_| | |  \__ \");
        Console.WriteLine(@"|___/\__\__,_|_|      \_/\_/ \__,_|_|  |___/");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void PrintLightSaber()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(" [O////[");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("::::::::::::::::::::::::::::::::::>");
        Console.ForegroundColor = ConsoleColor.Green;
    }

    public static void PrintDroid()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("This is not the droid you are looking for");
        Console.WriteLine();
        Console.WriteLine("                    .==.\r\n                   ()''()-.\r\n        .---.       ;--; /\r\n      .'_:___\". _..'.  __'.\r\n      |__ --==|'-''' \\'...;\r\n      [  ]  :[|       |---\\\r\n      |__| I=[|     .'    '.\r\n      / / ____|     :       '._\r\n     |-/.____.'      | :       :\r\n    /___\\ /___\\      '-'._----'");
        Console.ForegroundColor = ConsoleColor.Green;
    }

    public static void DeathStar()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("           .          .\r\n .          .                  .          .              .\r\n       +.           _____  .        .        + .                    .\r\n   .        .   ,-~\"     \"~-.                                +\r\n              ,^ ___         ^. +                  .    .       .\r\n             / .^   ^.         \\         .      _ .\r\n            |  |  o  |          |  .         __ |\\---.\r\n    .       |_ `.___.'        _,[           |__/_\\|' \\\\--_-          +\r\n            |^~\"-----------\"\"~ ^|       +    __|_(=): ]-_ _-- -\r\n  +       . |                   |     .     |__\\ /|. //---- -       .\r\n         .   \\                 /               ~^----'\r\n              ^.             .^            .      \"       +.\r\n                \"-.._____.,-\" .                    .\r\n         +           .                .   +                       .\r\n  +          .             +                                  .\r\n         .             .      .       ");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
    }

    public static void StarShip()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\r\n          .                            .                      .\r\n  .                  .             -)------+====+       .\r\n                           -)----====    ,'   ,'   .                 .\r\n              .                  `.  `.,;___,'                .\r\n                                   `, |____|_\\\r\n                     _,....------c==]\"\"______ |,,,,,,.....____ _\r\n    .      .        \"-:_____________  |____|_|]'''''''''''       .     .\r\n                                  ,'\"\",'.   `.\r\n         .                 -)-----====   `.   `.                \r\n                     .            -)-------+====+       .            .\r\n             .                               .");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
    }

    public static void Darth()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("                       .-.\r\n                      |_:_|\r\n                     /(_Y_)\\\r\n                    ( \\/M\\/ )\r\n '.               _.'-/'-'\\-'._\r\n   ':           _/.--'[[[[]'--.\\_\r\n     ':        /_'  : |::\"| :  '.\\\r\n       ':     //   ./ |oUU| \\.'  :\\\r\n         ':  _:'..' \\_|___|_/ :   :|\r\n           ':.  .'  |_[___]_|  :.':\\\r\n            [::\\ |  :  | |  :   ; : \\\r\n             '-'   \\/'.| |.' \\  .;.' |\r\n             |\\_    \\  '-'   :       |\r\n             |  \\    \\ .:    :   |   |\r\n             |   \\    | '.   :    \\  |\r\n             /       \\   :. .;       |\r\n            /     |   |  :__/     :  \\\\\r\n           |  |   |    \\:   | \\   |   ||\r\n          /    \\  : :  |:   /  |__|   /|\r\n          |     : : :_/_|  /'._\\  '--|_\\\r\n          /___.-/_|-'   \\  \\\r\n                         '-'");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
    }

    public static void Walker()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("                 ________\r\n            _,.-/  |  |  \\-._\r\n        .-~\"   ||  |  |  |   \"-.\r\n        |\" \"\"==\"|\" !\"\"! \"|\"[]\"\"|     _____\r\n        |__  [] |..------|:   _[----|\" .-{\"-.\r\n       |___|  ..| |______||_ [___]_[|_/ (=}=-)\r\n      [_________[________]______|~  '-=__]/=-^\r\n       \\____.--.\\==I|I==_/.--__]\r\n         [_((==)[`-----\"](==)]\r\n            I--I\"~~\"\"\"~~\"I--I\r\n            |[]|         |[]|\r\n            |__|         |__|\r\n            |!!|         |!!|\r\n            |..|         |..|\r\n            ([])         ([])\r\n            ]--[         ]--[\r\n            [__]         [__]      \r\n           /|..|\\       /|..|\\\r\n          `=}--{='     `=}--{='\r\n         .-^----^-.   .-^----^-.                               \r\n  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green; 
    }
}