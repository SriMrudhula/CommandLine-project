using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Seller");
                Console.WriteLine("2.Buyer");
                Console.WriteLine("Enter your choice:");
                int ch = int.Parse(Console.ReadLine());
                if (ch == 1)
                {
                    Console.WriteLine("Enter id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter phone number: ");
                    string phno = Console.ReadLine();
                    Console.WriteLine("Enter Email Id: ");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter Company Details: ");
                    string cname = Console.ReadLine();
                    Console.WriteLine("Enter GSTIN: ");
                    string gstin = Console.ReadLine();
                    Seller s = new Seller(id, name, phno, email, cname, gstin);
                    while (true)
                    {
                        Console.WriteLine("Menu");
                        Console.WriteLine("1.Add Products");
                        Console.WriteLine("2.Display My Details");
                        Console.WriteLine("3.Display My Products");
                        Console.WriteLine("4.Exit From Seller");
                        Console.WriteLine("Enter your choice : ");
                        int ch2 = int.Parse(Console.ReadLine());
                        if (ch2 == 1)
                            s.AddItems();
                        else if (ch2 == 2)
                            s.DisplayDetails();
                        else if (ch2 == 3)
                            s.DisplayProducts();
                        else if (ch2 == 4)
                            break;
                        else
                            Console.WriteLine("Wrong Choice. Please select appropriate Option");
                    }

                }
                else if (ch == 2)
                {
                    Console.WriteLine("Enter id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter phone number: ");
                    string phno = Console.ReadLine();
                    Console.WriteLine("Enter Email Id: ");
                    string email = Console.ReadLine();
                    while (true)
                    {
                        Console.WriteLine("Menu For Buyer");
                        Console.WriteLine("1.Display My Profile");
                        Console.WriteLine("2.Search For Item");
                        Console.WriteLine("3.Display All Items");
                        Console.WriteLine("4.Exit From Buyer");
                        Console.WriteLine("enter your Choice");
                        BuyerBO bo = new BuyerBO(id, name, phno, email);
                        int ch1 = int.Parse(Console.ReadLine());

                        if (ch1 == 1)
                            bo.DisplayDetails();
                        else if (ch1 == 2)
                            bo.Search();
                        else if (ch1 == 3)
                            bo.DisplayCategory();
                        else if (ch1 == 4)
                            break;
                        else
                            Console.WriteLine("Wrong Choice. Please select appropriate Option");
                    }
                }
                else if(ch==3)
                    Environment.Exit(0);
                else
                    Console.WriteLine("Wrong Choice. Please select appropriate Option");

            }
        }
    }
}
