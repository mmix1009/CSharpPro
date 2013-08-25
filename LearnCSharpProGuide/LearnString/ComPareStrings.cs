using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnString
{
    class ComPareStrings
    {
        public static void Demo()
        {
            #region Note
            //When you compare strings, you should use the methods that explicitly specify what kind of comparison you intend to perform. This makes your code much more maintainable and readable. Whenever possible, use the overloads of the methods of the System.String and System.Array classes that take a StringComparison enumeration parameter, so that you can specify which type of comparison to perform. It is best to avoid using the == and != operators when you compare strings. Also, avoid using the String.CompareTo instance methods because none of the overloads takes a StringComparison.
            #endregion
            string root = @"C:\users";
            string root2 = @"C:\Users";
            bool result = root.Equals(root2, StringComparison.Ordinal);
            Console.WriteLine("{0} and {1} is {2}", root, root2, result ? "equal" : "not equal");
            
             result = root.Equals(root2, StringComparison.OrdinalIgnoreCase);
             Console.WriteLine("{0} and {1} is {2}", root, root2, result ? "equal" : "not equal");
            //静态方法可以实现相同的效果
             bool areEqual = String.Equals(root, root2, StringComparison.Ordinal);
             string a = "My name is zhou";
             string b = "My name is zhou";
             if (String.ReferenceEquals(a, b))
             {
                 Console.WriteLine("两个字符串引用同一个实例");
             }
             else
             {
                 Console.WriteLine("两个字符串不引用同一个实例");
             }

             string c = String.Copy(b);
             if (String.ReferenceEquals(c, b)) 
             {
                 Console.WriteLine("两个字符串引用同一个实例");
             }
             else
             {
                 Console.WriteLine("两个字符串不引用同一个实例");
             }
             if (c.Equals(b, StringComparison.Ordinal))
                 Console.WriteLine("两个字符串相等");
             
        }
    }
}
