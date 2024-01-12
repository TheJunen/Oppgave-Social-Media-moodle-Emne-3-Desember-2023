using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class Persons
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int FriendsAmount { get; set; }
        public string MyDescription { get; set; }
        public string JoinDate { get; set; }

        public string AboutMe { get; set; }
        public string MyReels { get; set; }
        public int MyPhotos {  get; set; }





        public Persons(string name, int age, string email, int friendsamount, string mydescription, string joindate, string aboutme, string myreels, int myphotos)
        {
            Name = name;
            Age = age;
            Email = email;
            FriendsAmount = friendsamount;
            MyDescription = mydescription;
            JoinDate = joindate;
            AboutMe = aboutme;
            MyReels = myreels;
            MyPhotos = myphotos;
        }

        public Persons() 
        { 

        }

        public void writeOutProfilePage(Persons myprofile)
        {
            Console.WriteLine($"{myprofile.Name}, {myprofile.Age}, {myprofile.Email}, {myprofile.FriendsAmount}, {myprofile.MyDescription}, {myprofile.JoinDate}, {myprofile.AboutMe}, {myprofile.MyReels}, {myprofile.MyPhotos}");
        }
    }
}
