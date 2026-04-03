using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.Reflections
{
    internal class GetClassInformation
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter class name: ");
            string inputClass = Console.ReadLine();

            Type type = Type.GetType(inputClass);

            if (type == null)
            {
                Console.WriteLine("Class not found!");
                return;
            }

            Console.WriteLine("\nConstructors =>");
            ConstructorInfo[] constructorsArr = type.GetConstructors();
            foreach (var constr in constructorsArr)
            {
                Console.WriteLine(constr);
            }

            Console.WriteLine("\nFields =>");
            FieldInfo[] fieldsArr = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (var field in fieldsArr)
            {
                Console.WriteLine(field);
            }

            Console.WriteLine("\nMethods =>");
            MethodInfo[] methodsArr = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (var method in methodsArr)
            {
                Console.WriteLine(method);
            }
        }
    }
}
