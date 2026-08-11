using System;

namespace SmartDeliveryManagementSystem
{
    public class InternationalShipment : Shipment
    {
        private string destinationCountry;
        private decimal customsFee;

        public string DestinationCountry
        {
            get => destinationCountry;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Destination country cannot be null, empty, or whitespace.");
                destinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get => customsFee;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Customs fee must be greater than or equal to 0.");
                customsFee = value;
            }
        }

        public override decimal EstimatedCost => base.EstimatedCost + CustomsFee;

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine($"Tracking Code      : {TrackingCode}");
            Console.WriteLine($"Description        : {Description}");
            Console.WriteLine($"Weight             : {Weight} KG");
            Console.WriteLine($"Delivery Fee       : {DeliveryFee} EGP");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee        : {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost     : {EstimatedCost} EGP");
        }
    }
}