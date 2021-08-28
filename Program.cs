using System;
using System.Collections.Generic;
using Tizen.NUI;

namespace jjangchin_kiosk
{
    static class Program
    {

        public static Dictionary<string, User> globalData = new Dictionary<string, User>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            
            globalData.Add("2833670479702025", new User(
                new List<Item>(){ new Item("coffee","~.png"),
                new Item("apple","apple.png")},
                new List<Item>()));

            Scene1 Instance = new Scene1();
            Instance.Run(args);
        }
    }
}
