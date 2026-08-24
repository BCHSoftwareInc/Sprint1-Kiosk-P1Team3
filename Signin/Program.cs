// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
Console.Write("ATTENDIEE: ");
string name = Console.ReadLine() ?? "";

Console.Write("ORG: ");
string org = Console.ReadLine() ?? "";

Console.Write("CONTACT: ");
string contact = Console.ReadLine() ?? "";

Console.Write("ACCSES: ");
string accses = Console.ReadLine() ?? "";

Console.Write("ISSUERE: ");
string issure = Console.ReadLine() ?? "";

Console.WriteLine(" +-----------------------------------------------------+");
Console.WriteLine(" |               APEX ENTERTAINMENT PASS               |");
Console.WriteLine(" |-----------------------------------------------------|");
Console.WriteLine($" |   ATTENDIEE:      {name,-34}|");
Console.WriteLine($" |   ORG:            {org,-34}|");
Console.WriteLine($" |   CONTACT:        {contact,-34}|");
Console.WriteLine($" |   ACCSES:         {accses,-34}|");
Console.WriteLine($" |   ISSURE          {issure,-34}|");
Console.WriteLine(" +-----------------------------------------------------+");