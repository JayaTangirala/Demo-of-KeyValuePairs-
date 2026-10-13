internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Key Value Pairs");


        KeyValuePair<int, string> student1 = new KeyValuePair<int, string>(1, "Jaya");


        Console.WriteLine("Key: " + student1.Key);
        Console.WriteLine("Value: " + student1.Value);

        KeyValuePair<int, string> student2 = new KeyValuePair<int, string>(2, "Lakshmi");
        Console.WriteLine("Key: " + student2.Key);
        Console.WriteLine("Value: " + student2.Value);

        KeyValuePair<int, string> student3 = new KeyValuePair<int, string>(3, "Tangirala");
        Console.WriteLine("Key: " + student3.Key);
        Console.WriteLine("Value: " + student3.Value);

        KeyValuePair<int, string>[] students= new KeyValuePair<int, string>[3];

        students[0] = student1;
        students[1] = student2;
        students[2] = student3;

        Console.WriteLine("Info of student1 is:");        
        Console.WriteLine(students[0].Key); Console.WriteLine(students[0].Value);

        for(int i=0;i<3;i++)
        {
            Console.WriteLine(students[i].Key);
            Console.WriteLine(students[i].Value);
        }


    }
}