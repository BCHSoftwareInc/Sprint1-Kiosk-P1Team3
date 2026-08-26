Console.Write("Enter First and last name: ");
string name = Console.ReadLine() ?? "";

Console.Write("Please enter personal email: ");
string org = Console.ReadLine() ?? "";

Console.Write("Please enter phone number: ");
string contact = Console.ReadLine() ?? "";

Console.Write("Please enter accses level: ");
string accses = Console.ReadLine() ?? "";

Console.WriteLine(" +-----------------------------------------------------+");
Console.WriteLine(" |               APEX ENTERTAINMENT PASS               |");
Console.WriteLine(" |-----------------------------------------------------|");
Console.WriteLine($" |   ATTENDIEE:      {name,-34}|");
Console.WriteLine($" |   ORG:            {org,-34}|");
Console.WriteLine($" |   CONTACT:        {contact,-34}|");
Console.WriteLine($" |   ACCSES:         {accses,-34}|");
Console.WriteLine($" |   ISSURE:         Blark.Indistires                  |");
Console.WriteLine(" +-----------------------------------------------------+");