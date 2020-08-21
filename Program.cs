using System;

namespace ImgConvertToBase64
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] imageArray = System.IO.File.ReadAllBytes(@"/Users/sergeykuznetsov/Documents/GitHub/ImgToBase64/ImgConvertToBase64/testPicture.jpg");
            
            string base64String = Convert.ToBase64String(imageArray);
            Console.WriteLine(base64String);
            
            //Console.WriteLine("Encode");
            //var base64EncodedBytes = System.Convert.FromBase64String(base64String);
            //string encode = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            //Console.WriteLine(encode);
        }
    }
}
