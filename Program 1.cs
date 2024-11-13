using System;

class Program
{
    static void Main()
    {
        // سوال اول
        Console.WriteLine("آیا شما یک دانشجو هستید؟ (بله/خیر)");
        string answer1 = Console.ReadLine().ToLower();

        // سوال دوم
        Console.WriteLine("آیا شما به کامپیوتر علاقه دارید؟ (بله/خیر)");
        string answer2 = Console.ReadLine().ToLower();

        // سوال سوم
        Console.WriteLine("آیا شما دوست دارید کارهای خلاقانه انجام دهید؟ (بله/خیر)");
        string answer3 = Console.ReadLine().ToLower();

        // سوال چهارم
        Console.WriteLine("آیا شما به دنبال شغل در  این عرصه هستید؟ (بله/خیر)");
        string answer4 = Console.ReadLine().ToLower();

        // تصمیم‌گیری با استفاده از switch
        switch (answer1)
        {
            case "بله":
                switch (answer2)
                {
                    case "بله":
                        switch (answer3)
                        {
                            case "بله":
                                switch (answer4)
                                {
                                    case "بله":
                                        Console.WriteLine("شما ممکن است شغل مناسبی در این عرصه پیدا کنید.");
                                        break;
                                    case "خیر":
                                        Console.WriteLine("شما ممکن است در صنایع خلاقانه شغلی پیدا کنید.");
                                        break;
                                }
                                break;
                            case "خیر":
                                switch (answer4)
                                {
                                    case "بله":
                                        Console.WriteLine("شما ممکن است به شغل‌های مدیریتی این عرصه علاقه‌مند شوید.");
                                        break;
                                    case "خیر":
                                        Console.WriteLine("شما ممکن است در زمینه‌های غیر فنی شغل پیدا کنید.");
                                        break;
                                }
                                break;
                        }
                        break;
                    case "خیر":
                        switch (answer3)
                        {
                            case "بله":
                                Console.WriteLine("شما ممکن است در هنر یا طراحی شغلی پیدا کنید.");
                                break;
                            case "خیر":
                                switch (answer4)
                                {
                                    case "بله":
                                        Console.WriteLine("شما ممکن است در شغل‌های غیر فنی این عرشه، شغلی پیدا کنید.");
                                        break;
                                    case "خیر":
                                        Console.WriteLine("شما ممکن است به شغل‌های مختلف در زمینه‌های دیگر علاقه داشته باشید.");
                                        break;
                                }
                                break;
                        }
                        break;
                }
                break;

            case "خیر":
                switch (answer2)
                {
                    case "بله":
                        Console.WriteLine("شما ممکن است در این عرصه شغلی پیدا کنید.");
                        break;
                    case "خیر":
                        Console.WriteLine("شما ممکن است به شغل‌های غیر فنی علاقه داشته باشید.");
                        break;
                }
                break;
        }
    }
}