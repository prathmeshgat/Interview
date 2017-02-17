using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class MatrixOperations
    {
       

        public void DisplayMatrix(int[,] myMatrix)
        {
            for(int i=0;i< myMatrix.GetLength(0);i++)
            {
                Console.WriteLine("");
                for(int j=0;j<myMatrix.GetLength(1);j++)
                {
                    Console.Write(" "+ myMatrix[i,j]);
                }
            }
        }
    }
}
