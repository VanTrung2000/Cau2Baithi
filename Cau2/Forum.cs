using System;
using System.Collections;

namespace Cau2
{
    class Forum
    {
        static void Main(string[] args)
        {
            Forum f = new Forum();
            int choice = 0;

            do
            {
                Console.WriteLine("1.Create Post ");
                Console.WriteLine("2.Update Post ");
                Console.WriteLine("3.Remove Post ");
                Console.WriteLine("4.Show Post ");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Please select an item: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        f.CreatePost();
                        break;

                    case 2:
                        f.UpdatePost();
                        break;
                    case 3:
                        f.RemovePost();
                        break;
                    case 4:
                        f.ShowPost();
                        break;
                    case 5:
                        return;
                }

            } while (choice != 6);
        }
        int count = 0;
        SortedList My = new SortedList();

        public void CreatePost()
        {
            Post po = new Post();
            po.ID = count;
            Console.WriteLine("Nhap Title :");
            po.Title = Console.ReadLine();
            Console.WriteLine("Nhap Content :");
            po.Content = Console.ReadLine();
            Console.WriteLine("Nhap Anuthor :");
            po.Author = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Nhap Rate :");
                po.Rates[i] = int.Parse(Console.ReadLine());
            }
            po.CalculatorRate();
            My.Add(count, po);
            count++;
        }
        public void UpdatePost()
        {
            bool search = false;
            Console.Write("Nhap ID muon Update : ");
            int id = int.Parse(Console.ReadLine());
            foreach (Post item in My.Values)
            {
                if (id.Equals(item.ID))
                {
                    search = true;
                    Post po = new Post();
                    po.ID = id;
                    Console.WriteLine("Nhap Title :");
                    po.Title = Console.ReadLine();
                    Console.WriteLine("Nhap Content :");
                    po.Content = Console.ReadLine();
                    Console.WriteLine("Nhap Anuthor :");
                    po.Author = Console.ReadLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Nhap Rate :");
                        po.Rates[i] = int.Parse(Console.ReadLine());
                    }
                    po.CalculatorRate();
                    My.Remove(id);
                    My.Add(id, po);

                    break;
                }
            }
            }
            public void RemovePost()
        {
            bool search = false;
            Console.Write("Nhap ID muon xoa : ");
            int id = int.Parse(Console.ReadLine());
            foreach (Post item in My.Values)
            {
                if (id.Equals(item.ID))
                {
                    search = true;
                    My.Remove(id);
                    break;
                }
            }
            if (search == true)
                Console.WriteLine("Xoa thanh cong!");
            else
                Console.WriteLine("Loi.Khong tim thay ID!");
        }
        public void ShowPost()
        {
            foreach (Post item in My.Values)
            {
                item.Display();
            }
        }


    }
}