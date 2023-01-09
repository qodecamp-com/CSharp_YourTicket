using System;
using System.Collections;
using System.IO;

namespace ExceptionHandling;

public class IntegerReader
{
    private ArrayList integerList;

    public IntegerReader()
    {
        integerList = new ArrayList();
    }

    public void ReadIntegers(string filePath)
    {
        try
        {
            StreamReader reader = new StreamReader(filePath);
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                int integer = int.Parse(line);
                integerList.Add(integer);
            }
            reader.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading file: " + ex.Message);
        }
    }

    public ArrayList GetIntegerList()
    {
        return integerList;
    }
}
