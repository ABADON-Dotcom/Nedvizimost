using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _1lab
{
    public class Logic
    {

        // Преобразовываем строку в объект типа RealEstate
        public RealEstate ToRealEstate(string str)
        {
            try
            {
                str = str.Replace("RealEstate", "");
                str = str.Replace("\"", "");

                List<string> finalValues = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string owner = finalValues[0].Trim();
                DateTime registrationDate = DateTime.Parse(finalValues[1].Trim());
                int estimatedValue = int.Parse(finalValues[2].Trim());

                return new RealEstate(owner, registrationDate, estimatedValue);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void PrintRealEstate(RealEstate realEstate)
        {
            Console.WriteLine($"Owner: {realEstate.Owner}; Registration Date: {realEstate.RegistrationDate}; Estimated Value: {realEstate.EstimatedValue}");
        }
    }
}