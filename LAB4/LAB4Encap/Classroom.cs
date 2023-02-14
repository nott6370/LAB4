using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4Encap
{
    internal class Classroom
    {
        private string StName;
        private List<Person> persons = new List<Person>();

        public Classroom(string name)
        {
            this.StName = name;
        }
        public void addPersonToClass(Person p)
        {
            persons.Add(p);
        }
        public string AllPerson()
        {
            string result = "";
            foreach (Person p in persons)
            {
                result += p.getName() + "\r\n";
            }
            return result;
        }
        public void addYear(Person y)
        {
            persons.Add(y);
        }
        public string AllYear()
        {
            int year = 0;
            foreach (Person y in persons)
            {
                int currentAge = year;
                int newTotalAge = currentAge + y.getAge();
                year = newTotalAge;
            }
            return year.ToString();
        }
        public void addGPAToClass(Person g)
        {
            persons.Add(g);
        }
        public string avgMaxGPA()
        {
            double totalGPA = 0;
            int count = 0;
            foreach (Person g in persons)
            {
                totalGPA += g.getGPA();
                count++;
            }
            double avgGPA = totalGPA / count;
            return avgGPA.ToString();
        }
        public string maxGPA()
        {
            double totalGPA = 0;
            int count = 0;
            double maxGPA = 0;
            string name = "";
            foreach (Person g in persons)
            {
                double currentGPA = g.getGPA();
                totalGPA += currentGPA;
                count++;
                if (currentGPA > maxGPA)
                {
                    maxGPA = currentGPA;
                    name = g.getName();
                }
            }
            return maxGPA.ToString();
        }
        public string minGPA()
        {
            double totalGPA = 0;
            int count = 0;
            double minGPA = double.MaxValue;
            string name = "";
            foreach (Person g in persons)
            {
                double currentGPA = g.getGPA();
                totalGPA += currentGPA;
                count++;
                if (currentGPA < minGPA)
                {
                    minGPA = currentGPA;
                    name = g.getName();
                }
            }
            return minGPA.ToString();
        }
        public string minGPA_StName()
        {
            double totalGPA = 0;
            int count = 0;
            double minGPA = double.MaxValue;
            string name = "";
            foreach (Person g in persons)
            {
                double currentGPA = g.getGPA();
                totalGPA += currentGPA;
                count++;
                if (currentGPA < minGPA)
                {
                    minGPA = currentGPA;
                    name = g.getName();
                }
            }
            return name;
        }
        public string maxGPA_StName()
        {
            double totalGPA = 0;
            int count = 0;
            double maxGPA = 0;
            string name = "";
            foreach (Person g in persons)
            {
                double currentGPA = g.getGPA();
                totalGPA += currentGPA;
                count++;
                if (currentGPA > maxGPA)
                {
                    maxGPA = currentGPA;
                    name = g.getName();
                }
            }
            return name;
        }
    }
}
