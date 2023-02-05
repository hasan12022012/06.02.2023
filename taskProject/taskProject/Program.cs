using System;
using System.Numerics;

namespace taskProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Hasan Huseynli", "Asif Ibrahimov", "Orxan Ahmedov" };
            string option;
            do
            {
                Console.WriteLine("\n1.Butun telebelere bax");
                Console.WriteLine("2.Yeni telebe elave et");
                Console.WriteLine("3.Telebeler uzre axtaris et");
                Console.WriteLine("4.Telebelerin adlarına bax");
                Console.WriteLine("5.Siyahıda adın olub olmadığına bax");
                Console.WriteLine("0.Menudan çıx");

                Console.WriteLine("\nSecim edin:");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i]);
                        }
                        break;

                    case"2":
                    AdElaveEt: Console.WriteLine("Elave etmek istediyiniz telebenin adini daxil edin:");
                        string ad = Console.ReadLine( );
                        ad = ad.Substring(0, 1).ToUpper() + ad.Substring(1).ToLower();


                        Console.WriteLine("Elave etmek istediyiniz telebenin soyadini daxil edin:");
                        string soyad = Console.ReadLine(); 
                        soyad = soyad.Substring(0, 1).ToUpper() + soyad.Substring(1).ToLower();

                        var c=ad+' '+ soyad;
                      

                        Array.Resize(ref students, students.Length + 1);
                        students[students.Length - 1] = c;
                        if(c.Length <= 3)
                        {
                            goto AdElaveEt;
                        }

                        break;

                    case "3":
                        Console.WriteLine("Telebenin adinin her hansi herfini qeyd edin:");
                        string searchPerson = Console.ReadLine();
                        bool isExist = false;

                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i].ToLower().Contains(searchPerson) || students[i].ToUpper().Contains(searchPerson))
                            {
                                Console.WriteLine(students[i]);
                                isExist = true;
                            }
                        }

                        if (isExist==false)
                        {
                            Console.WriteLine("Bele bir shexs yoxdur!");
                        }
                        break;

                    case "4":
                        for (int i = 0; i < students.Length; i++)
                        {
                            int index = students[i].IndexOf(' ');
                            index = students[i].IndexOf(' ', index - 1);
                            string result = students[i].Substring(0, index);
                            Console.WriteLine(result);
                        }
                        break;

                    case "5":
                        Console.WriteLine("Telebenin adini daxil edin");
                        string insert= Console.ReadLine();
                        bool daxilEdilen = false;
                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i].ToLower().Contains(insert) || students[i].ToUpper().Contains(insert))
                            {
                                daxilEdilen = true;
                                Console.WriteLine("var");
                            }

                        }
                        if (daxilEdilen == false)
                        {
                            Console.WriteLine("yoxdur");
                        }
                        break;
                         
                        

                    case "0":
                        Console.WriteLine("Menudan cixis etdiniz");
                        break;

                    default:
                        Console.WriteLine("Seciminiz yanlisdir, yeniden daxil edin!");
                        break;

                }
            }
            while (option != "0");
            




        }


    }
}
