using System;

namespace BodyMassIndexCalc
{
    public class UserData
    {
        public static string firstName;
        public static string lastName;
        public static double age;
        public static double height;
        public static double weight;
        public static double index;

        public static void UserName()
        {            
            Console.Write("What is your name: ");
            firstName = Console.ReadLine();

            Console.Write($"Hello {firstName}, your last name is: ");
            lastName = Console.ReadLine();
        }

        public static void UserAge()
        {
            Console.WriteLine("Okey, now we need more information about your age, height and weight.");
            Console.Write("Your age is: ");

            do { age = double.Parse(Console.ReadLine()); }
            while (age > 14 && age <= 100);

            string age18 = age > 18 ? "\nCongratulations, you can drink alkohol:)" : "\nYoung baby:)";
            Console.WriteLine(age18);
        }

        public static void UserHeightAndWeight()
        {
            Console.Write("Your height: ");
            height = double.Parse(Console.ReadLine());

            Console.Write("Your wieght: ");
            weight = double.Parse(Console.ReadLine());
        }

        public static void IndexCalc()
        {
            index = weight / (height / 100 * height/ 100);
        }

        public static void ConfirmUserData()
        {
            Console.WriteLine("Please confirm your information:");
            Console.WriteLine($"\nName: {firstName},\nSurname: {lastName},\nAge: {age},\nWeight: {weight},\nHeight: {height}.");
            Console.Write("\nPress 'Y' if looks good and 'N' if something wrong: ");
            var answer = Console.ReadLine();
            answer.ToLower();

            do{ UserAge();UserHeightAndWeight(); }
            while (answer == "y");
        }

        public static void SummaryResult()
        {
            bool isLow = index <= 18.5;
            bool isNormal = index > 18.5 && index <= 25;
            bool isHy = index > 25 && index <= 30;
            bool isFat = index > 30;
            bool fat = isHy || isFat;

            if (isLow)
            {
                Console.WriteLine("\nUnderweight.");
            }
            if (isNormal)
            {
                Console.WriteLine("\nNormal weight.");
            }
            if (isHy)
            {
                Console.WriteLine("\nOverweight.");
            }
            if (isFat)
            {
                Console.WriteLine("\nObese.");
            }
            Console.WriteLine("");
            Console.WriteLine("Press <Enter> to exit... ");
            Console.ReadKey(true);
        }
    }
}
