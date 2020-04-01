using System;



    class Program
    {
        static void Main()
        {
            Console.WriteLine(" The Tech Academy");
            
            Console.WriteLine("Student Daily Report");
           
            Console.WriteLine("What course are you on?");
            string cours_name = Console.ReadLine();
            Console.WriteLine(cours_name);
            Console.ReadLine();
            Console.WriteLine("Page number your on?");
            string  Page_num = (Console.ReadLine());
            int num_1 = Convert.ToInt32(Page_num);
           
            Console.WriteLine("Page  number is "+num_1);
            Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”");
            string ask = Console.ReadLine();
            bool ask_1 = Convert.ToBoolean(ask);
            Console.WriteLine(ask_1);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string share = Console.ReadLine();
            Console.WriteLine(share);
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine(feedback);
            Console.WriteLine("How many hours did you study today?");
            string hour_num = (Console.ReadLine());
            int hours_n = Convert.ToInt32(hour_num);
            Console.WriteLine("I study  " +hours_n+" hours");
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!” This would be the end of the program");
            Console.ReadLine();


    }
    }

