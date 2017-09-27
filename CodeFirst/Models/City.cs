using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class City
    {
        [DisplayName("City Id")]
        public int CityId { get; set; }
        [DisplayName("City Name")]
        public string CityName { get; set; }
        public int Population { get; set; }
        [DisplayName("Province Code")]
        public string ProvinceCode { get; set; }
        public Province Province { get; set; }
    }
}