﻿using System;
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

        bool Check = false;

        public CredentialCheck(string strCC)
        {
            strCredentialCheck = strCC;
        }

        public bool Checkfile(string email, string password)
        {
            var reader = new StreamReader(File.OpenRead(@"UserLogin.csv"));

            var line = reader.ReadLine();

            try
            {
                using(StreamReader stmCheck = new StreamReader(strCredentialCheck))
                {
                    while(stmCheck.Peek() > 0)
                    {
                        var values = line.Split(';');

                        listA.Add(values[0]);
                        listB.Add(values[1]);

                        for (int i = 0; i < listA.Capacity; i++)
                        {
                            if (listA[i] == email)
                            {
                                if (listB[i] == password)
                                {
                                    Check = true;

                                    return Check;
                                }
                            }
                        }
                    }

                    return Check;

                }
            }
            catch
            {
                return false;
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
