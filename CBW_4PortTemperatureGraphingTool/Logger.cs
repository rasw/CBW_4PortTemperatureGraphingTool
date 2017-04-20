using System;
using System.IO;


namespace AkvaData
{
    public static class Logger
    {
        //public static void WriteToLog(string Data, string UserName);
        public static void WriteToLog(string Data)
        {
            try
            {
                string filename = Path.Combine(Directory.GetCurrentDirectory(), "CBW_4PortTemperatureGraphingTool_Errors.txt"); //\\ak-inv-fs1\";

                using (StreamWriter sr = new StreamWriter(filename, true))
                {
                    if (Data != null) sr.WriteLine(DateTime.Now.ToString() + " -> " + Data); // + " -> User Name: " + UserName);
                    sr.Close();
                }
            }
            catch {}
        }
    }
 }

 

