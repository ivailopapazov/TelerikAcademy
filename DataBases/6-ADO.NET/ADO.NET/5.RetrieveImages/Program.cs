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
                        MemoryStream imageStream = new MemoryStream(imageArray);
                        //imageStream.Write(imageArray, 0, imageArray.Length);
                        Image picture = Image.FromStream(imageStream);

                        using (picture)
                        {
                            picture.Save(Path.Combine("Images", imageName + ".jpg"), ImageFormat.Jpeg);
                        }
                    }
                }
            }
        }
    }
}
