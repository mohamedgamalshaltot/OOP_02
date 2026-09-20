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
        }
    }
}
