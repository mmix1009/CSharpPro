using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; 
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

            /*WhatAMI();
            StrVsSystemStr();
            DeclareAndInitStr();
            ImmutablityOfStringObjects();
            RegularAndVerbatimString();
            FormatString();
            Substrings();
            AccessIndividualCharacters();
            NullStringsAndEmptyStrings();
            UseStringBuilder();
            StringExtensionMethod();*/
            ReplaceSubStrings app = new ReplaceSubStrings();
            string s = "The mountains are behind the clouds today";
            s = s.Replace("mountains","peaks");
            Console.WriteLine(s);
            //s = Regex.Replace(s, app.searchFor, app.ReplaceMatchCase, RegexOptions.IgnoreCase);
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
        static void FormatString()
        {
            #region NOTE
            //A format string is a string whose contents can be determined dynamically at runtime. You create a format string by using the static Format method and embedding placeholders in braces that will be replaced by other values at runtime. The following example uses a format string to output the result of each iteration of a loop:
            //其中placeholders 表示{0} {1} {2}
            //format string 并不是一种字符串类型而是表示用format这种方法运行时生成的字符串
            #endregion
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int j;
            int.TryParse(input,out j);
            string s =String.Empty;
            for (int i = 0; i < 10; i++)
            {
                s = String.Format("{0} times {1} = {2}", i, j,                 (i * j));
                Console.WriteLine(s);
            }
 
        }
        static void Substrings()
        {
            #region NOTE
            /*A substring is any sequence of characters that is            contained in a string. Use the Substring method to create a new string from a part of the original string. You can search for one or more occurrences of a substring by using the IndexOf method. Use the Replace method to replace all occurrences of a specified substring with a new string. Like the Substring method, Replace actually returns a new string and does not modify the original string. For more information, see How to: Search Strings Using String Methods (C# Programming Guide) and How to: Modify String Contents (C# Programming Guide).*/
            /*IndexOf :Reports the zero-based index of the first occurrence of a specified Unicode character or string within this instance. The method returns -1 if the character or string is not found in this instance.*/
            #endregion
            string s3= "Visual c# Express";
            System.Console.WriteLine(s3.Substring(7, 2));
            //Substring(int index) or Substring(int index,int length)就两种重载方法.
            System.Console.WriteLine(s3.Replace("C#", "Basic"));
            //Replace也只有两种方法，Replace(char oldName,char newName);Replace(string oldSubstr,string newSubstr);
            int i = s3.IndexOf('#');
            Console.WriteLine("the char # is index  {0}",i);

        }
        static void AccessIndividualCharacters()
        {
            #region NOTE
            /*
                You can use array notation with an index value to acquire read-only access to individual characters, 
             */
            #endregion
            string s5 = "Printing backwards";
            for (int i = s5.Length - 1; i >= 0; i--)
            {
                 Console.Write(s5[i]);
            }
            Console.WriteLine();

        }

        static void NullStringsAndEmptyStrings()
        {
            #region NOTE
           /* An empty string is an instance of a System.String object that contains zero characters. Empty strings are used often in various programming scenarios to represent a blank text field. You can call methods on empty strings because they are valid System.String objects  */
            /*
             By contrast, a null string does not refer to an instance of a System.String object and any attempt to call a method on a null string causes a NullReferenceException. However, you can use null strings in concatenation and comparison operations with other strings. The following examples illustrate some cases in which a reference to a null string does and does not cause an exception to be thrown:
             */
            #endregion
            string str = "Hello World";
            string nullStr = null;
            string emptyStr = String.Empty;
            //可以做串接操作
            Console.WriteLine(str + nullStr);
            //可以做比较操作
            bool b = (nullStr == str);
            Console.WriteLine(b);
            //但对于nullstr,出除了这两种操作外不能有其他任何操作
            //Console.WriteLine(nullStr.Length);
            Console.WriteLine(emptyStr.Length);


        }

        static void UseStringBuilder()
        { 
             /*Unlike the String class, the StringBuilder class is mutable and provides better            performance when concatenating or deleting strings. */
            //stringBuilder不是string的继承，虽然它实现的一种字符串的功能
           System.Text.StringBuilder sb = new System.Text.StringBuilder();

            //Create a string composed of numbers 0 - 9
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i.ToString());
            }
            System.Console.WriteLine(sb);  // displays 0123456789

            // Copy one character of the string (not possible with a System.String)
            sb[0] = sb[9];

            System.Console.WriteLine(sb);  // displays 9123456789
        
        }

        static void StringExtensionMethod()
        {
             Console.WriteLine("string implements IEnumerable<T>,智能感知没有显示出来，但是可以使用");
        
        }
    }
}
