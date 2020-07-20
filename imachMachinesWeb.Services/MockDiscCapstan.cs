﻿using imachMachinesWeb.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace imachMachinesWeb.Services
{
    public class MockDiscCapstan
    {
        private List<DiscCapstan> _DoubleDiscCapstanList;

        public MockDiscCapstan()
        {
            _DoubleDiscCapstanList = new List<DiscCapstan>()
            {
                new DiscCapstan()
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

        public IEnumerable<DiscCapstan> GetAllDiscCapstans()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DiscCapstan> GetAllDoubleDiscCapstans()
        {
            return _DoubleDiscCapstanList;
        }
    }
}
