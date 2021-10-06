using System;
using System.IO;

namespace Baldesamo_Franco_ASS3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //length validation
                int cNameLimit = 1;
                int cAddress = 1;
                int cTel = 1;
                int cQuan = 100;
                
                bool customValidation = false;

                //get the userinfos
                Class1 custom1 = new Class1();
                FileStream fs = new FileStream("Customer.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                while (customValidation == false)
                {
                    Console.Write("Customer name: ");
                    custom1.name = Console.ReadLine();
                    customValidation = Class1.ClassValid(custom1.name, cNameLimit);
                }
                //will save the finalized name
                sw.WriteLine("FirstName: " + custom1.name);

                //get the address
                customValidation = false;
                while (customValidation == false)
                {
                    Console.Write("Customer address: ");
                    custom1.address = Console.ReadLine();
                    customValidation = Class1.ClassValid(custom1.address, cAddress);
                }
                sw.WriteLine("Address: " + custom1.address);

                customValidation = false;
                while (customValidation == false)
                {
                    Console.Write("Telephone number:");
                    custom1.tel_Num = Int64.Parse(Console.ReadLine());//not yet done
                    customValidation = Class1.ClassValidInt(custom1.tel_Num, cTel);
                }
                sw.WriteLine("Telephone num: " + custom1.tel_Num);

                customValidation = false;
                while (customValidation == false)
                {
                    Console.Write("Quantity (1-100): ");
                    custom1.quantity = byte.Parse(Console.ReadLine());
                    customValidation = Class1.ClassValidInt(custom1.quantity, cQuan);



                }
                
                sw.Close();
                fs.Close();



            }
            catch
            {
                Console.WriteLine("Invalid Input!");

            }
            
            Console.ReadKey();

        }
    }
}