using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDisgnostics
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
                private static List<Vehicle_> vehicles = new List<Vehicle_>();
        private static Scanner sc = new Scanner(System.in);
        private static MessageSubscriberOne s1;
        private static MessageSubscriberTwo s2;
        private static MessageSubscriberThree s3;
        private static MessagePublisher p;
        private static Context context;
        

        public static void main(String[] args)
        {
            // observer pattern
            s1 = new MessageSubscriberOne();
            s2 = new MessageSubscriberTwo();
            s3 = new MessageSubscriberThree();
            p = new MessagePublisher();
            p.attach(s1);
            p.attach(s2);
            p.attach(s3);
            // -------------------
            Console.WriteLine("###########################################");
            Console.WriteLine("################# WELCOME #################");
            Console.WriteLine("###########################################");

            while (true)
            {
                String cmd = getOption();
                switch (cmd)
                {
                    case "1":
                        AddVehicle();
                        break;

                    case "2":
                        ViewVehicles();
                        break;

                    case "3":
                        Console.WriteLine("Thank you for using ABC Systems.");
                        Console.WriteLine(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option!!!");
                        break;
                }
            }

        }

        private static String getOption()
        {
            Console.WriteLine("###########################################");
            Console.WriteLine("Please select an option below:");
            Console.WriteLine("1. Add Vehicle");
            Console.WriteLine("2. View Vehicles");
            Console.WriteLine("3. QUIT\n");
            String command = sc.nextLine();
            return command;
        }

        private static void AddVehicle()
        {
            String vType = getVehicleEngine();
            Boolean tow = getBool("Does Vehicle have towing capabilities?:(y or n)");
            String towing = "";
            if (tow)
            {
                towing = "Can Tow";
            }
            else
            {
                towing = "Cannot Tow";
            }
            String cap = getCarrierCapability();
            Boolean wifi = getBool("Does Vehicle support wifi?:(y or n)");
            Boolean sound = getBool("Does Vehicle have a sound system?:(y or n)");
            Boolean camera = getBool("Does Vehicle have a reversing camera assist?:(y or n)");
            String des = getDetails(vType, wifi, sound, camera);
            Vehicle_ v = new Vehicle_(vehicles.size(), vType, towing, cap, wifi, sound, camera, des);
            context = new Context(new OperationAdd());
            context.executeStrategy(vehicles, v);
            // -------------
            switch (vType)
            {
                case "s":
                    p.detach(s2);
                    p.detach(s3);
                    p.attach(s1);
                    p.notifyUpdate(new Message("Bike added."));
                    break;
                case "m":
                case "l":
                    p.detach(s1);
                    p.detach(s3);
                    p.attach(s2);
                    p.notifyUpdate(new Message("Light Vehicle added."));
                    break;
                case "xl":
                    p.detach(s2);
                    p.detach(s1);
                    p.attach(s3);
                    p.notifyUpdate(new Message("Heavy Vehicle added."));
                    break;
                default:
                    Console.WriteLine("Invalid vehicle type!!!");
                    break;
            }
        }

        private static String getVehicleEngine()
        {
            Console.WriteLine("Enter Vehicle engine type:(s, m, l or xl)");
            Console.WriteLine("1. small");
            Console.WriteLine("2. medium");
            Console.WriteLine("3. large");
            Console.WriteLine("4. x-large");
            String vt = sc.nextLine();
            try
            {
                String[] engines = { "s", "m", "l", "xl" };
                return engines[Integer.parseInt(vt) - 1];
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input!!!");
                return getVehicleEngine();
            }

        }

        private static String getCarrierCapability()
        {
            try
            {
                Console.WriteLine("Select carrier capabilities:");
                String[] options = { "Good and Driver", "2 people max, and bag", "5 people max and few luggage", "20 people max", "65 people max" };
                for (int i = 0; i < options.length; i++)
                {
                    String option = options[i];
                    Console.WriteLine(i + ". " + option);
                }
                String res = sc.nextLine();
                return options[Integer.parseInt(res)];
            }
            catch (Exception e)
            {
                return getCarrierCapability();
            }
        }

        private static String getDetails(String engineString, Boolean wifi, Boolean sound, Boolean camera)
        {
            String res = "";
            Vehicle_ v = new Vehicle_();
            double[] bikes = { v.BikeWifi, v.BikeSoundSystem, v.BikeCamera };
            double[] light = { v.LightVehicleWifi, v.LightVehicleSoundSystem, v.LightVehicleCamera };
            double[] heavy = { v.HeavyVehicleWifi, v.HeavyVehicleSoundSystem, v.HeavyVehicleCamera };
            double[] values;

            if (engineString == "s")
            {
                values = bikes;
            }
            else if (engineString == "l" || engineString == "m")
            {
                values = light;
            }
            else
            {
                values = heavy;
            }
            if (!wifi)
            {
                res += "Wifi fee: R" + values[0] + ". ";
            }
            if (!sound)
            {
                res += "Sound system fee: R" + values[1] + ". ";
            }

            if (!camera)
            {
                res += "Reverse camera fee: R" + values[2];
            }
            return res;
        }

        private static Boolean getBool(String msg)
        {
            Console.WriteLine(msg);
            String res = sc.nextLine();
            return "y".equals(res);
        }

        private static void ViewVehicles()
        {
            context = new Context(new OperationDisplay());
            context.executeStrategy(vehicles, new Vehicle_());

            
        }
        
      }
    }


