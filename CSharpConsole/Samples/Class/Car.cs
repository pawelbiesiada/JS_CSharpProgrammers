namespace CSharpConsole.Samples.Class
{
    public class Car
    {
        //Constant Field
        private const int ServiceCheckAfter = 10000;

        // Fields
        private readonly int _speed;

        // Constructor
        public Car(int avgSpeed)
        {
            //var car = new Car(100); initialization sample
            _speed = avgSpeed;
        }

        // Properties
        public int Distance { get; set; }
        public static int DistanceStatic { get; set; }


        private int myVar;

        public int Speed { 
            get { return _speed; } 
        }


        public int MyProperty
        {
            get 
            { 
                return myVar; 
            }
            set 
            { 
                if(value < 0)
                {
                    value = value * -1;
                }

                myVar = value; 
            }
        }



        // Methods
        public void Drive(int duration)
        {
            Distance += CalculateDistance(_speed, duration);
            DistanceStatic += CalculateDistance(_speed, duration);
        }

        public bool IsServiceCheckNeeded()
        {
            return Distance > ServiceCheckAfter;
        }

        private static int CalculateDistance(int speed, int duration)
        {
            return speed * duration;
        }
    }

    public class ClassTest
    {
        public static void Main()
        {
            var ds = Car.DistanceStatic;

            Car car = new Car(30);
            Car car2 = new Car(50);
            Car car3 = new Car(30);

            car.Drive(10);
            car2.Drive(5);


            car.MyProperty = -2;

            var prop = car.MyProperty;

            var d = Car.DistanceStatic;

            Console.WriteLine();

            var areEqual = car == car2; //false
            areEqual = car == car3; //false

            areEqual = car.Equals(car2); //false
            areEqual = car.Equals(car3); //false

            car.Distance = 50;
            areEqual = car.Equals(car2); //false
            areEqual = car.Equals(car3); //false

            var copyCar = car;
            areEqual = car.Equals(copyCar); //true
            car.Distance = 10;
            areEqual = car.Equals(copyCar); //true

            ModifyClass(car);
            areEqual = car.Distance == 100;

            ModifyAndInitializeClass(car);
            areEqual = car.Distance == 200; 
            areEqual = car.Distance == 300;


            var str1 = "Hi";
            var str2 = str1;

            str1 = "Hello";
            Modifystring(str1);


            var i = 0;
            var j = i;
            i = 2;
            ModifyInt(ref i);
            i = ModifyIntReturn(i);
        }

        private static void ModifyInt(ref int num)
        {
            num = num + 33;
        }

        private static int ModifyIntReturn(int num)
        {
            return num + 33;
        }
        private static void Modifystring(string str)
        {
            str = "";
        }

        public static void ModifyClass(Car car)
        {
            car.Distance = 100;
        }

        public static void ModifyAndInitializeClass(Car car)
        {
            car.Distance = 200;
            car = new Car(300);
        }
    }
}
