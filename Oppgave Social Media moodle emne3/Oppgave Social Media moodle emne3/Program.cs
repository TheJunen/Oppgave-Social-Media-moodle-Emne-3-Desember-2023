// See https://aka.ms/new-console-template for more information
namespace app
{
    class Program
    {
        static void Main(string[] args) 
        {
            var Methods = new Methods();
            var Persons = new Persons();
            var myAccount = new Persons(
                "Tore", 32, "lele@gmail.com", 0,
                "glad singel mann på 32 år. " +
                "Bor i Trondheim, liker å stå på ski, spille fotball, se på fotball og trene. " +
                "Elsker hunden min Leo",
                "Joined January 29 2015",
                "Workplace: Elkjøp, living place: Trondheim, Age: 51, Status: Single",
                "'Me running on a treadmill for 2 hours' 'Getting the autograph of Taylor Swift",
                22
            );
            
                

            var newFriend1 = new Persons(
                "Lars", 23, "kos@haha.com", 7,
                "Liker å game " +
                "Bor i Tromsø, liker liker damer og øl" +
                "Liker å spille brettspill og cosplayleker med venner",
                "Joined August 5 2018",
                "Workplace: Unemployed, living place: Tromsø, Age: 23, Status: Single",
                "None",
                9
                );
            var newFriend2 = new Persons(
                "Tara", 43, "ferdi@koko.com", 94,
                "Ute å fester jevnt med venner og ukjente folk jeg møter " +
                "Bor i Oslo og går på BI Handelsskole" +
                "En aktiv jente som liker å gjøre ting ofte, liker ikke å sitte stille",
                "Joined December 7 2020",
                "Workplace: Student, living place: Oslo, Age: 25, Status: Boyfriend",
                "'På BTS konsert!' 'Ute å drikker alkohol på vip baren 'Tropical'!'",
                45
                );



            Console.WriteLine("Welcome to the 'FaceTook' social media, the most trendiest social media platform at the moment!");
            Console.WriteLine($"Logged in as {myAccount.Name}");

            var menuEndless = 0;
            while (menuEndless != 100)
            {
                Console.WriteLine(
                "You have now come to the FaceTook menu. Press '1' to go to your profile page, '2' to add new friends," +
                "'3' to remove friends, '4' to see friendlist page, '5' to check total friends, '6' to visit friends profile page");
                var menu1 = Console.ReadLine();
                if (menu1 == "1")
                {
                    Persons.writeOutProfilePage(myAccount);
                }
                else if (menu1 == "2")
                {
                    Console.WriteLine("Press '1' to add Lars, '2' to add Tara");
                    var whichfriend = Console.ReadLine();
                    if (whichfriend == "1")
                    {
                        Methods.AddFriend(newFriend1);
                    }
                    else if (whichfriend == "2")
                    {
                        Methods.AddFriend(newFriend2);
                    }
                }
                else if (menu1 == "3")
                {
                    Console.WriteLine("Press '1' to remove Lars, '2' to remove Tara");
                    var whichfriend = Console.ReadLine();
                    if (whichfriend == "1")
                    {
                        Methods.RemoveFriend(newFriend1);
                    }
                    else if (whichfriend == "2")
                    {
                        Methods.RemoveFriend(newFriend2);
                    }
                }
                else if (menu1 == "4")
                {
                    Methods.printOutPersonsList();
                }
                else if (menu1 == "5")
                {
                    Methods.CheckTotalFriends();
                }
                else if (menu1 == "6")
                {
                    Console.WriteLine("Press '1' to visit Lars's profile page, '2' to visit Tara's profile page");
                    var whichfriend = Console.ReadLine();
                    if (whichfriend == "1")
                    {
                        Persons.writeOutProfilePage(newFriend1);
                    }
                    else if (whichfriend == "2")
                    {
                        Persons.writeOutProfilePage(newFriend2);
                    }
                }
            }
        }
    }
}