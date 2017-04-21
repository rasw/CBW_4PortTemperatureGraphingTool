using System;
using System.Collections.Generic;
using System.Linq;

namespace CBW_4PortTemperatureGraphingTool
{
    internal class GetCBWMinMaxValues
    {
        internal double GetMax(List<string> coreDataLines)
        {
            List<string> s1 = new List<string>();
            List<string> s2 = new List<string>();
            List<string> s3 = new List<string>();
            List<string> s4 = new List<string>();
            
            foreach (var line in coreDataLines)
            {
                string[] d = line.Split('|');
                s1.Add(d[1]);        // Sensor 1 Reading
                s2.Add(d[2]);        // Sensor 2 Reading
                s3.Add(d[3]);        // Sensor 3 Reading
                s4.Add(d[4]);        // Sensor 4 Reading             
            }

            double s1Max = s1.Select(v => double.Parse(v)).Max();
            double s2Max = s2.Select(v => double.Parse(v)).Max();
            double s3Max = s3.Select(v => double.Parse(v)).Max();
            double s4Max = s4.Select(v => double.Parse(v)).Max();

            double[] numbers = new double[] { s1Max,s2Max,s3Max,s4Max};
            return numbers.Max();
        }

        internal double GetMin(List<string> coreDataLines)
        {
            List<string> s1 = new List<string>();
            List<string> s2 = new List<string>();
            List<string> s3 = new List<string>();
            List<string> s4 = new List<string>();

            foreach (var line in coreDataLines)
            {
                string[] d = line.Split('|');
                s1.Add(d[1]);        // Sensor 1 Reading
                s2.Add(d[2]);        // Sensor 2 Reading
                s3.Add(d[3]);        // Sensor 3 Reading
                s4.Add(d[4]);        // Sensor 4 Reading             
            }

            double s1Min = s1.Select(v => double.Parse(v)).Min();
            double s2Min = s2.Select(v => double.Parse(v)).Min();
            double s3Min = s3.Select(v => double.Parse(v)).Min();
            double s4Min = s4.Select(v => double.Parse(v)).Min();

            double[] numbers = new double[] { s1Min, s2Min, s3Min, s4Min };
            return numbers.Min();
        }
    }
}