using System;
using System.Collections.Generic;
using Tizen.NUI;

namespace jjangchin_kiosk
{
    static class Program
    {


        public static Dictionary<string, User> globalData = new Dictionary<string, User>();
        public static User selectedUser;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            
            globalData.Add("2833670479702025", new User("서윤재",
                new List<Item>(){ new Item("coffee","~.png"),
                new Item("apple","apple.png")},
                new List<Item>()
                {
                    new Item("맛있는 음료",""),
                    new Item("맛있는 음료1",""),
                    new Item("맛있는 음료2",""),
                }));

            globalData.Add("2861183814422024", new User("임동연",
                new List<Item>(){ new Item("coffee","~.png"),
                new Item("apple","apple.png")},
                new List<Item>(){
                    new Item("맛있는 음료",""),
                    new Item("맛있는 음료1",""),
                    new Item("맛있는 음료2",""),
                }));
            Scene1 Instance = new Scene1();
            Instance.Run(args);
        }
    }
}
