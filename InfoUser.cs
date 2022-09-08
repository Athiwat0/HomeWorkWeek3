public class Info
{
public void PrintInformation(string name,int number,string owner,int value)
{
    Console.WriteLine("------------------------- Shop Information-------------------------");
    Console.WriteLine("Name: {0}",name);
    Console.WriteLine("Number: {0}",number);
    Console.WriteLine("Owner Name: {0}",owner);
    Console.WriteLine("Registered Value: {0}",value);
    Console.WriteLine("-------------------------------------------------------------------");
    Console.Write("Enter to Next"); Console.ReadLine();
}
}