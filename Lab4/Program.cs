using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        private interface IAbstractApp
        {
            IAbstractSettings Settings();
        }
        private class MacOSApp : IAbstractApp
        {
            private MacOSSettings MacOS = new MacOSSettings();
            public IAbstractSettings Settings()
            {
                return MacOS;
            }
        }
        private class WindowsApp : IAbstractApp
        {
            private WindowsSettings Windows = new WindowsSettings();
            public IAbstractSettings Settings()
            {
                return Windows;
            }
        }
        private class LinuxApp : IAbstractApp
        {
            private LinuxSettings Linux = new LinuxSettings();
            public IAbstractSettings Settings()
            {
                return Linux;
            }
        }
        private interface IAbstractSettings
        {
            void SetSetting1(string setting1);
            void SetSetting2(string setting2);
            void SetSetting3(string setting3);
            void SetSetting4(string setting4);
            void SetSetting5(string setting5);
            void SetSetting6(string setting6);
            void SetSetting7(string setting7);
            void SetSetting8(string setting8);
            void SetSetting9(string setting9);
            void SetSetting10(string setting10);
            string GetOS();
            string GetAllSettings();
            string GetSetting1();
            string GetSetting2();
            string GetSetting3();
            string GetSetting4();
            string GetSetting5();
            string GetSetting6();
            string GetSetting7();
            string GetSetting8();
            string GetSetting9();
            string GetSetting10();
        }

        private class MacOSSettings : IAbstractSettings
        {
            private string setting1 = "1", setting2 = "2", setting3 = "3", setting4 = "4", setting5 = "5", setting6 = "6", setting7 = "7", setting8 = "8", setting9 = "9", setting10 = "10";
            public void SetSetting1(string setting1)
            {
                this.setting1 = setting1;
            }
            public void SetSetting2(string setting2)
            {
                this.setting2 = setting2;
            }
            public void SetSetting3(string setting3)
            {
                this.setting3 = setting3;
            }
            public void SetSetting4(string setting4)
            {
                this.setting4 = setting4;
            }
            public void SetSetting5(string setting5)
            {
                this.setting5 = setting5;
            }
            public void SetSetting6(string setting6)
            {
                this.setting6 = setting6;
            }
            public void SetSetting7(string setting7)
            {
                this.setting7 = setting7;
            }
            public void SetSetting8(string setting8)
            {
                this.setting8 = setting8;
            }
            public void SetSetting9(string setting9)
            {
                this.setting9 = setting9;
            }
            public void SetSetting10(string setting10)
            {
                this.setting10 = setting10;
            }
            public string GetOS()
            {
                return "MacOS";
            }
            public string GetAllSettings()
            {
                return "setting1: " + setting1 + "\nsetting2: " + setting2 + "\nsetting3: " + setting3
                    + "\nsetting4: " + setting4 + "\nsetting5: " + setting5 + "\nsetting6: " + setting6
                    + "\nsetting7: " + setting7 + "\nsetting8: " + setting8 + "\nsetting9: " + setting9
                    + "\nsetting10: " + setting10;
            }
            public string GetSetting1()
            {
                return setting1;
            }
            public string GetSetting2()
            {
                return setting2;
            }
            public string GetSetting3()
            {
                return setting3;
            }
            public string GetSetting4()
            {
                return setting4;
            }
            public string GetSetting5()
            {
                return setting5;
            }
            public string GetSetting6()
            {
                return setting6;
            }
            public string GetSetting7()
            {
                return setting7;
            }
            public string GetSetting8()
            {
                return setting8;
            }
            public string GetSetting9()
            {
                return setting9;
            }
            public string GetSetting10()
            {
                return setting10;
            }
        }
        private class WindowsSettings : IAbstractSettings
        {
            private string setting1 = "1", setting2 = "2", setting3 = "3", setting4 = "4", setting5 = "5", setting6 = "6", setting7 = "7", setting8 = "8", setting9 = "9", setting10 = "10";
            public void SetSetting1(string setting1)
            {
                this.setting1 = setting1;
            }
            public void SetSetting2(string setting2)
            {
                this.setting2 = setting2;
            }
            public void SetSetting3(string setting3)
            {
                this.setting3 = setting3;
            }
            public void SetSetting4(string setting4)
            {
                this.setting4 = setting4;
            }
            public void SetSetting5(string setting5)
            {
                this.setting5 = setting5;
            }
            public void SetSetting6(string setting6)
            {
                this.setting6 = setting6;
            }
            public void SetSetting7(string setting7)
            {
                this.setting7 = setting7;
            }
            public void SetSetting8(string setting8)
            {
                this.setting8 = setting8;
            }
            public void SetSetting9(string setting9)
            {
                this.setting9 = setting9;
            }
            public void SetSetting10(string setting10)
            {
                this.setting10 = setting10;
            }
            public string GetOS()
            {
                return "Windows";
            }
            public string GetAllSettings()
            {
                return "setting1: " + setting1 + "\nsetting2: " + setting2 + "\nsetting3: " + setting3
                    + "\nsetting4: " + setting4 + "\nsetting5: " + setting5 + "\nsetting6: " + setting6
                    + "\nsetting7: " + setting7 + "\nsetting8: " + setting8 + "\nsetting9: " + setting9
                    + "\nsetting10: " + setting10;
            }

            public string GetSetting1()
            {
                return setting1;
            }
            public string GetSetting2()
            {
                return setting2;
            }
            public string GetSetting3()
            {
                return setting3;
            }
            public string GetSetting4()
            {
                return setting4;
            }
            public string GetSetting5()
            {
                return setting5;
            }
            public string GetSetting6()
            {
                return setting6;
            }
            public string GetSetting7()
            {
                return setting7;
            }
            public string GetSetting8()
            {
                return setting8;
            }
            public string GetSetting9()
            {
                return setting9;
            }
            public string GetSetting10()
            {
                return setting10;
            }
        }
        private class LinuxSettings : IAbstractSettings
        {
            private string setting1 = "1", setting2 = "2", setting3 = "3", setting4 = "4", setting5 = "5", setting6 = "6", setting7 = "7", setting8 = "8", setting9 = "9", setting10 = "10";
            public void SetSetting1(string setting1)
            {
                this.setting1 = setting1;
            }
            public void SetSetting2(string setting2)
            {
                this.setting2 = setting2;
            }
            public void SetSetting3(string setting3)
            {
                this.setting3 = setting3;
            }
            public void SetSetting4(string setting4)
            {
                this.setting4 = setting4;
            }
            public void SetSetting5(string setting5)
            {
                this.setting5 = setting5;
            }
            public void SetSetting6(string setting6)
            {
                this.setting6 = setting6;
            }
            public void SetSetting7(string setting7)
            {
                this.setting7 = setting7;
            }
            public void SetSetting8(string setting8)
            {
                this.setting8 = setting8;
            }
            public void SetSetting9(string setting9)
            {
                this.setting9 = setting9;
            }
            public void SetSetting10(string setting10)
            {
                this.setting10 = setting10;
            }
            public string GetOS()
            {
                return "Linux";
            }
            public string GetAllSettings()
            {
                return "setting1: " + setting1 + "\nsetting2: " + setting2 + "\nsetting3: " + setting3
                    + "\nsetting4: " + setting4 + "\nsetting5: " + setting5 + "\nsetting6: " + setting6
                    + "\nsetting7: " + setting7 + "\nsetting8: " + setting8 + "\nsetting9: " + setting9
                    + "\nsetting10: " + setting10;
            }
            public string GetSetting1()
            {
                return setting1;
            }
            public string GetSetting2()
            {
                return setting2;
            }
            public string GetSetting3()
            {
                return setting3;
            }
            public string GetSetting4()
            {
                return setting4;
            }
            public string GetSetting5()
            {
                return setting5;
            }
            public string GetSetting6()
            {
                return setting6;
            }
            public string GetSetting7()
            {
                return setting7;
            }
            public string GetSetting8()
            {
                return setting8;
            }
            public string GetSetting9()
            {
                return setting9;
            }
            public string GetSetting10()
            {
                return setting10;
            }
        }
        public class User
        {
            private const int NUM_OF_SETTINGS = 10;
            private MacOSApp MacOS = new MacOSApp();
            private WindowsApp Windows = new WindowsApp();
            private LinuxApp Linux = new LinuxApp();
            private string currentOS;
            public User(string nameOS)
            {
                currentOS = nameOS;
            }
            public void ChangeOS(string nameOS)
            {
                Console.WriteLine("ОС была сменена с " + currentOS + " на " + nameOS);
                currentOS = nameOS;
            }
            public string GetOS()
            {
                return currentOS;
            }
            public void GetSettings()
            {
                switch (currentOS)
                {
                    case "MacOS":
                        Get(MacOS);
                        break;
                    case "Windows":
                        Get(Windows);
                        break;
                    case "Linux":
                        Get(Linux);
                        break;
                }
            }
            private void Get(IAbstractApp app)
            {
                var settings = app.Settings();
                Console.WriteLine(settings.GetOS());
                Console.WriteLine(settings.GetAllSettings());
            }
            public void SetSetting(int numOfSetting, string setting)
            {
                switch (currentOS)
                {
                    case "MacOS":
                        Set(MacOS, numOfSetting, setting);
                        break;
                    case "Windows":
                        Set(Windows, numOfSetting, setting);
                        break;
                    case "Linux":
                        Set(Linux, numOfSetting, setting);
                        break;
                }
            }
            private void Set(IAbstractApp app, int numOfSetting, string setting)
            {
                var settings = app.Settings();
                switch (numOfSetting)
                {
                    case 1:
                        settings.SetSetting1(setting);
                        break;
                    case 2:
                        settings.SetSetting2(setting);
                        break;
                    case 3:
                        settings.SetSetting3(setting);
                        break;
                    case 4:
                        settings.SetSetting4(setting);
                        break;
                    case 5:
                        settings.SetSetting5(setting);
                        break;
                    case 6:
                        settings.SetSetting6(setting);
                        break;
                    case 7:
                        settings.SetSetting7(setting);
                        break;
                    case 8:
                        settings.SetSetting8(setting);
                        break;
                    case 9:
                        settings.SetSetting9(setting);
                        break;
                    case 10:
                        settings.SetSetting10(setting);
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            User user = new User("Windows");
            user.SetSetting(1, "w");
            user.SetSetting(2, "i");
            user.SetSetting(3, "n");
            user.SetSetting(4, "d");
            user.SetSetting(5, "o");
            user.SetSetting(6, "w");
            user.SetSetting(7, "s");
            user.GetSettings();
            Console.WriteLine();
            user.ChangeOS("Linux");
            Console.WriteLine();
            user.SetSetting(1, "l");
            user.SetSetting(2, "i");
            user.SetSetting(3, "n");
            user.SetSetting(4, "u");
            user.SetSetting(5, "x");
            user.GetSettings();
            Console.ReadKey();
        }
    }
}
