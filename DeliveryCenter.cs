using System;

namespace SmartDeliveryManagementSystem
{
    public class DeliveryCenter
    {
        public string CenterName { get; set; }
        private Shipment[] shipments;
        private int count;

        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
            shipments = new Shipment[20];
            count = 0;
        }

        public Shipment this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                    return null;
                return shipments[index];
            }
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

        public bool AddShipment(Shipment shipment)
        {
            if (count >= shipments.Length || shipment == null)
                return false;

            shipments[count] = shipment;
            count++;
            Console.WriteLine("Shipment Added Successfully.");
            return true;
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

        public void PrintAllShipments()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Delivery Center : {CenterName}");
            Console.WriteLine("----------------------------------------------");

            for (int i = 0; i < count; i++)
            {
                shipments[i].PrintShipment();
                if (i < count - 1)
                {
                    Console.WriteLine("----------------------------------------------");
                }
            }
        }
    }
}