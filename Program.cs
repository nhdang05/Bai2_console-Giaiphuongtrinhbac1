internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int intA, intB;
        double dbekq;
        Console.WriteLine(" --------------- CHUONG TRINH GIAI PHUONG TRINH BAC 1 --------------- ");
        Console.WriteLine(" ------------------------------- aX + b = 0 ------------------------- ");
        Console.WriteLine("Nhap a: ");
        intA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap b: ");
        intB = Convert.ToInt32(Console.ReadLine());
        if (intA == 0 && intB == 0)
        {
            Console.WriteLine(" Phuong trinh co vo so nghiem");
        }
        else if (intA == 0 && intB != 0)
        {
            Console.WriteLine(" Phuong trinh vo nghiem");
        }
        else
        {
            dbekq = (double)-intB / intA;
            Console.WriteLine(" phuong trinh co 1 nghiem duy nhat x = {0}", dbekq);
        }
    }
}