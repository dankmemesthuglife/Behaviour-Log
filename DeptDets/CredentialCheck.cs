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

        public CredentialCheck(string strCC)
        {
            strCredentialCheck = strCC;
        }

        public string[,] Checkfile(ref int nLength)
        {
            var reader = new StreamReader(File.OpenRead(@"C:\test.csv"));
            
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                listA.Add(values[0]);
                listB.Add(values[1]);
            }
            
            string[,] arrRows = new string[2, 40];

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
            return arrRows;
        }
    }
}
