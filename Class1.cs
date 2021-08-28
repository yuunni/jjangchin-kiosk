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

        public User(List<Item> resent, List<Item> recommand)
        {
            Resent = resent;
            Recommand = recommand;
        }
    }
    class Item
    {
        string Name
        {
            get;
        }
        string Image {
            get;
        }
        public Item(string name, string image)
        {
            Name = name;
            Image = image;
        }
    }
}
