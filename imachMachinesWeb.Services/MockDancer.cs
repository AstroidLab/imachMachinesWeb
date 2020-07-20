﻿using imachMachinesWeb.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace imachMachinesWeb.Services
{
    public class MockDancer
    {
        private List<Dancer> _DancerList;

        public MockDancer()
        {
            _DancerList = new List<Dancer>()
            {
                new Dancer()
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
                    
                 
                 }
            };
        }

        public IEnumerable<Dancer> GetAllDancers()
        {
            return _DancerList;
        }
    }
}
