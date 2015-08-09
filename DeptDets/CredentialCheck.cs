using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeptDets
{
    class CredentialCheck
    {
        string strCredentialCheck;

        List<string> listA = new List<string>();
        List<string> listB = new List<string>();           

        public CredentialCheck(string strCC)
        {
            strCredentialCheck = strCC;
        }

        public void Checkfile(ref int nLength)
        {
            var reader = new StreamReader(File.OpenRead(@"C:\UserLogin.csv"));

            var line = reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var values = line.Split(';');

                listA.Add(values[0]);
                listB.Add(values[1]);
            }

            /*string[,] arrRows = new string[2, 40];

            try
            {
                using (StreamReader stmCheck = new StreamReader(strCredentialCheck))
                {
                    if (stmCheck.Peek() > 0)
                    {
                        string strLine = stmCheck.ReadLine();
                    }

                    while (stmCheck.Peek() > 0)
                    {
                        
                    }
                }
            }
            catch
            {

            }
            return arrRows;*/
        }

        public List<string> getListA()
        {
            return listA;
        }

        public List<string> getListB()
        {
            return listB;
        }
    }
}
