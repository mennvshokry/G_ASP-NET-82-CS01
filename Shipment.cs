using System;

namespace SmartDeliveryManagementSystem
{
    public class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;

        public string TrackingCode
        {
            get => trackingCode;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tracking code cannot be empty.");
                trackingCode = value;
            }
        }

        public string Description
        {
            get => description;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Description cannot be empty.");
                description = value;
            }
        }

        public decimal Weight
        {
            get => weight;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Weight must be greater than zero.");
                weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get => deliveryFee;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Delivery fee cannot be negative.");
                deliveryFee = value;
            }
        }

        public DeliveryAddress Destination { get; set; }

        public virtual decimal EstimatedCost => DeliveryFee + (Weight * 5);

        public Shipment()
        {
            TrackingCode = "UNKNOWN";
            Description = "N/A";
            Weight = 1.0m;
            DeliveryFee = 0.0m;
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            DeliveryFee = newFee;
        }

        public virtual void PrintShipment()
        {
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}
