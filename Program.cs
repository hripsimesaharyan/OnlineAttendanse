using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAttendanse
{
    public enum BannedUsername
    {
        Jack,Steven, Mathew
    };
    
    class Program
    {
        
        public static void Main(string[] args)
        {

            Console.WriteLine("Please enter Your name:");
            string username=Console.ReadLine();

            Func<string,string> Check = Chekbanneduser;

            string result = Chekbanneduser(username);
            
            Console.WriteLine("Please enter Your name:");
            username = Console.ReadLine();

            Action<string> CHECKusers = Chekbannedusers;
            
            CHECKusers(username);
           
            Console.ReadLine();
        }
        public static string Chekbanneduser(string username)
        {
            foreach (BannedUsername usname in Enum.GetValues(typeof(BannedUsername)))
            {
                if (username == usname.ToString())
                {
                    Console.WriteLine("Func Alarm!!!");
                    return "Alarm!";
                }
                
            }
            string value = $" Func Welcome {username.ToString()}";
            Console.WriteLine(value);
            return value;
        }
        public static void Chekbannedusers(string username)
        {
            string value="";
            foreach (BannedUsername usname in Enum.GetValues(typeof(BannedUsername)))
            {
                if (username == usname.ToString())
                {
                    value =  "Action Alarm!!!";
                   

                }
                else if(value == "")
                { 
                    value = $" Action Welcome {username.ToString()}"; 
                }
               

            }

            Console.WriteLine(value);
        }
    }
}
