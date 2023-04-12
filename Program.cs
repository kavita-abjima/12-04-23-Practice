using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using EXTENSION_METHOD_DEMO;

namespace ExceptionDemo
{
    class DevideByZero
    {
        static void Main(string[] args)
        {
            //try{
            //    string a = null;
            //    Console.WriteLine(a.Length);

            ////array
            //int[] arr = new int[3];
            //arr[0] = 11;
            //arr[1] = 22;
            //arr[2] = 33;
            //arr[4] = 44;

            //    //string
            //    string a = "Kavita";
            //    int b = int.Parse(a);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Trying with multiple catch block
            // try
            // {
            //int a = 10;
            //int b = 0;
            //int c = a / b;

            //string a = null;
            //Console.WriteLine(a.Length);

            //    //array
            //    int[] arr = new int[3];
            //    arr[0] = 11;
            //    arr[1] = 22;
            //    arr[2] = 33;
            //    arr[4] = 44;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("invalid input !!");
            //}
            ////Throw exception by user and Default Catch
            //Console.WriteLine("Enter the age: ");
            //int age = int.Parse(Console.ReadLine());
            //if (age > 18)
            //{
            //    Console.WriteLine("You are Eligible to vote...");
            //}
            //else
            //{
            //    throw new Exception("You are not Eligible to vote...");
            //}

            //Our throw and our catch
            //Console.WriteLine("Enter the age: ");
            //int age = int.Parse(Console.ReadLine());
            //try
            //{
            //    if (age > 18)
            //    {
            //        Console.WriteLine("You are Eligible to vote...");
            //    }
            //    else
            //    {
            //        throw new Exception("You are not Eligible to vote...");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //int acc_balance = 3000;
            //int withdrawl_ammount = 2000;
            //if(acc_balance< withdrawl_ammount)
            //{
            //    throw new Exception("Insufficint balance...");
            //}
            //else
            //{
            //    acc_balance = acc_balance - withdrawl_ammount;
            //    Console.WriteLine("Remaining ammount is:"+acc_balance);
            //    Console.WriteLine("Transaction complited sucessfully.....");
            //}


            Person P1 = new Person();
            P1.Func1();
            P1.Func2();


            Console.ReadLine();

        }
    }
}
namespace EXTENSION_METHOD_DEMO
{
   sealed class Person
    {
        public void Func1()
        {
            Console.WriteLine("This is Method one");
        }
        public void Func2()
        {
            Console.WriteLine("This is Method Two");
        }
    }
}