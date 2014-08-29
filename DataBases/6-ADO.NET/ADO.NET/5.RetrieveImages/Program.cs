using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;

namespace _5.RetrieveImages
{
    // 5.Write a program that retrieves the images for all categories in the Northwind database and stores them as JPG files in the file system.
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionStringSettings connectionSettings = ConfigurationManager.ConnectionStrings["SQLDB"];
            SqlConnection dbConnection = new SqlConnection(connectionSettings.ConnectionString);
            dbConnection.Open();

            using (dbConnection)
            {
                SqlCommand selectImages = new SqlCommand("SELECT CategoryName, Picture FROM Categories", dbConnection);
                SqlDataReader imagesReader = selectImages.ExecuteReader();

                using (imagesReader)
                {
                    while (imagesReader.Read())
                    {
                        string imageName = (string)imagesReader["CategoryName"];
                        imageName = imageName.Replace("/", " ");

                        byte[] imageArray = (byte[])imagesReader["Picture"];
                        // 78 - The meaning of life
                        MemoryStream imageStream = new MemoryStream(imageArray, 78, imageArray.Length - 78);
                        Image picture = Image.FromStream(imageStream);

                        using (picture)
                        {
                            string filePath = Path.Combine("Images", imageName + ".jpg");
                            picture.Save(filePath, ImageFormat.Jpeg);
                        }
                    }
                }
            }
        }
    }
}
