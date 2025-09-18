namespace Topic_5___If_Statements_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #1 - Compass Bearings

            //double angle;
            //Console.WriteLine("Enter an angle for the direction of a compass.");
            //Console.WriteLine();
            //double.TryParse(Console.ReadLine(),out angle);
            //Console.WriteLine();
            //if ( angle > 45 && angle < 135)
            //{
            //    Console.WriteLine("East");
            //}

            //else if ( angle > 135 && angle < 225)
            //{
            //    Console.WriteLine("South");
            //}

            //else if (angle > 225 && angle < 315)
            //{
            //    Console.WriteLine("West");
            //}

            //else 
            //{
            // Console.WriteLine("North");
            //}
            //Console.WriteLine();

            // #2 - Parking Garage Cost


            int numOfMinutes;
            double parkingCost;

            parkingCost = 2;
            
            Console.WriteLine("How long did you leave your car for at the parking garage?");
            int.TryParse(Console.ReadLine(), out numOfMinutes);

            if (numOfMinutes < 60)
            {
                Console.WriteLine("You are only charged for $4.00");
            }
            else if (numOfMinutes > 60 && numOfMinutes < 120)
            {
                Console.WriteLine("You are charged for $6.00");
            }
            else if (numOfMinutes > 120 && numOfMinutes < 180)
            {
                Console.WriteLine("You are charged for $8.00");
            }
            else if (numOfMinutes > 180 && numOfMinutes < 240)
            {
                Console.WriteLine("You are charged for $10.00");
            }
            else if (numOfMinutes > 240 && numOfMinutes < 300)
            {
                Console.WriteLine("You are charged for $12.00");
            }
            else if (numOfMinutes > 300 && numOfMinutes < 360)
            {
                Console.WriteLine("You are charged for $14.00");
            }
            else if (numOfMinutes > 360 && numOfMinutes < 420)
            {
                Console.WriteLine("You are charged for $16.00");
            }
            else if (numOfMinutes > 420 && numOfMinutes < 480)
            {
                Console.WriteLine("You are charged for $18.00");
            }
            else if (numOfMinutes > 480 && numOfMinutes <  540)
            {
                Console.WriteLine("You are charged for $20.00");
            }
           
        }
    }
}
