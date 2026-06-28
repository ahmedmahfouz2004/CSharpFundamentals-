namespace CSharp___Boolean_Data_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsAlive = false;
            Console.Write("IsAlive =");
            Console.WriteLine(IsAlive);

            Console.WriteLine("========================");
            //AND
            bool boolean1 = false, boolean2 = false;
            bool result1 = boolean1 && boolean2;
            Console.Write("result1= ");
            Console.WriteLine(result1);

            Console.WriteLine("========================");
            //AND
            bool boolean3 = false, boolean4 = true;
            bool result2 = boolean3 && boolean4;
            Console.Write("result2= ");
            Console.WriteLine(result2); 
            
            Console.WriteLine("========================");
            //OR
            bool boolean5 = false, boolean6 = true;
            bool result3 = boolean3 || boolean4;
            Console.Write("result3= ");
            Console.WriteLine(result3);  
            
            Console.WriteLine("========================");
            //OR
            bool boolean7 = true, boolean8 = true;
            bool result4 = boolean7 || boolean8;
            Console.Write("result4= ");
            Console.WriteLine(result4);  
            
            Console.WriteLine("========================");
            //NOT
            bool boolean9 = true, boolean10 = false;
            bool result5 = !boolean9 ;
            bool result6 = !boolean10 ;
            Console.Write("result5= ");
            Console.WriteLine(result5);
            Console.Write("result6= ");
            Console.WriteLine(result6); 
            
            Console.WriteLine("========================");

            //xOR 
            //true => if both are different  
            //false => if both are same  
            bool boolean11 = true, boolean12 = false;
            bool result7 = boolean11 ^ boolean12 ;
            Console.Write("result7= ");
            Console.WriteLine(result7);

            Console.WriteLine("========================");

            bool boolean13 = true, boolean14 = true;
            bool result8 = boolean13 ^ boolean14;
            Console.Write("result8= ");
            Console.WriteLine(result8); 
            
            Console.WriteLine("========================");

            bool boolean15 = false, boolean16 = false;
            bool result9 = boolean15 ^ boolean16;
            Console.Write("result9= ");
            Console.WriteLine(result9);



        }
    }
}
