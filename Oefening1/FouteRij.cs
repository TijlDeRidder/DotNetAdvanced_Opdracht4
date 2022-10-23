using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class FouteRij<T> : List<T>
    {
        public int Huidig = 0;
        public readonly bool isLeeg = true;
        public int count
        {
            get {{return this.Count; }}
        }
        public T HuidigElement
        {
            get {{return this[Huidig];}}
        }

        public T toevoegen(T iets)
        {
            this.Add(iets);
            if(this.Count == 0)
            {
                this[Huidig] = iets;
            }
            return this[Huidig];
        }

        public T verwijderen()
        {
                this.Remove(this[Huidig]);
                if (this.Count == 0)
                {
                    return default(T);
                }
                else
                {
                    Huidig = 0;
                    return this[Huidig];
                }
        }

        public T volgende()
        {
            if (this.Last().Equals(this[Huidig])){
                this[Huidig] = this.First();
            }
            else
            {
                Huidig++;
                return this[Huidig];
            }
            return this[Huidig];
        }

        public void leegmaken()
        {
            this.Clear();
            Huidig = default;
        }

        public T ZetAchteraan()
        {
            T temp = this[Huidig];
            this.Remove(this[Huidig]);
            this.Add(temp);
            Huidig = 0;
            return this[Huidig];
        }

        public override string ToString()
        {
            string temp = "";
            foreach(T iets in this)
            {
                temp += iets + ", ";
            }
            return temp;
        }
        public List<T> Copy()
        {
            List<T> list = new List<T>();
            list = this.Copy();
            return list;
        }
    }


}