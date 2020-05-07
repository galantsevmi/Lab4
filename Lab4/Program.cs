using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    /// <summary>
    /// Класс для реализации поставленной задачи
    /// </summary>
    class Program
    {
        /// <summary>
        /// Общий интерфейс приложения
        /// </summary>
        private interface IAbstractApp
        {
            /// <summary>
            /// Функция для входа в меню настроек
            /// </summary>
            /// <returns>Меню настроек</returns>
            IAbstractSettings Settings();
        }
        /// <summary>
        /// Класс приложения на MacOS
        /// </summary>
        private class MacOSApp : IAbstractApp
        {
            /// <summary>
            /// Меню настроек для MacOS
            /// </summary>
            private MacOSSettings MacOS = new MacOSSettings();
            /// <summary>
            /// Функция для входа в меню настроек для MacOS
            /// </summary>
            /// <returns>Меню настроек для MacOS</returns>
            public IAbstractSettings Settings()
            {
                return MacOS;
            }
        }
        /// <summary>
        /// Класс приложения на Windows
        /// </summary>
        private class WindowsApp : IAbstractApp
        {
            /// <summary>
            /// Меню настроек для Windows
            /// </summary>
            private WindowsSettings Windows = new WindowsSettings();
            /// <summary>
            /// Функция для входа в меню настроек для Windows
            /// </summary>
            /// <returns>Меню настроек для Windows</returns>
            public IAbstractSettings Settings()
            {
                return Windows;
            }
        }
        /// <summary>
        /// Класс приложения на Linux
        /// </summary>
        private class LinuxApp : IAbstractApp
        {
            /// <summary>
            /// Меню настроек для Linux
            /// </summary>
            private LinuxSettings Linux = new LinuxSettings();
            /// <summary>
            /// Функция для входа в меню настроек для Linux
            /// </summary>
            /// <returns>Меню настроек для Linux</returns>
            public IAbstractSettings Settings()
            {
                return Linux;
            }
        }
        /// <summary>
        /// Общий интерфейс настроек
        /// </summary>
        private interface IAbstractSettings
        {
            /// <summary>
            /// Процедура для установки значения настройки 1
            /// </summary>
            /// <param name="setting1">Новое значение настройки 1</param>
            void SetSetting1(string setting1);
            /// <summary>
            /// Процедура для установки значения настройки 2
            /// </summary>
            /// <param name="setting2">Новое значение настройки 2</param>
            void SetSetting2(string setting2);
            /// <summary>
            /// Процедура для установки значения настройки 3
            /// </summary>
            /// <param name="setting3">Новое значение настройки 3</param>
            void SetSetting3(string setting3);
            /// <summary>
            /// Процедура для установки значения настройки 4
            /// </summary>
            /// <param name="setting4">Новое значение настройки 4</param>
            void SetSetting4(string setting4);
            /// <summary>
            /// Процедура для установки значения настройки 5
            /// </summary>
            /// <param name="setting5">Новое значение настройки 5</param>
            void SetSetting5(string setting5);
            /// <summary>
            /// Процедура для установки значения настройки 6
            /// </summary>
            /// <param name="setting6">Новое значение настройки 6</param>
            void SetSetting6(string setting6);
            /// <summary>
            /// Процедура для установки значения настройки 7
            /// </summary>
            /// <param name="setting7">Новое значение настройки 7</param>
            void SetSetting7(string setting7);
            /// <summary>
            /// Процедура для установки значения настройки 8
            /// </summary>
            /// <param name="setting8">Новое значение настройки 8</param>
            void SetSetting8(string setting8);
            /// <summary>
            /// Процедура для установки значения настройки 9
            /// </summary>
            /// <param name="setting9">Новое значение настройки 9</param>
            void SetSetting9(string setting9);
            /// <summary>
            /// Процедура для установки значения настройки 10
            /// </summary>
            /// <param name="setting10">Новое значение настройки 10</param>
            void SetSetting10(string setting10);
            /// <summary>
            /// Функция для получения названия ОС
            /// </summary>
            /// <returns>Название ОС</returns>
            string GetOS();
            /// <summary>
            /// Функция для получения всех настроек сразу
            /// </summary>
            /// <returns>Строка, содержащая все настройки</returns>
            string GetAllSettings();
            /// <summary>
            /// Функция для получения значения настройки 1
            /// </summary>
            /// <returns>Значение настройки 1</returns>
            string GetSetting1();
            /// <summary>
            /// Функция для получения значения настройки 2
            /// </summary>
            /// <returns>Значение настройки 2</returns>
            string GetSetting2();
            /// <summary>
            /// Функция для получения значения настройки 3
            /// </summary>
            /// <returns>Значение настройки 3</returns>
            string GetSetting3();
            /// <summary>
            /// Функция для получения значения настройки 4
            /// </summary>
            /// <returns>Значение настройки 4</returns>
            string GetSetting4();
            /// <summary>
            /// Функция для получения значения настройки 5
            /// </summary>
            /// <returns>Значение настройки 5</returns>
            string GetSetting5();
            /// <summary>
            /// Функция для получения значения настройки 6
            /// </summary>
            /// <returns>Значение настройки 6</returns>
            string GetSetting6();
            /// <summary>
            /// Функция для получения значения настройки 7
            /// </summary>
            /// <returns>Значение настройки 7</returns>
            string GetSetting7();
            /// <summary>
            /// Функция для получения значения настройки 8
            /// </summary>
            /// <returns>Значение настройки 8</returns>
            string GetSetting8();
            /// <summary>
            /// Функция для получения значения настройки 9
            /// </summary>
            /// <returns>Значение настройки 9</returns>
            string GetSetting9();
            /// <summary>
            /// Функция для получения значения настройки 10
            /// </summary>
            /// <returns>Значение настройки 10</returns>
            string GetSetting10();
        }
        /// <summary>
        /// Класс настроек для MacOS
        /// </summary>
        private class MacOSSettings : IAbstractSettings
        {
            /// <summary>
            /// Настройки со значениями по умолчанию
            /// </summary>
            private string setting1 = "1", setting2 = "2", setting3 = "3", setting4 = "4", setting5 = "5", setting6 = "6", setting7 = "7", setting8 = "8", setting9 = "9", setting10 = "10";
            /// <summary>
            /// Процедура для установки значения настройки 1
            /// </summary>
            /// <param name="setting1">Новое значение настройки 1</param>
            public void SetSetting1(string setting1)
            {
                this.setting1 = setting1;
            }
            /// <summary>
            /// Процедура для установки значения настройки 2
            /// </summary>
            /// <param name="setting2">Новое значение настройки 2</param>
            public void SetSetting2(string setting2)
            {
                this.setting2 = setting2;
            }
            /// <summary>
            /// Процедура для установки значения настройки 3
            /// </summary>
            /// <param name="setting3">Новое значение настройки 3</param>
            public void SetSetting3(string setting3)
            {
                this.setting3 = setting3;
            }
            /// <summary>
            /// Процедура для установки значения настройки 4
            /// </summary>
            /// <param name="setting4">Новое значение настройки 4</param>
            public void SetSetting4(string setting4)
            {
                this.setting4 = setting4;
            }
            /// <summary>
            /// Процедура для установки значения настройки 5
            /// </summary>
            /// <param name="setting5">Новое значение настройки 5</param>
            public void SetSetting5(string setting5)
            {
                this.setting5 = setting5;
            }
            /// <summary>
            /// Процедура для установки значения настройки 6
            /// </summary>
            /// <param name="setting6">Новое значение настройки 6</param>
            public void SetSetting6(string setting6)
            {
                this.setting6 = setting6;
            }
            /// <summary>
            /// Процедура для установки значения настройки 7
            /// </summary>
            /// <param name="setting7">Новое значение настройки 7</param>
            public void SetSetting7(string setting7)
            {
                this.setting7 = setting7;
            }
            /// <summary>
            /// Процедура для установки значения настройки 8
            /// </summary>
            /// <param name="setting8">Новое значение настройки 8</param>
            public void SetSetting8(string setting8)
            {
                this.setting8 = setting8;
            }
            /// <summary>
            /// Процедура для установки значения настройки 9
            /// </summary>
            /// <param name="setting9">Новое значение настройки 9</param>
            public void SetSetting9(string setting9)
            {
                this.setting9 = setting9;
            }
            /// <summary>
            /// Процедура для установки значения настройки 10
            /// </summary>
            /// <param name="setting10">Новое значение настройки 10</param>
            public void SetSetting10(string setting10)
            {
                this.setting10 = setting10;
            }
            /// <summary>
            /// Функция для получения названия ОС
            /// </summary>
            /// <returns>Название ОС</returns>
            public string GetOS()
            {
                return "MacOS";
            }
            /// <summary>
            /// Функция для получения всех настроек сразу
            /// </summary>
            /// <returns>Строка, содержащая все настройки</returns>
            public string GetAllSettings()
            {
                return "setting1: " + setting1 + "\nsetting2: " + setting2 + "\nsetting3: " + setting3
                    + "\nsetting4: " + setting4 + "\nsetting5: " + setting5 + "\nsetting6: " + setting6
                    + "\nsetting7: " + setting7 + "\nsetting8: " + setting8 + "\nsetting9: " + setting9
                    + "\nsetting10: " + setting10;
            }
            /// <summary>
            /// Функция для получения значения настройки 1
            /// </summary>
            /// <returns>Значение настройки 1</returns>
            public string GetSetting1()
            {
                return setting1;
            }
            /// <summary>
            /// Функция для получения значения настройки 2
            /// </summary>
            /// <returns>Значение настройки 2</returns>
            public string GetSetting2()
            {
                return setting2;
            }
            /// <summary>
            /// Функция для получения значения настройки 3
            /// </summary>
            /// <returns>Значение настройки 3</returns>
            public string GetSetting3()
            {
                return setting3;
            }
            /// <summary>
            /// Функция для получения значения настройки 4
            /// </summary>
            /// <returns>Значение настройки 4</returns>
            public string GetSetting4()
            {
                return setting4;
            }
            /// <summary>
            /// Функция для получения значения настройки 5
            /// </summary>
            /// <returns>Значение настройки 5</returns>
            public string GetSetting5()
            {
                return setting5;
            }
            /// <summary>
            /// Функция для получения значения настройки 6
            /// </summary>
            /// <returns>Значение настройки 6</returns>
            public string GetSetting6()
            {
                return setting6;
            }
            /// <summary>
            /// Функция для получения значения настройки 7
            /// </summary>
            /// <returns>Значение настройки 7</returns>
            public string GetSetting7()
            {
                return setting7;
            }
            /// <summary>
            /// Функция для получения значения настройки 8
            /// </summary>
            /// <returns>Значение настройки 8</returns>
            public string GetSetting8()
            {
                return setting8;
            }
            /// <summary>
            /// Функция для получения значения настройки 9
            /// </summary>
            /// <returns>Значение настройки 9</returns>
            public string GetSetting9()
            {
                return setting9;
            }
            /// <summary>
            /// Функция для получения значения настройки 10
            /// </summary>
            /// <returns>Значение настройки 10</returns>
            public string GetSetting10()
            {
                return setting10;
            }
        }
        /// <summary>
        /// Класс настроек для Windows
        /// </summary>
        private class WindowsSettings : IAbstractSettings
        {
            /// <summary>
            /// Настройки со значениями по умолчанию
            /// </summary>
            private string setting1 = "1", setting2 = "2", setting3 = "3", setting4 = "4", setting5 = "5", setting6 = "6", setting7 = "7", setting8 = "8", setting9 = "9", setting10 = "10";
            /// <summary>
            /// Процедура для установки значения настройки 1
            /// </summary>
            /// <param name="setting1">Новое значение настройки 1</param>
            public void SetSetting1(string setting1)
            {
                this.setting1 = setting1;
            }
            /// <summary>
            /// Процедура для установки значения настройки 2
            /// </summary>
            /// <param name="setting2">Новое значение настройки 2</param>
            public void SetSetting2(string setting2)
            {
                this.setting2 = setting2;
            }
            /// <summary>
            /// Процедура для установки значения настройки 3
            /// </summary>
            /// <param name="setting3">Новое значение настройки 3</param>
            public void SetSetting3(string setting3)
            {
                this.setting3 = setting3;
            }
            /// <summary>
            /// Процедура для установки значения настройки 4
            /// </summary>
            /// <param name="setting4">Новое значение настройки 4</param>
            public void SetSetting4(string setting4)
            {
                this.setting4 = setting4;
            }
            /// <summary>
            /// Процедура для установки значения настройки 5
            /// </summary>
            /// <param name="setting5">Новое значение настройки 5</param>
            public void SetSetting5(string setting5)
            {
                this.setting5 = setting5;
            }
            /// <summary>
            /// Процедура для установки значения настройки 6
            /// </summary>
            /// <param name="setting6">Новое значение настройки 6</param>
            public void SetSetting6(string setting6)
            {
                this.setting6 = setting6;
            }
            /// <summary>
            /// Процедура для установки значения настройки 7
            /// </summary>
            /// <param name="setting7">Новое значение настройки 7</param>
            public void SetSetting7(string setting7)
            {
                this.setting7 = setting7;
            }
            /// <summary>
            /// Процедура для установки значения настройки 8
            /// </summary>
            /// <param name="setting8">Новое значение настройки 8</param>
            public void SetSetting8(string setting8)
            {
                this.setting8 = setting8;
            }
            /// <summary>
            /// Процедура для установки значения настройки 9
            /// </summary>
            /// <param name="setting9">Новое значение настройки 9</param>
            public void SetSetting9(string setting9)
            {
                this.setting9 = setting9;
            }
            /// <summary>
            /// Процедура для установки значения настройки 10
            /// </summary>
            /// <param name="setting10">Новое значение настройки 10</param>
            public void SetSetting10(string setting10)
            {
                this.setting10 = setting10;
            }
            /// <summary>
            /// Функция для получения названия ОС
            /// </summary>
            /// <returns>Название ОС</returns>
            public string GetOS()
            {
                return "Windows";
            }
            /// <summary>
            /// Функция для получения всех настроек сразу
            /// </summary>
            /// <returns>Строка, содержащая все настройки</returns>
            public string GetAllSettings()
            {
                return "setting1: " + setting1 + "\nsetting2: " + setting2 + "\nsetting3: " + setting3
                    + "\nsetting4: " + setting4 + "\nsetting5: " + setting5 + "\nsetting6: " + setting6
                    + "\nsetting7: " + setting7 + "\nsetting8: " + setting8 + "\nsetting9: " + setting9
                    + "\nsetting10: " + setting10;
            }
            /// <summary>
            /// Функция для получения значения настройки 1
            /// </summary>
            /// <returns>Значение настройки 1</returns>
            public string GetSetting1()
            {
                return setting1;
            }
            /// <summary>
            /// Функция для получения значения настройки 2
            /// </summary>
            /// <returns>Значение настройки 2</returns>
            public string GetSetting2()
            {
                return setting2;
            }
            /// <summary>
            /// Функция для получения значения настройки 3
            /// </summary>
            /// <returns>Значение настройки 3</returns>
            public string GetSetting3()
            {
                return setting3;
            }
            /// <summary>
            /// Функция для получения значения настройки 4
            /// </summary>
            /// <returns>Значение настройки 4</returns>
            public string GetSetting4()
            {
                return setting4;
            }
            /// <summary>
            /// Функция для получения значения настройки 5
            /// </summary>
            /// <returns>Значение настройки 5</returns>
            public string GetSetting5()
            {
                return setting5;
            }
            /// <summary>
            /// Функция для получения значения настройки 6
            /// </summary>
            /// <returns>Значение настройки 6</returns>
            public string GetSetting6()
            {
                return setting6;
            }
            /// <summary>
            /// Функция для получения значения настройки 7
            /// </summary>
            /// <returns>Значение настройки 7</returns>
            public string GetSetting7()
            {
                return setting7;
            }
            /// <summary>
            /// Функция для получения значения настройки 8
            /// </summary>
            /// <returns>Значение настройки 8</returns>
            public string GetSetting8()
            {
                return setting8;
            }
            /// <summary>
            /// Функция для получения значения настройки 9
            /// </summary>
            /// <returns>Значение настройки 9</returns>
            public string GetSetting9()
            {
                return setting9;
            }
            /// <summary>
            /// Функция для получения значения настройки 10
            /// </summary>
            /// <returns>Значение настройки 10</returns>
            public string GetSetting10()
            {
                return setting10;
            }
        }
        /// <summary>
        /// Класс настроек для Linux
        /// </summary>
        private class LinuxSettings : IAbstractSettings
        {
            /// <summary>
            /// Настройки со значениями по умолчанию
            /// </summary>
            private string setting1 = "1", setting2 = "2", setting3 = "3", setting4 = "4", setting5 = "5", setting6 = "6", setting7 = "7", setting8 = "8", setting9 = "9", setting10 = "10";
            /// <summary>
            /// Процедура для установки значения настройки 1
            /// </summary>
            /// <param name="setting1">Новое значение настройки 1</param>
            public void SetSetting1(string setting1)
            {
                this.setting1 = setting1;
            }
            /// <summary>
            /// Процедура для установки значения настройки 2
            /// </summary>
            /// <param name="setting2">Новое значение настройки 2</param>
            public void SetSetting2(string setting2)
            {
                this.setting2 = setting2;
            }
            /// <summary>
            /// Процедура для установки значения настройки 3
            /// </summary>
            /// <param name="setting3">Новое значение настройки 3</param>
            public void SetSetting3(string setting3)
            {
                this.setting3 = setting3;
            }
            /// <summary>
            /// Процедура для установки значения настройки 4
            /// </summary>
            /// <param name="setting4">Новое значение настройки 4</param>
            public void SetSetting4(string setting4)
            {
                this.setting4 = setting4;
            }
            /// <summary>
            /// Процедура для установки значения настройки 5
            /// </summary>
            /// <param name="setting5">Новое значение настройки 5</param>
            public void SetSetting5(string setting5)
            {
                this.setting5 = setting5;
            }
            /// <summary>
            /// Процедура для установки значения настройки 6
            /// </summary>
            /// <param name="setting6">Новое значение настройки 6</param>
            public void SetSetting6(string setting6)
            {
                this.setting6 = setting6;
            }
            /// <summary>
            /// Процедура для установки значения настройки 7
            /// </summary>
            /// <param name="setting7">Новое значение настройки 7</param>
            public void SetSetting7(string setting7)
            {
                this.setting7 = setting7;
            }
            /// <summary>
            /// Процедура для установки значения настройки 8
            /// </summary>
            /// <param name="setting8">Новое значение настройки 8</param>
            public void SetSetting8(string setting8)
            {
                this.setting8 = setting8;
            }
            /// <summary>
            /// Процедура для установки значения настройки 9
            /// </summary>
            /// <param name="setting9">Новое значение настройки 9</param>
            public void SetSetting9(string setting9)
            {
                this.setting9 = setting9;
            }
            /// <summary>
            /// Процедура для установки значения настройки 10
            /// </summary>
            /// <param name="setting10">Новое значение настройки 10</param>
            public void SetSetting10(string setting10)
            {
                this.setting10 = setting10;
            }
            /// <summary>
            /// Функция для получения названия ОС
            /// </summary>
            /// <returns>Название ОС</returns>
            public string GetOS()
            {
                return "Linux";
            }
            /// <summary>
            /// Функция для получения всех настроек сразу
            /// </summary>
            /// <returns>Строка, содержащая все настройки</returns>
            public string GetAllSettings()
            {
                return "setting1: " + setting1 + "\nsetting2: " + setting2 + "\nsetting3: " + setting3
                    + "\nsetting4: " + setting4 + "\nsetting5: " + setting5 + "\nsetting6: " + setting6
                    + "\nsetting7: " + setting7 + "\nsetting8: " + setting8 + "\nsetting9: " + setting9
                    + "\nsetting10: " + setting10;
            }
            /// <summary>
            /// Функция для получения значения настройки 1
            /// </summary>
            /// <returns>Значение настройки 1</returns>
            public string GetSetting1()
            {
                return setting1;
            }
            /// <summary>
            /// Функция для получения значения настройки 2
            /// </summary>
            /// <returns>Значение настройки 2</returns>
            public string GetSetting2()
            {
                return setting2;
            }
            /// <summary>
            /// Функция для получения значения настройки 3
            /// </summary>
            /// <returns>Значение настройки 3</returns>
            public string GetSetting3()
            {
                return setting3;
            }
            /// <summary>
            /// Функция для получения значения настройки 4
            /// </summary>
            /// <returns>Значение настройки 4</returns>
            public string GetSetting4()
            {
                return setting4;
            }
            /// <summary>
            /// Функция для получения значения настройки 5
            /// </summary>
            /// <returns>Значение настройки 5</returns>
            public string GetSetting5()
            {
                return setting5;
            }
            /// <summary>
            /// Функция для получения значения настройки 6
            /// </summary>
            /// <returns>Значение настройки 6</returns>
            public string GetSetting6()
            {
                return setting6;
            }
            /// <summary>
            /// Функция для получения значения настройки 7
            /// </summary>
            /// <returns>Значение настройки 7</returns>
            public string GetSetting7()
            {
                return setting7;
            }
            /// <summary>
            /// Функция для получения значения настройки 8
            /// </summary>
            /// <returns>Значение настройки 8</returns>
            public string GetSetting8()
            {
                return setting8;
            }
            /// <summary>
            /// Функция для получения значения настройки 9
            /// </summary>
            /// <returns>Значение настройки 9</returns>
            public string GetSetting9()
            {
                return setting9;
            }
            /// <summary>
            /// Функция для получения значения настройки 10
            /// </summary>
            /// <returns>Значение настройки 10</returns>
            public string GetSetting10()
            {
                return setting10;
            }
        }
        /// <summary>
        /// Класс для работы с настройками для каждого отдельного пользователя
        /// </summary>
        public class User
        {
            /// <summary>
            /// Количество настроек
            /// </summary>
            private const int NUM_OF_SETTINGS = 10;
            /// <summary>
            /// Экземпляры приложений на разных ОС
            /// </summary>
            private MacOSApp MacOS = new MacOSApp();
            private WindowsApp Windows = new WindowsApp();
            private LinuxApp Linux = new LinuxApp();
            /// <summary>
            /// Текущая ОС
            /// </summary>
            private string currentOS;
            /// <summary>
            /// Конструктор для создания пользователя
            /// </summary>
            /// <param name="nameOS">Название операционной системы</param>
            /// <exception cref="ArgumentException">Неверно указана ОС</exception>
            public User(string nameOS)
            {
                if (nameOS == "MacOS" || nameOS == "Windows" || nameOS == "Linux")
                {
                    currentOS = nameOS;
                }
                else
                {
                    throw new ArgumentException("Неверно указана OS");
                }
            }
            /// <summary>
            /// Процедура, позволяющая сменить ОС с сохранением настроек для других
            /// </summary>
            /// <param name="nameOS">Название операционной системы</param>
            /// <exception cref="ArgumentException">Неверно указана ОС</exception>
            public void ChangeOS(string nameOS)
            {
                if (nameOS == "MacOS" || nameOS == "Windows" || nameOS == "Linux")
                {
                    Console.WriteLine("ОС была сменена с " + currentOS + " на " + nameOS);
                    currentOS = nameOS;
                }
                else
                {
                    throw new ArgumentException("Неверно указана OS");
                }
            }
            /// <summary>
            /// Функция, позволяющая получить название текущей ОС
            /// </summary>
            /// <returns>Название текущей ОС</returns>
            public string GetOS()
            {
                return currentOS;
            }
            /// <summary>
            /// Процедура, которая передаёт приложение для текущей ОС в другую функцию, которая выведет все настройки для неё
            /// </summary>
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
            /// <summary>
            /// Процедура, которая выводит все настройки для данной ОС
            /// </summary>
            /// <param name="app">Приложение для текущей ОС</param>
            private void Get(IAbstractApp app)
            {
                var settings = app.Settings();
                Console.WriteLine(settings.GetOS());
                Console.WriteLine(settings.GetAllSettings());
            }
            /// <summary>
            /// Процедура, которая передаёт приложения для текущей ОС в другую функцию, которая изменит значение нужной настройки
            /// </summary>
            /// <param name="numOfSetting">Номер настройки</param>
            /// <param name="setting">Новое значение настройки</param>
            /// <exception cref="ArgumentException">Несуществующий номер настройки</exception>
            public void SetSetting(int numOfSetting, string setting)
            {
                if (numOfSetting > NUM_OF_SETTINGS)
                {
                    throw new ArgumentException("Несуществующий номер настройки");
                }
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
            /// <summary>
            /// Процедура, которая изменяет значение нужной настройки
            /// </summary>
            /// <param name="app">Приложение для текущей ОС</param>
            /// <param name="numOfSetting">Номер настройки</param>
            /// <param name="setting">Новое значение настройки</param>
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
        ///<summary>
        ///Точка входа в программу
        ///</summary>
        ///<param name="args">Список аргументов командной строки</param>
        static void Main(string[] args)
        {
            try
            {
                // Создаём пользователя user с ОС Windows
                User user = new User("Windows");
                // Задаём значения некоторых настроек для Windows
                user.SetSetting(1, "w");
                user.SetSetting(2, "i");
                user.SetSetting(3, "n");
                user.SetSetting(4, "d");
                user.SetSetting(5, "o");
                user.SetSetting(6, "w");
                user.SetSetting(7, "s");
                // Получаем значения настроек для Windows
                user.GetSettings();
                Console.WriteLine();
                // Меняем ОС на Linux
                user.ChangeOS("Linux");
                Console.WriteLine();
                // Задаём значения некоторых настроек для Linux
                user.SetSetting(1, "l");
                user.SetSetting(2, "i");
                user.SetSetting(3, "n");
                user.SetSetting(4, "u");
                user.SetSetting(5, "x");
                // Получаем значения настроек для Linux
                user.GetSettings();
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }
    }
}
