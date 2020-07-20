using imachMachinesWeb.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace imachMachinesWeb.Services
{
    public class MockExtruder
    {
        private List<Extruder> _extruderList;

        public MockExtruder()
        {
            _extruderList = new List<Extruder>()
            {
                new Extruder()
                {

                    Id=1,
                    ShortCode="AEXT35",
                    PhotoPath="AEXT35.png",
                    ModelPath="AEXT35.gltf",
                    ReelDiameter=630,
                    Power=7.5,
                    Length = 0,
                    Width = 0,
                    Height = 0,
                    Weight = 0, 
                    ProductionTime=0,
                    SafetyRegulation = "CE",
                    MaxLinearSpeed = new int[]{800,1000},
                    MaxRpm = new int[]{150,250},
                    SystemVoltage= new string[] { "380V 50Hz", "460V 60Hz"},
                    WorkingType = new string[]{"Active","Passive"},
                    WorkingMode = new string[]{"Speed","Torque"},
                    StandartEquipments= new string[] { "Pressure Sensor" , "Melt Heat Sensor"},
                    OptionalEquipments= new string[] { "Mobility Stand" , "Dosing Unit", "Quick Color Change", "Hopper Loader", "Granule Dryer" },                

                    //above coming from baseClass
                    //below coming from productOwnClass
                    
                    HeatingZones=4,
                    ScrewLength="20D, 24D, 27D, 30D, 32D",
                    StdScrewAbility="PVC,PE,XLPE,HDPE",
                    OptScrewAbility="HFFR,LSH",
                    CrossHeadsMain="x6",
                    CrossHeadsCo="x6 - x15",
                    Output="50",
                    ScrewCenterDrilled="No",
                    Moveable="Yes"
                 },new Extruder()
                {

                    Id=2,
                    ShortCode="AEXT45",
                    PhotoPath="AEXT45.png",
                    ModelPath="AEXT45.gltf",
                    ReelDiameter=630,
                    Power=7.5,
                    Length = 0,
                    Width = 0,
                    Height = 0,
                    Weight = 0,
                    ProductionTime=0,
                    SafetyRegulation = "CE",
                    MaxLinearSpeed = new int[]{800,1000},
                    MaxRpm = new int[]{150,250},
                    SystemVoltage= new string[] { "380V 50Hz", "460V 60Hz"},
                    WorkingType = new string[]{"Active","Passive"},
                    WorkingMode = new string[]{"Speed","Torque"},
                    StandartEquipments= new string[] { "Pressure Sensor" , "Melt Heat Sensor"},
                    OptionalEquipments= new string[] { "Mobility Stand" , "Dosing Unit", "Quick Color Change", "Hopper Loader", "Granule Dryer" },                

                    //above coming from baseClass
                    //below coming from productOwnClass
                    
                    HeatingZones=4,
                    ScrewLength="20D, 24D, 27D, 30D, 32D",
                    StdScrewAbility="PVC,PE,XLPE,HDPE",
                    OptScrewAbility="HFFR,LSH",
                    CrossHeadsMain="x6",
                    CrossHeadsCo="x6 - x15",
                    Output="50",
                    ScrewCenterDrilled="No",
                    Moveable="Yes"
                 }
            };
        }

        public IEnumerable<Extruder> GetAllExtruders()
        {
            return _extruderList;
        }
    }
}
