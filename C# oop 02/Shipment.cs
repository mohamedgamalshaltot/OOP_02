using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__oop_02
{
   internal class Shipment
    {
      public string trackingCode { get; set; }
        public string description { get; set; }
        public double weight { get; set; }
        public decimal deliveryFee { get; set; }
        public DeliveryAddress destination { get; set; }
       
        public Shipment(string trackingCode)
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
                throw new ArgumentException("Tracking code cannot be null or empty.");
            this.trackingCode = trackingCode;

            this.description = "";
            this.weight = 0;
            this.deliveryFee = 0;
            this.destination = new DeliveryAddress();

            SetDescription("Unknown");
            SetWeight(1);
            SetDeliveryFee(50);
        }

        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
            {
                throw new ArgumentException("Tracking code cannot be null or empty.", nameof(trackingCode));
            }
            this.trackingCode = trackingCode;
            this.description = "";
            this.weight = 0;
            this.deliveryFee = 0;
            this.destination = destination;

            SetDescription(description);
            SetWeight(weight);
            SetDeliveryFee(deliveryFee);
        }
        public string GetTrackingCode()
        {
            return trackingCode;
        }
        public string GetDescription()
        {
            return description;
        }
        public void SetDescription(string Value)
        {
            if (!string.IsNullOrWhiteSpace(Value))
                description = Value;
        }
        public double GetWeight()
        {
            return weight;
        }
        public void SetWeight(double value)
        {
            if (value >= 0)
            {
                weight = value;
            }
        }
        public decimal GetDeliveryFee()
        {
            return deliveryFee;
        }
        private void SetDeliveryFee(decimal value)
        {
            if (value >= 0)
            {
                deliveryFee = value;
            }
        }
        public DeliveryAddress GetDestination()
        {
            return destination;
        }
        public void SetDestination(DeliveryAddress value)
        {
            destination = value;
        }
        public virtual decimal EstimatedCost
        {
            get{
                 return deliveryFee * ((decimal)weight*5);

               }
            
        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                deliveryFee = newFee;
        }

        public void PrintShipment()
        {
            Console.WriteLine("Tracking Code : " + trackingCode);
            Console.WriteLine("Description   : " + description);
            Console.WriteLine("Weight        : " + weight);
            Console.WriteLine("Delivery Fee  : " + deliveryFee);
            Console.WriteLine("Destination   : " + destination + ", " + destination);
            Console.WriteLine("Estimated Cost: " );
        }
    }
}

