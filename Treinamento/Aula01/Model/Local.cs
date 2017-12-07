using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Model
{
    class Local
    {
        public string Code { get; set; }

        public int Size { get; set; } - 100;

        public Local()
        {

        }

        public Local(string code, int size)
        {
            Code = code;
            Size = size;
        }
        public virtual void Harvest()
        {

        }
    }
    class Sector : Local
    {
    

        public Farm[] Farms { get; set; }
        public Sector(string code, int size)
            : base(code, size)
        {
            
        }
        public override void Harvest()
        {
            Console.WriteLine("Harvest Sector {0} ", Code);
        }
    }

    class Farm : Local
    {


        public Block[] Blocks { get; set; }
    }

    class Block : Local
    {


        public Field[] Fields { get; set; }
    }
    class Field : Local
    {
       

        private string _culture;
        public string Culture
        {
            get
            {
                return _culture;
            }
             set
            {
                _culture = value;
            }
        }
        public void Plant(string culture)
        {
            Culture = culture;
        }

    }
}
