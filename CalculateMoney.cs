public class CalculateMoney
{
public void CalculateChange(double ValueX)
{
   ValueX = ValueX * 100;
   int N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,N11,ValueY;
   N1 = (int)(ValueX / 100000);
   ValueY = (int)(ValueX % 100000); 

   //2
   N2 = ValueY / 50000;
   ValueY = ValueY % 50000;
   //3
   N3 = ValueY / 10000;
   ValueY = ValueY % 10000;
   //4
   N4 = ValueY / 5000;
   ValueY = ValueY % 5000;
   //5
   N5 = ValueY / 2000;
   ValueY = ValueY % 2000;
   //6
   N6 = ValueY / 1000;
   ValueY = ValueY % 1000;
   //7
   N7 = ValueY / 500;
   ValueY = ValueY % 500;
   //8
   N8 = ValueY / 200;
   ValueY = ValueY % 200;
   //9
   N9 = ValueY / 100;
   ValueY = ValueY % 100;
   //10
   N10= ValueY / 50;
   ValueY = ValueY % 50;
   //11
   N11= ValueY / 25;
   ValueY = ValueY % 25;

   //Output
   Console.WriteLine("1000 : {0} ",N1);
   Console.WriteLine("500 : {0} ",N2);
   Console.WriteLine("100 : {0} ",N3);
   Console.WriteLine("50 : {0} ",N4);
   Console.WriteLine("20 : {0} ",N5);
   Console.WriteLine("10 : {0} ",N6);
   Console.WriteLine("5 : {0} ",N7);
   Console.WriteLine("2 : {0} ",N8);
   Console.WriteLine("1 : {0} ",N9);
   Console.WriteLine("0.50 : {0} ",N10);
   Console.WriteLine("0.25 : {0} ",N11);
   Console.WriteLine("-------------------------------------------------------------------");
   Console.Write("Program End");
   //spec to next
   Console.ReadLine();


 

}

}
