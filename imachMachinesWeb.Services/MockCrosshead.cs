using imachMachinesWeb.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace imachMachinesWeb.Services
{
    public class MockCrosshead
    {
        private List<Crosshead> _CrossheadList;

        public MockCrosshead()
        {
            _CrossheadList = new List<Crosshead>()
            {
                new Crosshead()
                {

                    Id=1,
                    ShortCode="ACHD",
                    PhotoPath="ACHD.png",
                    ModelPath="ACHD.gltf",
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
                    
                 
                 }
            };
        }

        public IEnumerable<Crosshead> GetAllCrossheads()
        {
            return _CrossheadList;
        }
    }
}
