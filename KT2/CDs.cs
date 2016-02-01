using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT2
{
    class CDs
    {
        //cds holds cd objects
        private List<CD> cds;

        //default constuction initializes a collection
        public CDs()
        {
            cds = new List<CD>();
        }

        //Adds a cd to collection
        public void AddPerson(CD cd)
        {
            cds.Add(cd);
        }

        //returns a cd to caller application
        public CD GetCD(int index)
        {
            if (index < cds.Count)
            {
                return cds.ElementAt(index);
            }
            else return null;
        }

        public CD FindCD(double Price)
        {
            foreach(CD cd in cds)
            {
                if(Price.Equals(Price))
                {
                    //cd with price found..
                    return cd;
                }
            }
            //cd with price not found..
            return null;
        }
        public void PrintCollection()
        {
            Console.WriteLine("CD in a collection:");
            foreach (CD cd in cds)
            {
                Console.WriteLine(cd.ToString());
            }
        }
    }
}
