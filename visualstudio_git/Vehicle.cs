using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualstudio_git
{
    internal class Vehicle
    {
        private string _brand;
        private string _model;
        private int _year;


        public Vehicle(string brand,string model, int year) {
        
                this._brand = brand;
                this._model = model;    
                this._year = year;
                    
        }

        public virtual void DispalayInfo()
        {

            Console.WriteLine($"Brand: {_brand} , Model: {_model} , Year : {_year} ");
        }



    }

    class Car : Vehicle
    {
        private int _noOfDoors;

        public Car(string brand,string model,int year, int noOfDoors):base(brand,model,year)
        {
            this._noOfDoors = noOfDoors;
        }


        public override void DispalayInfo()
        {
            base.DispalayInfo();
            Console.WriteLine($"number of doors: {_noOfDoors}");

        }


    }

}
