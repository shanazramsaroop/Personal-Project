using System;
namespace Personal_Project
{
    public class Working_with_strings
    {
        public Working_with_strings()
        {
            //string myString = "my \"so-called\" life";
            //string myString = "What if I need a\n new line?";
            //string myString = "Go to your c:\\ drive";
            //string myString = @"Go to your c:\ drive";

            //string myString = String.Format("{0} = {1}", "First", "Second");

            //string myString = String.Format("{0:C}", 145.23);
            //string myString = String.Format("{0:N}", 1234567890);
            //string myString = String.Format("{0:P}", 0.123);
            //string myString = String.Format("{0:(###) ###-####}", 1234567890);

            //string myString = " The summer we took threes across the board  ";

            //myString = myString.Substring(6,14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6,14);

            /*
            myString = String.Format("Length before: {0} -- Length after: {1}",
                myString.Length, myString.Trim().Length);
            

            
            for (int i = 1; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);


            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
