using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_8
{
    internal class Father : IWorker, IMemberOfFamily, IComparable, ICloneable
    {
        private string _name;
        private string _lastName;
        private int _age;

        public Father(string Name, string LastName, int Age)
        {
            _name = Name;
            _lastName = LastName;
            _age = Age;
        }

        public string Name { get { return _name; } }
        public string LastName { get { return _lastName; } }
        public int Age { get { return _age; } }

        public int CompareTo(object obj)
        {
            Father temp = (Father)obj;
            return this.LastName.CompareTo(temp.LastName);
        }

        public Father ShallowClone()
        {
            return (Father)this.MemberwiseClone();
        }

        public object Clone()
        {
            Father f = new Father(_name, _lastName, _age);
            return f;
        }

        Random random = new Random();

        public string Working(Father father)
        {
            if (random.Next(0, 2) == 0)
                return "Работает";
            else
                return "Не работает";
        }

        public string Earning(Father father)
        {

            if (random.Next(0, 2) == 0)
                return "Зарабатывает";
            else
                return "Не зарабатывает";
        }

        public override string ToString()
        {
            return $" {Name}, {LastName}, {Age}"; ;
        }
    }
}
