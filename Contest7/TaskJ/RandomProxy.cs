using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


class RandomProxy
{
    StreamWriter log;
    Dictionary<string, int> lalal =
    new Dictionary<string, int>();
    Random rnd = new Random(1579);

    public RandomProxy(StreamWriter log)
    {
        this.log = log;

    }

    public void Register(string login, int age)
    {
        if (lalal.ContainsKey(login))
        {
            throw new ArgumentException($"User {login}: login is already registered");
            
        }
        else
        {
            lalal.Add(login, age);
            log.WriteLine($"User {login}: login registered");
        }
    }

    public int Next(string login)
    {
        if (lalal.ContainsKey(login))
        {
            if (lalal[login] < 20)
            {

                int number = rnd.Next(0, 1000);
                log.WriteLine($"User {login}: generate number {number}");
                return number;
            }
            else
            {

                int number = rnd.Next(0, int.MaxValue);
                log.WriteLine($"User {login}: generate number {number}");
                return number;
            }
        }
        else
        {
            throw new ArgumentException($"User {login}: login is not registered");
        }
        
       
    }

    public int Next(string login, int maxValue)
    {
        if (lalal.ContainsKey(login))
        {
            if (lalal[login] < 20&&maxValue>1000)
            {
               throw new ArgumentOutOfRangeException($"User { login }: random bounds out of range");
            }
            else
            {
                int number= rnd.Next(0, maxValue);
                
                log.WriteLine($"User {login}: generate number {number}");
                return (number);
            }
        }
        else
        {
            throw new ArgumentException("User {login}: login is not registered");
        }
    }

    public int Next(string login, int minValue, int maxValue)
    {
        if (lalal.ContainsKey(login))
        {
            if (lalal[login] < 20 && (maxValue-minValue) > 1000)
            {
                throw new ArgumentOutOfRangeException($"User { login }: random bounds out of range");
            }
            else
            {
                int number = rnd.Next(minValue, maxValue);

                log.WriteLine($"User {login}: generate number {number}");
                return (number);
            }
        }
        else
        {
            throw new ArgumentException("User {login}: login is not registered");
        }
    }

}
