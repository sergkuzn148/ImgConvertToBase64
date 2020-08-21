using System;
using System.Drawing;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;


namespace ImgToBase64
{
    class Program
    {

        static void Main(string[] args)
        {
            byte[] imageArray = System.IO.File.ReadAllBytes(@"/Users/sergeykuznetsov/Documents/GitHub/ImgToBase64/testPicture.jpg");
            string base64String = Convert.ToBase64String(imageArray);
            Console.WriteLine(base64String);
        }
    }
}
