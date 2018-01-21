using System;

namespace RPS_Game
{
    class Program
    {

        static void Main(string[] args)
        {   int usermove,compmove,totround=0,win=0,lost=0,draw=0;
            string user,chance;
            Console.WriteLine("Welcome to Rock Paper Scissor Lizard Spock Game!!!!");
            do
            {
            Console.WriteLine("Select your move:- \n 1.Rock \n 2.Paper \n 3.Scissor \n 4.Lizard \n 5.Spock");
            user=Console.ReadLine();
            bool checkinput = int.TryParse(user, out usermove);
            if(checkinput)
            { usermove=Convert.ToInt32(user);
            Random computer = new Random();
            compmove=computer.Next(1,6);
            totround++;
            switch(usermove)
            {
                case 1 : 
                switch(compmove)
                { case 1: Console.WriteLine("Computer chose rock. \nIts a tie!!!"); draw++;
                  break;
                  case 2 : Console.WriteLine("Computer chose paper. \nYou Lost!!!"); lost++;
                  break;
                  case 3 : Console.WriteLine("Computer chose scissor. \nYou Won!!!"); win++;
                  break;
                  case 4 : Console.WriteLine("Computer chose lizard. \nYou Won!!!"); win++;
                  break;
                  case 5 : Console.WriteLine("Computer chose spock. \nYou Lost!!!"); lost++;
                  break;
                }
                break;
                case 2 :
                switch(compmove)
                { case 1: Console.WriteLine("Computer chose rock. \nYou Won!!!"); win++;
                  break;
                  case 2 : Console.WriteLine("Computer chose paper. \nIts a tie!!!"); draw++;
                  break;
                  case 3 : Console.WriteLine("Computer chose scissor. \nYou Lost!!!"); lost++;
                  break;
                  case 4 : Console.WriteLine("Computer chose lizard. \nYou Lost!!!"); lost++;
                  break;
                  case 5 : Console.WriteLine("Computer chose spock. \nYou Won!!!"); win++;
                  break;
                }
                break;
                case 3 :
                switch(compmove)
                { case 1: Console.WriteLine("Computer chose rock. \nYou Lost!!!"); lost++;
                  break;
                  case 2 : Console.WriteLine("Computer chose paper. \nYou Won!!!"); win++;
                  break;
                  case 3 : Console.WriteLine("Computer chose scissor. \nIts a tie!!!"); draw++;
                  break;
                 case 4 : Console.WriteLine("Computer chose lizard. \nYou Won!!!"); win++;
                  break;
                  case 5 : Console.WriteLine("Computer chose spock. \nYou Lost!!!"); lost++;
                  break;
                }
                break;
                case 4 :
                switch(compmove)
                { case 1: Console.WriteLine("Computer chose rock. \nYou Lost!!!"); lost++;
                  break;
                  case 2 : Console.WriteLine("Computer chose paper. \nYou Won!!!"); win++;
                  break;
                  case 3 : Console.WriteLine("Computer chose scissor. \nYou Lost!!!"); lost++;
                  break;
                 case 4 : Console.WriteLine("Computer chose lizard. \nIts a tie!!!"); draw++;
                  break;
                  case 5 : Console.WriteLine("Computer chose spock. \nYou Won!!!"); win++;
                  break;
                }
                break;
                case 5 :
                switch(compmove)
                { case 1: Console.WriteLine("Computer chose rock. \nYou Won!!!"); win++;
                  break;
                  case 2 : Console.WriteLine("Computer chose paper. \nYou Lost!!!"); lost++;
                  break;
                  case 3 : Console.WriteLine("Computer chose scissor. \nYou Won!!!"); win++;
                  break;
                 case 4 : Console.WriteLine("Computer chose lizard. \nYou Lost!!!"); lost++;
                  break;
                  case 5 : Console.WriteLine("Computer chose spock. \nIts a tie!!!"); draw++;
                  break;
                }
                break;
                default : Console.WriteLine("Invalid Input"); totround--;
                break;
            }

            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            do
            { Console.WriteLine("Do you want to try again??? (Y/N)");
            chance=Console.ReadLine();
            if(!(chance.Equals("Y") || chance.Equals("N") ))
            { Console.WriteLine("Invalid Input"); }
            }while(!(chance.Equals("Y") || chance.Equals("N") ));
            }while(chance.Equals("Y"));
            Console.WriteLine("TOTAL ROUNDS \t WON \t DRAW \t LOST");
            Console.Write("{0} \t\t ",totround);
            Console.Write("{0} \t ",win);
            Console.Write("{0} \t ",draw);
            Console.Write("{0}\n",lost);
            if(chance.Equals("N"))
            { Console.WriteLine("Come back soon..."); }
            Console.ReadKey();
        }
    }
}
