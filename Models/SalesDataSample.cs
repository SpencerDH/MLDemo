using System;
using System.Collections.Generic;

#nullable disable

namespace MLDemo.Models
{
    public partial class SalesDataSample
    {
        public int Ordernumber { get; set; }
        public int Quantityordered { get; set; }
        public double Priceeach { get; set; }
        public string Orderlinenumber { get; set; }
        public double Sales { get; set; }
        public DateTime Orderdate { get; set; }
        public string Status { get; set; }
        public string QtrId { get; set; }
        public string MonthId { get; set; }
        public int YearId { get; set; }
        public string Productline { get; set; }
        public int Msrp { get; set; }
        public string Productcode { get; set; }
        public string Customername { get; set; }
        public string Phone { get; set; }
        public string Addressline1 { get; set; }
        public string Addressline2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postalcode { get; set; }
        public string Country { get; set; }
        public string Territory { get; set; }
        public string Contactlastname { get; set; }
        public string Contactfirstname { get; set; }
        public string Dealsize { get; set; }
    }
}
