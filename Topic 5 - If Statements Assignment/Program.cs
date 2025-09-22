namespace Topic_5___If_Statements_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #1 - Compass Bearings

            double angle;
            Console.WriteLine("Enter an angle for the direction of a compass.");
            Console.WriteLine();
            double.TryParse(Console.ReadLine(), out angle);
            Console.WriteLine();
            if (angle > 45 && angle < 135)
            {
                Console.WriteLine("East");
            }

            else if (angle > 135 && angle < 225)
            {
                Console.WriteLine("South");
            }

            else if (angle > 225 && angle < 315)
            {
                Console.WriteLine("West");
            }

            else
            {
                Console.WriteLine("North");
            }
            Console.WriteLine();

            // #2 - Parking Garage Cost

            int numOfMinutes;
            Console.WriteLine("How long did you leave your car for at the parking garage?");
            int.TryParse(Console.ReadLine(), out numOfMinutes);

            // 1 hour
            if (numOfMinutes <= 60)
            {
                Console.WriteLine("You are only charged for $4.00");
            }
            // 2 hours
            else if (numOfMinutes > 60 && numOfMinutes <= 120)
            {
                Console.WriteLine("You are charged for $6.00");
            }
            // 3 hours
            else if (numOfMinutes > 120 && numOfMinutes <= 180)
            {
                Console.WriteLine("You are charged for $8.00");
            }
            // 4 hours
            else if (numOfMinutes > 180 && numOfMinutes <= 240)
            {
                Console.WriteLine("You are charged for $10.00");
            }
            // 5 hours
            else if (numOfMinutes > 240 && numOfMinutes <= 300)
            {
                Console.WriteLine("You are charged for $12.00");
            }
            // 6 hours
            else if (numOfMinutes > 300 && numOfMinutes <= 360)
            {
                Console.WriteLine("You are charged for $14.00");
            }
            // 7 hours
            else if (numOfMinutes > 360 && numOfMinutes <= 420)
            {
                Console.WriteLine("You are charged for $16.00");
            }
            // 8 hours
            else if (numOfMinutes > 420 && numOfMinutes <= 480)
            {
                Console.WriteLine("You are charged for $18.00");
            }
            // 9 hours
            else if (numOfMinutes > 480 && numOfMinutes <= 540)
            {
                Console.WriteLine("You are charged for $20.00");
            }

            // #3 - Huricane

            // Catagory 1: 74-95 mph, 64-82 kt, 110-153 km/hr
            // Catagory 2: 96-110 mph, 83-95 kt, 154-177 km/hr
            // Catagory 3: 111-130 mph, 96-113 kt, 178-209 km/hr
            // Catagory 4: 131-155 mph, 114-135 kt, 210-249 km/hr
            // Catagory 5: > 155 mph, 135 kt, 249 km/hr

            int windSpeed;

            Console.WriteLine("Enter in a Hurnicane Catagory.");
            Int32.TryParse(Console.ReadLine(), out windSpeed);

            switch(windSpeed)
            {
                case 1:
                    Console.WriteLine("74-95 mph, 64-82 kt, 110-153 km/hr");
                break;
                case 2:
                    Console.WriteLine("96-110 mph, 83-95 kt, 154-177 km/hr");
                break;
                case 3:
                    Console.WriteLine("111-130 mph, 96-113 kt, 178-209 km/hr");
                break;
                case 4:
                    Console.WriteLine("131-155 mph, 114-135 kt, 210-249 km/hr");
                break;
                case 5:
                    Console.WriteLine("> 155 mph, 135 kt, 249 km/hr");
                 break;

            }
        }
    }
}
