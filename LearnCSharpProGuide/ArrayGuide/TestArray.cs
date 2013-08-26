using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#region What is a Array
//An array is a data structure that contains several variables of the same type
#endregion
namespace ArrayGuide
{
    class TestArray
    {
        static void Start()
        {
            #region What the class do
            //The following examples create single-dimensional, multidimensional, and jagged arrays 
            #endregion
            //Declare a single-dimensional array
            int[] array1 = new int[5];
            //Declare and set array element values;
            int[] array2 = new int[] { 1, 2, 3, 4, 5 };
            // Alternative syntax
            int[] array3 = { 1, 2, 3, 4, 5, 6 };
            // Declare a two dimensional array
            int[,] array4 = new int[2, 3];
            // Declare and set array element values
            int[,] array5={{1,2,3},{13,34,45}};
            // Declare a jagged array
            //int[][] jaggedArray = new int[][];
            // Set the values of the first array in the jagged array structure
            //jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
        }
    }
}
