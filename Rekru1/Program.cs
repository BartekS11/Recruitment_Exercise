var repo = new Repository();
Console.WriteLine("Menu:");
Console.WriteLine("1. Search by: ");
Console.WriteLine("2. Longest surname");
Console.WriteLine("3. Reverse name");
Console.WriteLine("4. Youngest user");
string choice = Console.ReadLine();
switch(choice)
    {
        case("1"):
            Console.WriteLine("earch by");
            var x = Console.ReadLine();
            repo.SearchBy(x);
            break;

        case("2"):
            Console.WriteLine("longest surname");
            repo.LongestSurname();
            break;

        case("3"):
            Console.WriteLine("reversed name");
            repo.ReverseName();
            break;

        case("4"):
            Console.WriteLine("youngest");
            repo.YoungestUser();
            break;
    }
