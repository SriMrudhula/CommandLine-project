using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class ItemBO
    {
        static List<Item> litem = new List<Item>();
        static List<SubCategory> lsc = new List<SubCategory>();
        public void AddItem(int sid,int ino, int cid, int scid, string name, string cname, string scname, int noi, int price, string desc, string cdesc, string scdesc)
        {   

            SubCategory cat = new SubCategory(cid, scid, cname, scname, cdesc, scdesc);
            Item item = new Item(sid,ino,scid,name, noi, price, desc);
            int f1 = 1;
            foreach (SubCategory su in lsc)
            {
                if (su == cat)
                {
                    f1 = 0;
                    break;
                }
            }
            if(f1==1)
              lsc.Add(cat);
            litem.Add(item);
            Console.WriteLine(name+" is add to the list ");
        }
        public void DisplaySellerProducts()
        {
            Console.WriteLine("Enter Your Id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Item Id \t Item Name \t Item Quantity \t Item Price \t Item Description");
            foreach (Item i in litem)
            {
                if (i.sid == id)
                {
                    Console.WriteLine(i.ino + "\t\t" + i.name + "\t\t" + i.noi + "\t\t" + i.price + "\t\t" + i.desc);
                }
            }

        }
        public void DisplayProducts()
        {
               
            Console.WriteLine("Category Id \t Category Name \t  Category Desc");
            foreach (Category i in lsc)
            {
                Console.WriteLine(i.cid + "\t" + i.cname + "\t" + i.cdesc);
            }
            Console.WriteLine("Enter Cid for which you want to go to Subcategory");
            int ch = int.Parse(Console.ReadLine());
            Console.WriteLine("SubCategory Id \t SubCategory Name  \t SubCategory Desc");
          
            foreach (SubCategory i in lsc)
            {

                
                if (i.cid == ch)
                {
             
                    Console.WriteLine(i.scid + "\t\t" + i.scname + "\t\t" + i.scdesc);
                }
            }
            Console.WriteLine("Enter scid for which you want to go to Items");
            int ch1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Item Id \t Item Name \t Item Quantity \t Item Price \t Item Description");
            foreach (Item i in litem)
            {
                if (i.scid == ch1)
                {
                    
                    Console.WriteLine(i.ino + "\t\t" + i.name + "\t\t" + i.noi + "\t\t" + i.price + "\t\t" + i.desc);
                }
            }
        }
        public void Search()
        {
                int f = 0;
                string s = "";
            Console.WriteLine("Search Menu");
            Console.WriteLine("1.Search By Name");
            Console.WriteLine("2.Search By Price");
            Console.WriteLine("Enter your choice");
            int ch = int.Parse(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("Enter Item Name that you want to search");
                String name = Console.ReadLine();
                foreach (Item i in litem)
                {
                    if (i.name == name)
                    {
                        s = i.ino + "\t\t" + i.name + "\t\t" + i.noi + "\t\t" + i.price + "\t\t" + i.desc + "\n";
                        f = 0;
                    }
                    else
                        f = 1;
                }

                if (f == 1)
                    Console.WriteLine("Item Not Found");
                else
                {
                    Console.WriteLine("Item Id \t Item Name \t Item Quantity \t Item Price \t Item Description");
                    Console.WriteLine(s);
                }
            }
            if(ch==2)
            {
                Console.WriteLine("Search By Price Menu");
                Console.WriteLine("1.Display Low price to High price");
                Console.WriteLine("2.Display High price to Low Price");
                int ch1 = int.Parse(Console.ReadLine());
                if(ch1==1)
                {
                    List<Item> aolitem = litem.OrderBy(a=> a.price).ToList();
                    foreach(var i in aolitem)
                    {
                        
                        Console.WriteLine(i.ino + "\t\t" + i.name + "\t\t" + i.noi + "\t\t" + i.price + "\t\t" + i.desc);
                    }
                }
                else if(ch==2)
                {
                    List<Item> aolitem = litem.OrderByDescending(a => a.price).ToList();
                    foreach (var i in aolitem)
                    {

                        Console.WriteLine(i.ino + "\t\t" + i.name + "\t\t" + i.noi + "\t\t" + i.price + "\t\t" + i.desc);
                    }
                }
            }
        }
    }
}