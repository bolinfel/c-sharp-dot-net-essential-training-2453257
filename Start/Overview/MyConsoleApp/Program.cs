// See https://aka.ms/new-console-template for more information

//Declare global Variables
string response;
OperatingSystem thisOs = default;

//Asks for user Name and prints a welcome message
Console.WriteLine("What is your name? ");
response  = Console.ReadLine();
Console.WriteLine($"Welcome {response}");

//print out user OS version
thisOs = Environment.OSVersion;
Console.WriteLine(thisOs.Platform);
Console.WriteLine(thisOs.VersionString);