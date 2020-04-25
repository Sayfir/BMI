using System;

namespace BodyMassIndexCalc
{
    class Program : UserData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's calculate your body mass index. Press <Enter> to starts");
            Console.ReadKey(true);
            Console.WriteLine("We need some information about you.");

            UserName();
            UserAge();
            UserHeightAndWeight();
            ConfirmUserData();
            SummaryResult();
        }
    }
}
