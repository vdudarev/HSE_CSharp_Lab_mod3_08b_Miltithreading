using System;
using System.Linq;
using System.Reflection;

namespace Task04_AssemblyInspector
{
    internal class Program
    {
        /// <summary>
        /// Печатает в консоль информацию обо всех типах в сборке.
        /// </summary>
        /// <param name="assembly">Сборка, информацию о типах которой необходимо вывести.</param>
        /// <exception cref="NotImplementedException"></exception>
        private static void ListTypes(Assembly assembly)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Печатает в консоль информацию обо всех непубличных методах типа.
        /// </summary>
        /// <param name="type">Тип, для которого необходимо вывести информацию о методах.</param>
        /// <exception cref="NotImplementedException"></exception>
        private static void ListNonPublicMethods(Type type)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Печатает в консоль информацию обо всех непубличных полях типа.
        /// </summary>
        /// <param name="type">Тип, для которого необходимо вывести информацию о полях.</param>
        /// <exception cref="NotImplementedException"></exception>
        private static void ListNonPublicFields(Type type)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Находит пары базовый класс – наследник и выводит их в консоль.
        /// </summary>
        /// <param name="types">Массив всех типов в сборке.</param>
        /// <exception cref="NotImplementedException"></exception>
        private static void FindAndPrintParentAndChildrenClasses(Type[] types)
        {
            throw new NotImplementedException();
        }

        private static void Main(string[] args)
        {
            var cyphersAssembly = Assembly.LoadFrom("../../../../Cyphers/bin/Release/net5.0/Cyphers.dll");

            ListTypes(cyphersAssembly);

            var types = cyphersAssembly.GetTypes();
            
            FindAndPrintParentAndChildrenClasses(types);

            foreach (var type in types)
            {
                Console.WriteLine(string.Join("", Enumerable.Repeat('-', 50)));
                Console.WriteLine(type.Name);
                Console.WriteLine(Environment.NewLine + "Methods:");
                ListNonPublicMethods(type);
                Console.WriteLine(Environment.NewLine + "Fields:");
                ListNonPublicFields(type);
            }
            
            // Реализация задания 5* остается на усмотрение студента.
        }
    }
}