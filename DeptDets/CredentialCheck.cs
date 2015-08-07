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
            string[,] arrRows = new string[500, 20];

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
