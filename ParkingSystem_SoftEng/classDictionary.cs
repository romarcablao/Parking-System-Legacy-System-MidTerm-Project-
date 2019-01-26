using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingSystem_SoftEng
{
    
    class classDictionary { }

    public class JoinAccountInfo
    {
        public string vehicleID { get; set; }
        public string vehicleOwner { get; set; }
        public string vehiclePlateNo { get; set; }
        public string vehicleType { get; set; }
        public string vehicleBrand { get; set; }
        public string vehicleColor { get; set; }

        public string brandID { get; set; }
        public string brandCategory { get; set; }
        public string brandName { get; set; }
        public string brandStatus { get; set; }

        public string typeID { get; set; }
        public string typeName { get; set; }
        public string typeRatePerHour { get; set; }

        public string slotID { get; set; }
        public string slotNumber { get; set; }
        public string slotBlock { get; set; }
        public string slotIsAvailable { get; set; }
        public string slotLastOccupied { get; set; }

        public string refID { get; set; }
        public string refBarcode { get; set; }
        public string refVehicleID { get; set; }
        public string refParkingID { get; set; }
        public string refTimeIn { get; set; }
        public string refTimeOut { get; set; }
        public string refPersonnelIn { get; set; }
        public string refPersonnelOut { get; set; }
        public string refStatus { get; set; }
        public string refTimeCount { get; set; }
        public string refPrice { get; set; }
        public string refAmountPaid { get; set; }
        public string refAmountChange { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }

    public class UserData
    {
        public string userID { get; set; }
        public string userLname { get; set; }
        public string userFname { get; set; }
        public string userUsername { get; set; }
        public string userPassword { get; set; }
        public string userAccLevel { get; set; }
        public string userStatus { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }

    public class VehicleInfo
    {
        public string vehicleID { get; set; }
        public string vehicleOwner { get; set; }
        public string vehiclePlateNo { get; set; }
        public string vehicleType { get; set; }
        public string vehicleBrand { get; set; }
        public string vehicleColor { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }

    public class VehicleBrand
    {
        public string brandID  { get; set; }
        public string brandCategory { get; set; }
        public string brandName { get; set; }
        public string brandStatus { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }

    public class VehicleType
    {
        public string typeID { get; set; }
        public string typeName { get; set; }
        public string typeRatePerHour { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }

    public class ParkingSlot
    {
        public string slotID { get; set; }
        public string slotNumber { get; set; }
        public string slotBlock { get; set; }
        public string slotIsAvailable { get; set; }
        public string slotLastOccupied { get; set; }
        public string updated_at { get; set; }
    }

    public class ReceiptReference
    {
        public string refID { get; set; }
        public string refBarcode { get; set; }
        public string refVehicleID { get; set; }
        public string refParkingID { get; set; }
        public string refTimeIn { get; set; }
        public string refTimeOut { get; set; }
        public string refPersonnelIn { get; set; }
        public string refPersonnelOut { get; set; }
        public string refStatus { get; set; }
        public string refTimeCount { get; set; }
        public string refPrice { get; set; }
        public string refAmountPaid { get; set; }
        public string refAmountChange { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }

}
