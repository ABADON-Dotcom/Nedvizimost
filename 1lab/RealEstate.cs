using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1lab
{
    public class RealEstate
    {
        public string Owner { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int EstimatedValue { get; set; }

        public RealEstate(string owner, DateTime registrationDate, int estimatedValue)
        {
            Owner = owner;
            RegistrationDate = registrationDate;
            EstimatedValue = estimatedValue;
        }
    }
}