using System;
using System.Collections.Generic;
using System.Text;

namespace TV
{
    class TV
    {
        private string model;
        private int size;
        private int resolution;

        public TV()
        {
            this.model = "Samsung";
            this.size = 32;
            this.resolution = 32;
        }
        public TV(string m, int s, int r)
        {
            this.model = m;
            this.size = s;
            this.resolution = r;
        }
        public void turnonTV(string person)
        {
            Console.WriteLine("The person " + person + "turn on the TV!");
        }
        public void turnoffTV(string person)
        {
            Console.WriteLine("The person " + person + "turn off the TV!");
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Size
        {
            get { return this.size; }
            set { this.size = value;}
        }
        public int Resolution
        {
            get { return this.resolution; }
            set { this.resolution = value; }
        }
        public override string ToString()
        {
            return "The model of the TV is " + this.model + " " + ", the size is " + this.size + " " + "and the resolution is " + this.resolution + "!";
        }
    }
}
