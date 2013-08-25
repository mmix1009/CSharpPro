using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnString
{
    class StringGuide
    {

        static void WhatAMI()
        {
            Console.WriteLine(@"The content comes from Strings (C# Programming Guide)");
            Console.WriteLine(@"The Website is http://msdn.microsoft.com/zh-cn/library/ms228362.aspx");
             
        }

        static void StrVsSystemStr()
        {
            Console.WriteLine("string is a alias of System.String");
        }
        static void DeclareAndInitStr()
        {
            string message1;
            string message2 = null;
            string message3 = System.String.Empty;
            string oldPath = "c:\\Program Files\\VS8.0";
            //ignore escape character,which is called  verbatim             string<逐字的>,每一个字母都不转义，\就是\
            string newPath = @"c:\Program Fils\VS8.0";
            //System.String is alias of string
            System.String greeting = "Hello World";
            //in local variable,(i.e in method body)
            var temp = "I am still a string liberal";
            //using string constructor only when creating
            //a string from a char* ,char[],or sbyte*
            char[] letters = {'A','B','C'};
            string alphabet = new string(letters);
             #region 输出上面定义的字符串，并给予合理解释
                #if DEBUG
                Console.WriteLine("DeclarAndInitString");
                Console.WriteLine(message2);
                Console.WriteLine(message3);
                Console.WriteLine(oldPath);
                Console.WriteLine(newPath);
                Console.WriteLine(greeting);
                Console.WriteLine(temp);
                Console.WriteLine(alphabet);
                Console.WriteLine(@"Note that you do not use the new operator to create a string object except when initializing the string with an array of chars.
Initialize a string with the Empty constant value to create a new String object whose string is of zero length. The string literal representation of a zero-length string is "". By initializing strings with the Empty value instead of null, you can reduce the chances of a NullReferenceException occurring. Use the static IsNullOrEmpty(String) method to verify the value of a string before you try to access it.");
                #endif
            #endregion

        }
        static void ImmutablityOfStringObjects()
        {
            string str1 = "A string is more than ";
            string str2 = "the sum of its chars";
            str1 += str2;
            Console.WriteLine(str1);
            #region 下面一段程序补充说明
            /*Because a string "modification" is actually a new string creation, you must use caution when you create references to strings. If you create a reference to a string, and then "modify" the original string, the reference will continue to point to the original object instead of the new object that was created when the string was modified. The following code illustrates this behavior:*/
            #endregion
            string s1 = "Hello ";
            string s2 = s1;
            s1 += "World";
            System.Console.WriteLine(s2);
            //Output: Hello

        }
        static void Main(string[] args)
        {

            WhatAMI();
            StrVsSystemStr();
            DeclareAndInitStr();
            ImmutablityOfStringObjects();
            RegularAndVerbatimString();
            Console.ReadKey();
        }
        static void RegularAndVerbatimString()
        {
            #region //regular例子
            //Use regular string literals when you must embed escape characters provided by C#,实际上就是我们以前学的可以使用转义字符的字符串
            #endregion
            string cols = "Column1\tColumn2\tColumn3";
            string rows = "Row1\r\nRow2\r\nRow3";
            Console.WriteLine(cols);
            Console.WriteLine(rows);
            #region//verbatim string
           /*Use verbatim strings for convenience and better readability when the string text contains backslash characters, for example in file paths. Because verbatim strings preserve new line characters as part of the string text, they can be used to initialize multiline strings. Use double quotation marks to embed a quotation mark inside a verbatim string. The following example shows some common uses for verbatim strings:*/ 

            #endregion
            string filePath = @"c:\Program Files\VS";
            string text = @"now I am Learning
c#";
            string quote = @"Her name  is ""zhou.""";
            Console.WriteLine(filePath);
            Console.WriteLine(text);
            Console.WriteLine(quote);
            #region NOTE
            /*At compile time, verbatim strings are converted to ordinary strings with all the same escape sequences. Therefore, if you view a verbatim string in the debugger watch window, you will see the escape characters that were added by the compiler, not the verbatim version from your source code. For example, the verbatim string @"C:\files.txt" will appear in the watch window as "C:\\files.txt".*/

            #endregion
        }
    }
}
