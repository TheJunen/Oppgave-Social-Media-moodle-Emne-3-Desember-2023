using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace app
{
    internal class Methods
    {
        List<Persons> MyFriends = new List<Persons>();
        
        public void CheckTotalFriends()
        {
            if (MyFriends != null && MyFriends.Any())
            {
                int totalFriends = MyFriends.Count;
                //int totalFriends = MyFriends.Sum(Persons => Persons.FriendsAmount);
                Console.WriteLine($"Total Friends: {totalFriends}");
            }
            else
            {
                Console.WriteLine("MyFriends is null");
            }
        }
        public void AddFriend(Persons newfriend)
        {
            MyFriends.Add(newfriend);
            Console.WriteLine($"Added friend: {newfriend.Name}");

        }

        public void RemoveFriend(Persons removefriend)
        {
            MyFriends.Remove(removefriend);
            Console.WriteLine($"Removed friend: {removefriend.Name}");

        }

        public void printOutPersonsList()
        {
            foreach (var list in MyFriends)
            {
                Console.WriteLine($"This is the list of friends: {list.Name}, {list.Age}, {list.Email}");
            }
        }
        
        
    }
}
