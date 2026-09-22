namespace C__oop_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            // ==========================================
            // Part 01 : Theoretical Questions
            // ==========================================

            // =========================================================================
            // Question 1:
            // =========================================================================
            // a) What is the difference between a class and a struct?
            // Answer:
            // 1. Memory Allocation: Class is a Reference Type (Heap), Struct is a Value Type (Stack).
            // 2. Inheritance: Class supports Inheritance, Struct does not support Inheritance.
            // 3. Performance: Struct is lightweight for small, short-lived data; Class is managed by GC.

            // b) Why are classes more suitable than structs for large applications?
            // Answer:
            // 1. Classes pass references instead of full copies, saving CPU & Memory.
            // 2. Classes support OOP principles like Inheritance and Polymorphism, essential for complex domain models.

            // =========================================================================
            // Question 2:
            // =========================================================================
            // a) Which class is the parent class?
            // Answer: Shipment

            // b) Which class is the child class?
            // Answer: ExpressShipment

            // c) What members are inherited by ExpressShipment?
            // Answer: TrackingCode property

            // d) Why is inheritance better than duplicating the same code in multiple classes?
            // Answer: It promotes Code Reusability, reduces code duplication (DRY Principle), and makes code maintenance much easier.
            #endregion
            #region Part 02
            Console.WriteLine("Enter Delivery Center Name: ");
            string? centerName = Console.ReadLine();
            DeliveryCenter center = new DeliveryCenter(centerName);
            // 1. Standard Shipment
            Console.Write("Enter Standard Shipment Tracking Code: ");
            string? code1 = Console.ReadLine();
            StandardShipment standard = new StandardShipment(code1, "Standard Package", 1.5, 10.0m, new DeliveryAddress());

            // 2. Express Shipment
            Console.Write("Enter Express Shipment Tracking Code: ");
            string? code2 = Console.ReadLine();
            Shipment express = new ExpressShipment(code2, "Express Package", 2.0, 25.0m, new DeliveryAddress());

            // 3. International Shipment
            Console.Write("Enter International Shipment Tracking Code: ");
            string? code3 = Console.ReadLine();
            Shipment intl = new InternationalShipment(code3, "International Package", 5.0, 50.0m, new DeliveryAddress());
            // 7
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(intl);
            // 8
            center.PrintAllShipments();
            // 9
            Console.Write("\nEnter Tracking Code to Search: ");
            string? searchCode = Console.ReadLine();

            Shipment foundShipment = center[searchCode];
            if (foundShipment != null)
            {
                Console.WriteLine($"Shipment Found: {foundShipment.trackingCode}");
            }
            else
            {
                Console.WriteLine("Shipment Not Found.");
            }
            // 10
            Console.Write("\nEnter Tracking Code to Remove: ");
            string? removeCode = Console.ReadLine();

            if (center.RemoveShipment(removeCode))
            {
                Console.WriteLine("Shipment removed successfully.");
            }
            else
            {
                Console.WriteLine("Failed to remove shipment.");
            }
            // 11
            Console.WriteLine("\n--- Remaining Shipments ---");
            center.PrintAllShipments();
            #endregion
        }
    }
}