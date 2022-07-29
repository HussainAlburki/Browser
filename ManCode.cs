using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        static void Main(String[] args)
        {



            string Current ="" ;
            string First="";
            string Choice="";
            bool flag = true;
            Stack<String> Forwardstack = new Stack<String>();
            Stack<String> Backstack = new Stack<String>();

            do
            {
                Console.Write("Choose (N)ew page, go (B)ack one page, go (F)orward one page, (Q)uit: ");
                Choice = Console.ReadLine();

                switch (Choice)
                {
                    case "N":
                        Console.WriteLine("Enter new page address:");
                        Current = Console.ReadLine();


                        //to save the first visited website
                        if(flag)
                        {
                            First = Current;
                            flag = false;

                        }

                        if(Forwardstack.Count() != 0 )
                        {
                            Forwardstack.Clear();
                        }    


                        Backstack.Push(Current);
                        break;

                    // go forward
                    case "F":

                        if(Forwardstack.Count() == 0)
                        {
                            Console.WriteLine("Error there is no Forward page.");
                            Console.WriteLine("You are now visting : " + Current);
                        }
                        else
                        {
                            Current= Forwardstack.Pop();
                            Backstack.Push(Current);

                            Console.WriteLine("You have gone to the forward page.");
                            Console.WriteLine("You are now visting : "+ Current);
                            
                        }

                        break;


                    // to go back
                    case "B":

                      
                        while (!String.Equals(Current,First) && Current== Backstack.Peek())
                        { Forwardstack.Push(Backstack.Pop()); }

                        if (Backstack.Count() == 0 || String.Equals(Current, First))
                        {
                            Console.WriteLine("Error there is no Back page.");
                            Console.WriteLine("You are now visting : " + Current);
                        }

                        else
                        {
                            Current = Backstack.Peek();
                            Console.WriteLine("You have gone back one page.");
                            Console.WriteLine("You are now visting : " + Current);

                        }
                        break;
                } //end of switch



            } while (Choice!="Q");

            Console.WriteLine("\nThank you for using our browser \n-----------------------------\nHave a nice day");
        }
    }


}
