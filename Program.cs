public class Program
{
 static void Main(string[] args)
 {
 //Show Input before
     string name = InputName();
     int number = InputNumber();
     string owner = OwnerName();
     int value = InputValue();
 //Info User
     Info info = new Info();
     info.PrintInformation(name,number,owner,value);
 //Show Money After Calculate Change
     string ValueM = InputMoney();
     double ValueX = ConvertStringToDouble(ValueM);
     CalculateMoney money = new CalculateMoney();
     money.CalculateChange(ValueX);

  
 }
 
 //Input
 public static string InputName()
 {
      Console.Write("Please input Name: ");
      return Console.ReadLine();
 }
 public static int InputNumber()
 {
      Console.Write("Please input Number: ");
      return int.Parse(Console.ReadLine());
 }
 public static string OwnerName()
 {
      Console.Write("Please input Owner Name: ");
      return Console.ReadLine();
 }
  public static int InputValue()
 {
      Console.Write("Registered Value: ");
      return int.Parse(Console.ReadLine());
 }

 //Input Money for Calculate Change
 public static string InputMoney()
 {
      Console.Write("Please input money: ");
      return Console.ReadLine();
 }

 public static double ConvertStringToDouble(string value)
 { 
     if(double.TryParse(value, out double number))
     {
          return number;
     }
     throw new Exception("Please input you money.");
 }

}
// last time to working 17:10 '
