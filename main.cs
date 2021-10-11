using System;

class Program {
  public static void Main (string[] args) {



double[] celcius = new double[7];
double[] fahrenheit = new double[7];


for(int pos=0; pos < 7; pos++)
{
  Console.WriteLine ("Enter the temperatures in celcius:");
  celcius[pos]=Convert.ToDouble(Console.ReadLine());

fahrenheit[pos]=(celcius[pos]*9/5)+32;

}
Console.WriteLine ("Temperature in Fahrenheit:");
for(int pos=0; pos < celcius.Length; pos++)
{
  
  
  Array.Sort(fahrenheit);

  Console.WriteLine(fahrenheit[pos]);
}
double sum=fahrenheit[0]+fahrenheit[1]+fahrenheit[2]+fahrenheit[3]+fahrenheit[4]+fahrenheit[5]+fahrenheit[6] ;

double average = sum / 7;

Console.WriteLine ("Average weekly temperature is " + average + " degrees fahrenheit");
  }
}