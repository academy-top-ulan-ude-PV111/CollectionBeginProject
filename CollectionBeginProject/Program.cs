
using System.Linq;

namespace CollectionBeginProject
{
    class User
    {
        public string Name { get; set; }
        public int Age { set; get; }

        public static int CompareName(User u1, User u2)
        {
            return String.Compare(u1.Name, u2.Name);
        }
    }
    internal class Program
    {
        static List<int> numbers = new List<int>(10);
        static void Main(string[] args)
        {
            int size = 10;

            List<int>? list = new(size);
            List<int> sublist = new() { 5, 21, 17, 9 };
            list.Add(10);
            list.Add(20);
            //list.Capacity = 2;
            list.AddRange(new List<int> { 5, 21, 17, 9 });
            //Console.WriteLine($"{list.Capacity} {list.Count}");

            List<User> users = new()
            {
                new User(){ Name = "Tim", Age = 45 },
                new User(){ Name = "Bob", Age = 32 },
                new User(){ Name = "Sam", Age = 21 },
            };

            //foreach (var i in list)
            //    Console.Write($"{i} ");
            //list.Sort();

            //Console.WriteLine();
            //foreach (var i in list)
            //    Console.Write($"{i} ");

            //Console.WriteLine('\n' + list.Contains(18).ToString());

            //users.Sort(User.CompareName);
            //Console.WriteLine();
            //foreach (var user in users)
            //    Console.WriteLine($"{user.Name} {user.Age}");

            User user = new User() { Name = "Sam", Age = 21 };

            Console.WriteLine(users.Contains(user));

            Console.WriteLine(users.Exists(u => u.Name == user.Name && u.Age == user.Age));

            User userFind = users.Find(u => u.Name == user.Name && u.Age == user.Age);

            Console.WriteLine(userFind.Name);

            List<User> users30 = users.FindAll(u => u.Age > 30);

            Console.WriteLine("\n----------------\n");
            foreach (var u in users30)
                Console.WriteLine($"{u.Name} {u.Age}");

            //users.Sort((User u1, User u2) => u1.Age.CompareTo(u2.Age));
            //users.Reverse();

            //Console.WriteLine("\n----------------\n");
            //foreach (var user in users)
            //    Console.WriteLine($"{user.Name} {user.Age}");

            ////User[] arrUsers = users.ToArray();
            //User[] arrUsers2 = new User[users.Count];
            //users.CopyTo(arrUsers2);

            //foreach (var user in arrUsers2)
            //    Console.WriteLine($"{user.Name} {user.Age}");



        }
    }
}