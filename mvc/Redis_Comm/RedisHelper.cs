using mvc.Models;
using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Web;

namespace mvc.Redis_Comm
{
    public class RedisHelper
    {
        public string Str()
        {
            using (RedisClient redisClient = new RedisClient("192.168.131.128", 6379, "123123"))
            {
                string message = "";
                IRedisTypedClient<Phone> phones = redisClient.As<Phone>();
                Phone phoneFive = phones.GetValue("5");
                if (phoneFive == null)
                {
                    // make a small delay 
                    Thread.Sleep(5000);
                    // creating a new Phone entry 
                    phoneFive = new Phone
                    {
                        Id = 5,
                        Manufacturer = "Motorolla",
                        Model = "xxxxx",
                        Owner = new Person
                        {
                            Id = 1,
                            Age = 90,
                            Name = "OldOne",
                            Profession = "sportsmen",
                            Surname = "OldManSurname"
                        }
                    };
                    // adding Entry to the typed entity set 
                    phones.SetEntry(phoneFive.Id.ToString(), phoneFive);
                }
                message = "Phone model is " + phoneFive.Manufacturer;
                message += "Phone Owner Name is: " + phoneFive.Owner.Name;
                return message;
            } 
        }
    }
}