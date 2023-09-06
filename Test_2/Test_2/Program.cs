using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var i = 5;


            Console.WriteLine(i);
            Console.ReadLine();
        }
        /// <summary>
        /// Класс, который представляет пользователя.
        /// </summary>
        public class User
        {
            private string name;

            /// <summary>
            /// Конструктор класса.
            /// </summary>
            /// <param name="name">Имя пользователя.</param>
            public User(string name)
            {
                this.name = name;
            }

            /// <summary>
            /// Меняет имя пользователя.
            /// </summary>
            /// <param name="name">Имя пользователя.</param>
            public void ChangeName(string name)
            {
                this.name = name;
            }

            /// <summary>
            /// Метод для вывода имени пользователя.
            /// </summary>
            /// <returns>Возвращает имя пользователя.</returns>
            public string GetName()
            {
                return this.name;
            }

        }
    }
}
