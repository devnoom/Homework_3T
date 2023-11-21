using System;
using System.Security.Cryptography;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*დაწერეთ პროგრამა რომელიც ინტეჯერ ტიპის ორ ცვლადს გაუცვლის მნიშვნელობებს,
             * დაბეჭდავს როგორც პირველად მნიშვნელობებს ასევე გაცვლის შედეგად მიღებულებს
             * მაგ int a = 5 , int b = 7, გაცვლის შემდეგ a ვლადში უნდა ეწეროს 7 ხოლო b ში 5.
             ა) თავდაპირველად გმაოიყენეთ მესამე ცვლადის ინფორმაციის გასაცვლელად 
             ბ) შემდგომ მესამე ცვლადის გარეშე*/

            //Console.Write("Enter first number : A = ");
            //int A = int.Parse(Console.ReadLine());
            //Console.Write("Enter second number : B = ");
            //int B = int.Parse(Console.ReadLine());
            //Console.WriteLine($"A = {A} & B = {B}");
            //int C = B;
            //B = A;
            //A = C;
            //Console.WriteLine($"After change A = {C}  B = {B}");


            /*დაწერეთ პროგრამა რომელიც დაბეჭდავს არის თუ არა მოცემული წელი ნაკიანი რჩევა გამოიყენეთ
             * ერთი ცვლადი სადაც შეინახავთ წლის მნიშვნელობებს მეორე ცვლადი სადაც ლოგიკური ოპერაციების
             * მეშვეობით გამოითვლი არის თუ არა მოცემული წელი ნაკიანი 
               possible input " user = 2020 
               output : true
            p.s. input -მა არ გაბნიოთ იუზზერის მხრიდან რაიმე შეყვანა არ არის სავალდებულო უბრალდო სატესტო მნიშვნელობას გულსიხომბს*/

            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            bool answer = false;
            if(year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)){
                answer = true;
            }
            Console.WriteLine(answer);







        }
    }
}