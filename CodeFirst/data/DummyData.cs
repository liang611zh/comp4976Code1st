using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.data
{
    public class DummyData
    {
        public static System.Collections.Generic.List<Province> getProvinces()
        {
            List<Province> provinces = new List<Province>
        {
            new Province() {
                ProvinceCode="BC",
                ProvinceName="British Columnbia"
            },
            new Province() {
                ProvinceCode="AB",
                ProvinceName="Alberta"
            },
            new Province() {
                ProvinceCode="ON",
                ProvinceName="Ontario"
            },
        };
            return provinces;
        }

        public static  List<City>getCities(ProvinceContext context)
        {
            List<City> cities = new List<City>
        {
            new City() {
                CityName = "Richmond",
                Population=653000,
                ProvinceCode=context.Provinces.Find("BC").ProvinceCode 
            },
            new City() {
                CityName = "Burnaby",
                Population= 523000,
                ProvinceCode=context.Provinces.Find("BC").ProvinceCode
            },
            new City() {
                CityName = "Vancouver",
                Population = 413000,
                ProvinceCode=context.Provinces.Find("BC").ProvinceCode
            },
            new City() {
                CityName = "Calgary",
                Population=3001230,
                ProvinceCode=context.Provinces.Find("AB").ProvinceCode
            },
            new City() {
                CityName = "Edmonton",
                Population=300230,
                ProvinceCode=context.Provinces.Find("AB").ProvinceCode
            },
            new City() {
                CityName = "Red Deer",
                Population=301100,
                ProvinceCode=context.Provinces.Find("AB").ProvinceCode
            },
            new City() {
                CityName = "Barrie",
                Population=2615060,
                ProvinceCode=context.Provinces.Find("ON").ProvinceCode
            },
            new City() {
                CityName = "Ottawa",
                Population=2615111,
                ProvinceCode=context.Provinces.Find("ON").ProvinceCode
            },
            new City() {
                CityName = "Toronto",
                Population=2615060,
                ProvinceCode=context.Provinces.Find("ON").ProvinceCode
            },
        };
            return cities;
        }
    }
}