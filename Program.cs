using System;

namespace SmartDeliveryManagementSystem
{
    internal class Program
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

        static void Main(string[] args)
        {
            Console.Write("Enter Delivery Center Name: ");
            string centerName = Console.ReadLine();
            DeliveryCenter center = new DeliveryCenter(centerName);

            DeliveryAddress defaultAddr = new DeliveryAddress("Street 1", "Cairo", "Egypt");

            StandardShipment s1 = new StandardShipment("SH001", "Laptop", 3m, 80m, defaultAddr);
            ExpressShipment s2 = new ExpressShipment("SH002", "Mobile Phone", 2m, 60m, defaultAddr, 30m);
            InternationalShipment s3 = new InternationalShipment("SH003", "Television", 8m, 120m, defaultAddr, "Germany", 100m);

            center.AddShipment(s1);
            center.AddShipment(s2);
            center.AddShipment(s3);

            Console.WriteLine();
            center.PrintAllShipments();
            Console.WriteLine();

            Console.Write("Enter Tracking Code to Remove: ");
            string codeToRemove = Console.ReadLine();

            if (center.RemoveShipment(codeToRemove))
            {
                Console.WriteLine("Shipment Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Shipment Not Found.");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Remaining Shipments");
            center.PrintAllShipments();
        }
    }
}