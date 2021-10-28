using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Mail_Class
    {
        private string Org_Name;
        private string Country;
        private string City;
        private string Street;
        private string House_Number;
        private int Mail_Index;

        public Mail_Class(string Org_Name1, string Country1, string City1, string Street1, string House_Number1, int Mail_Index1)
        {
            this.Org_Name = Org_Name1;
            this.Country = Country1;
            this.City = City1;
            this.Street = Street1;
            this.House_Number = House_Number1;
            this.Mail_Index = Mail_Index1;
        }

        //get
        public string getName()
        {
            return this.Org_Name;
        }
        public string getCountry()
        {
            return this.Country;
        }
        public string getCity()
        {
            return this.City;
        }
        public string getStreet()
        {
            return this.Street;
        }
        public string getHouseNumber()
        {
            return this.House_Number;
        }
        public int getMail()
        {
            return this.Mail_Index;
        }
        //set
        public void setName(string Org_Name)
        {
            this.Org_Name = Org_Name;
        }
        public void setCountry(string Country)
        {
            this.Country = Country;
        }
        public void setCity(string City)
        {
            this.City = City;
        }
        public void setStreet(string Street)
        {
            this.Street = Street;
        }
        public void getHouseNumber(string House_Number)
        {
            this.House_Number = House_Number;
        }
        public void getMail(int Mail_Index)
        {
            this.Mail_Index = Mail_Index;
        }
    }
}
