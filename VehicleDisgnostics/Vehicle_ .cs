using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDisgnostics
{
     class Vehicle_
    {
        public  double BikeSoundSystem = 1000.0;
        public   double BikeWifi = 750.0;
        public  double BikeCamera = 200.0;
        // light vehicle
        public  double LightVehicleSoundSystem = 1200.0;
        public  double LightVehicleWifi = 950.0;
        public  double LightVehicleCamera = 400.0;
        // heavy vehicle
        public  double HeavyVehicleSoundSystem = 1400.0;
        public  double HeavyVehicleWifi = 1000.0;
        public  double HeavyVehicleCamera = 600.0;
        // -------------------------------------------------------
        private int vehicleNumber;
        private String engineType;
        private String towingCapability;
        private String carrierCapability;
        private Boolean wifiCapability;
        private Boolean soundSystem;
        private Boolean reversingAssistCamera;
        private String description;

        public int getVehicleNumber()
        {
            return vehicleNumber;
        }

        public void setVehicleNumber(int vehicleNumber)
        {
            this.vehicleNumber = vehicleNumber;
        }

        public String getDescription()
        {
            return description;
        }

        public void setDescription(String description)
        {
            this.description = description;
        }

        public Vehicle_()
        {

        }

        public Vehicle_(int vehicleNumber, String engineType, String towingCapability, String carrierCapability, Boolean wifiCapability, Boolean soundSystem, Boolean reversingAssistCamera, String description)
        {
            this.vehicleNumber = vehicleNumber;
            this.engineType = engineType;
            this.towingCapability = towingCapability;
            this.carrierCapability = carrierCapability;
            this.wifiCapability = wifiCapability;
            this.soundSystem = soundSystem;
            this.reversingAssistCamera = reversingAssistCamera;
            this.description = description;
        }

        public String getEngineType()
        {
            return engineType;
        }

        public void setEngineType(String engineType)
        {
            this.engineType = engineType;
        }

        public String getTowingCapability()
        {
            return towingCapability;
        }

        public void setTowingCapability(String towingCapability)
        {
            this.towingCapability = towingCapability;
        }

        public String getCarrierCapability()
        {
            return carrierCapability;
        }

        public void setCarrierCapability(String carrierCapability)
        {
            this.carrierCapability = carrierCapability;
        }

        public Boolean isWifiCapability()
        {
            return wifiCapability;
        }

        public void setWifiCapability(Boolean wifiCapability)
        {
            this.wifiCapability = wifiCapability;
        }

        public Boolean isSoundSystem()
        {
            return soundSystem;
        }

        public void setSoundSystem(Boolean soundSystem)
        {
            this.soundSystem = soundSystem;
        }

        public Boolean isReversingAssistCamera()
        {
            return reversingAssistCamera;
        }

        public void setReversingAssistCamera(Boolean reversingAssistCamera)
        {
            this.reversingAssistCamera = reversingAssistCamera;
        }

    }
}
