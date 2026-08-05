using System;

namespace oop2
{
    //Question 1
    // a)

    // 1. class bit5zn f al heap, struct bit5zn f al stack
    // 2. class 3ady ib2a b null, struct noooo
    // 3. class 3ady iwors (polymorphism), struct nooo

    // b)

    // 1. class 3adi tst5dm references f dah bisar3 fi al
    // t3aml m3 al peogaem al kpira

    //================================================================

    //Question 2
    // a) Shipment
    // b) ExpressShipment
    // c) TrackingCode
    // d) lw hnsal7 7aga hnsl7a bs f al parent class w htsm3 f al ba2i

    //================================================================

    // ======DeliveryAddress Struct======

    public struct DeliveryAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public DeliveryAddress(string street, string city, string country)
        {
            Street = street;
            City = city;
            Country = country;
        }

        public override string ToString()
        {
            return $"{Street}, {City}, {Country}";
        }
    }


    // ======Base Class: Shipment======

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
            set => description = value;
        }

        public decimal Weight
        {
            get => weight;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Weight must be greater than zero.");
                weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get => deliveryFee;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Delivery fee cannot be negative.");
                deliveryFee = value;
            }
        }

        public DeliveryAddress Destination { get; set; }

        public virtual decimal EstimatedCost => DeliveryFee + (Weight * 5);

        // Constructors
        public Shipment() { }

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


    // ======Derived Class: StandardShipment======

    public class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
    }

    
    // ======Derived Class: ExpressShipment======
    
    public class ExpressShipment : Shipment
    {
        private decimal extraFee;

        public decimal ExtraFee
        {
            get => extraFee;
            set
            {
                if (value < 0)
                    throw new ArgumentException("ExtraFee must be greater than or equal to 0.");
                extraFee = value;
            }
        }

        public override decimal EstimatedCost => base.EstimatedCost + ExtraFee;
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
                    : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }


    // ======Derived Class: InternationalShipment======

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
                    throw new ArgumentException("DestinationCountry cannot be null, empty, or whitespace.");
                destinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get => customsFee;
            set
            {
                if (value < 0)
                    throw new ArgumentException("CustomsFee must be greater than or equal to 0.");
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
            Console.WriteLine($"Tracking Code      : {TrackingCode}");
            Console.WriteLine($"Description        : {Description}");
            Console.WriteLine($"Weight             : {Weight} KG");
            Console.WriteLine($"Delivery Fee       : {DeliveryFee} EGP");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee        : {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost     : {EstimatedCost} EGP");
        }
    }


    // ======DeliveryCenter Class======

    public class DeliveryCenter
    {
        public string CenterName { get; set; }
        private Shipment[] shipments = new Shipment[20];
        private int count = 0;

        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
        }

        public bool AddShipment(Shipment shipment)
        {
            if (count < shipments.Length && shipment != null)
            {
                shipments[count] = shipment;
                count++;
                return true;
            }
            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < count; i++)
            {
                if (shipments[i].TrackingCode.Equals(trackingCode, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        shipments[j] = shipments[j + 1];
                    }
                    shipments[count - 1] = null;
                    count--;
                    return true;
                }
            }
            return false;
        }

        public Shipment this[string trackingCode]
        {
            get


            {
                for (int i = 0; i < count; i++)
                {
                    if (shipments[i].TrackingCode.Equals(trackingCode, StringComparison.OrdinalIgnoreCase))
                        return shipments[i];
                }
                return null;
            }
        }

        public void PrintAllShipments()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine($"Delivery Center : {CenterName}");
            Console.WriteLine("==============================================");

            for (int i = 0; i < count; i++)
            {
                if (shipments[i] is StandardShipment)
                    Console.WriteLine("Standard Shipment\n");
                else if (shipments[i] is ExpressShipment)
                    Console.WriteLine("Express Shipment\n");
                else if (shipments[i] is InternationalShipment)
                    Console.WriteLine("International Shipment\n");

                shipments[i].PrintShipment();
                Console.WriteLine("----------------------------------------------");
            }
        }
    }


    // ======Program Main Execution======

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Delivery Center Name: ");
            string centerName = Console.ReadLine();
            DeliveryCenter center = new DeliveryCenter(centerName);

            // Dummy address shared by samples
            DeliveryAddress defaultAddr = new DeliveryAddress("Street 1", "Cairo", "Egypt");

            // 1. Create Standard Shipment
            StandardShipment s1 = new StandardShipment("SH001", "Laptop", 3, 80, defaultAddr);

            // 2. Create Express Shipment
            ExpressShipment s2 = new ExpressShipment("SH002", "Mobile Phone", 2, 60, defaultAddr, 30);

            // 3. Create International Shipment
            InternationalShipment s3 = new InternationalShipment("SH003", "Television", 8, 120, defaultAddr, "Germany", 100);

            // Add to center
            if (center.AddShipment(s1)) Console.WriteLine("Shipment Added Successfully.");
            if (center.AddShipment(s2)) Console.WriteLine("Shipment Added Successfully.");
            if (center.AddShipment(s3)) Console.WriteLine("Shipment Added Successfully.");

            Console.WriteLine();

            // Print All
            center.PrintAllShipments();

            // Search Indexer
            Console.Write("\nEnter Tracking Code to Search: ");
            string searchCode = Console.ReadLine();
            Shipment found = center[searchCode];
            if (found != null)
            {
                Console.WriteLine("\nShipment Found:");
                found.PrintShipment();
            }
            else
            {
                Console.WriteLine("\nShipment Not Found!");
            }

            // Remove Shipment
            Console.Write("\nEnter Tracking Code to Remove: ");
            string removeCode = Console.ReadLine();
            if (center.RemoveShipment(removeCode))
            {
                Console.WriteLine("\nShipment Removed Successfully.");
            }
            else
            {
                Console.WriteLine("\nFailed to Remove Shipment.");
            }

            Console.WriteLine("\n==============================================");
            Console.WriteLine("Remaining Shipments");
            Console.WriteLine("==============================================");
            center.PrintAllShipments();
        }
    }
}

