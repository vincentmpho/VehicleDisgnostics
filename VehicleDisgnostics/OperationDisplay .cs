using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDisgnostics
{
    class OperationDisplay : Istrategy
    {
        public void doOperation(List<Vehicle_> vehicles, Vehicle_ v)
        {
            for (int i = 0; i < vehicles.size(); i++)
            {
                Vehicle_ get = vehicles.get(i);
                Console.WriteLine("");
                Console.WriteLine("Vehicle number: " + get.getVehicleNumber());
                Console.WriteLine("Engine type: " + get.getEngineType());
                Console.WriteLine("Towing capability: " + get.getTowingCapability());
                Console.WriteLine("Carrier capabilities: " + get.getCarrierCapability());
                Console.WriteLine("Wifi: " + get.isWifiCapability());
                Console.WriteLine("Sound System: " + get.isSoundSystem());
                Console.WriteLine("Camera: " + get.isReversingAssistCamera());
                // -------
                HeavyVehicle hv = new HeavyVehicle();
                Console.WriteLine(hv.GetDescription());
                Console.WriteLine("Description: " + get.getDescription());
            }
        }
    }
