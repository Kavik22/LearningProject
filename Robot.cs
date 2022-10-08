using System;

namespace Project{
    class Robot{
        
        private string name;

        private float weight;

        private short[] coordinates;

        public Robot(string name, float weight, short[] coordinates){
            this.set_data(name, weight, coordinates);
        }

        public void set_data(string name, float weight, short[] coordinates){
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;
        }

        public void print_data(){
            System.Console.WriteLine("Name: {0}. Weight: {1}.",name,weight);
            System.Console.Write("Coordinates: ");
            foreach(byte i in coordinates)
                System.Console.Write(i + " ");




        }

    }
}