using System;
using System.Text.Json.Serialization;
using Nest;

namespace NestSampleCode.Models
{
    public class Person 
    {
        [JsonPropertyName("age")]
        public int Age {get;set;}

        [JsonPropertyName("eyeColor")]
        public string EyeColor {get;set;}

        [JsonPropertyName("name")]
        public string Name {get;set;}

        [JsonPropertyName("gender")]
        public string Gender {get;set;}

        [JsonPropertyName("company")]
        public string Company {get;set;}

        [JsonPropertyName("email")]
        public string Email {get;set;}

        [JsonPropertyName("phone")]
        public string Phone {get;set;}

        [JsonPropertyName("address")]
        public string Address{get;set;}

        [JsonPropertyName("about")]
        public string About {get;set;}

        [JsonPropertyName("registration_date")]
        public DateTime RegistrationDate {get;set;}

        [Ignore]
        [JsonPropertyName("latitude")]
        public double Latitude {get;set;}

        [Ignore]
        [JsonPropertyName("longitude")]
        public double Longitude {get;set;}

        public string Location => $"{Latitude},{Longitude}";
    }
}