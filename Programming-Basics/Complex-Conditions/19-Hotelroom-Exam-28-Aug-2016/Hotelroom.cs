using System;

namespace Hotelroom
{
    class Hotelroom
    {
        static void Main(string[] args)
        {
            var Month = (Console.ReadLine());
            var stayDays = int.Parse(Console.ReadLine());
            double totalStudioPrice = 0;
            double totalApartmentPrice = 0;
            bool to7days = stayDays <= 7;
            bool over7to14days = stayDays > 7 && stayDays <= 14;
            bool over14days = stayDays > 14;
            bool to14days = stayDays <= 14;
            if (Month == "May" || Month == "October")
            {
                double studioprice = 50;
                double apartmentprice = 65;
                if (to7days) totalStudioPrice = studioprice * stayDays;
                else if (over7to14days) totalStudioPrice = (studioprice * 0.95) * stayDays;
                else if (over14days) totalStudioPrice = (studioprice * 0.70) * stayDays;
                if (over14days) totalApartmentPrice = (apartmentprice * 0.90) * stayDays;
                else if (to14days) totalApartmentPrice = apartmentprice * stayDays;
            }
            else if (Month == "June" || Month == "September")
            {
                double studioprice = 75.20;
                double apartmentprice = 68.70;
                if (to14days) totalStudioPrice = studioprice * stayDays;
                else if (over14days) totalStudioPrice = (studioprice * 0.80) * stayDays;
                if (over14days) totalApartmentPrice = (apartmentprice * 0.90) * stayDays;
                else if (to14days) totalApartmentPrice = apartmentprice * stayDays;
            }
            else if (Month == "July" || Month == "August")
            {
                double studioprice = 76;
                double apartmentprice = 77;
                totalStudioPrice = studioprice * stayDays;
                if (to14days) totalApartmentPrice = apartmentprice * stayDays;
                else if (over14days) totalApartmentPrice = (apartmentprice * 0.90) * stayDays;
            }
            Console.WriteLine($"Apartment: {totalApartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");

        }
    }
}
