﻿namespace P02_CarsSalesman
{
    using System.Text;
    public class Car
    {
        private const string offset = "  ";
        private const string defaultColor = "n/a";
        private const int defaultWeight = -1;

        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine)
            :this(model, engine, defaultWeight, defaultColor)
        {          
        }

        public Car(string model, Engine engine, int weight)
            :this(model, engine, weight, defaultColor)
        {            
        }

        public Car(string model, Engine engine, string color)
            :this(model, engine, defaultWeight, color)
        {           
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}:\n", this.model);
            sb.Append(this.engine.ToString());
            sb.AppendFormat("{0}Weight: {1}\n", offset, this.weight == -1 ? defaultColor : this.weight.ToString());
            sb.AppendFormat("{0}Color: {1}", offset, this.color);

            return sb.ToString();
        }
    }
}
