using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jjangchin_kiosk
{
    class User
    {
        public List<Item> Resent
        {
            get;
        }

        public List<Item> Recommand
        {
            get;
        }

        public string Name
        {
            get;
        }

        public User(string name,List<Item> resent, List<Item> recommand)
        {
            Name = name;
            Resent = resent;
            Recommand = recommand;
        }
    }
    class Item
    {
        public string Name
        {
            get;
            set;
        }
        public string Image {
            get;
        }
        public Item(string name, string image)
        {
            Name = name;
            Image = image;
        }
    }
}
