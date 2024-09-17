using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class _Wordlist : MonoBehaviour
{
    public List<string> Green;
    public List<string> Orange;
    public List<string> Red;

    void Start()
    {
        ReadGreen();
        ReadOrange();
        ReadRed();
    }


    private void ReadGreen()
    {
        StreamReader strReader = new StreamReader("Assets/StreamingAssets/CSV/CSVGreen.csv");
        bool endOfFile = false;
        while(!endOfFile)
        {
            string data_String = strReader.ReadLine();
            if(data_String == null)
            {
                endOfFile = true;
                break;
            }
            var data_values = data_String.Split(",");
            for(int i = 0; i < data_values.Length; i++)
            {
                Green.Add(data_values[i]);
            } 
        }
    }
    private void ReadOrange()
    {
        StreamReader strReader = new StreamReader("Assets/StreamingAssets/CSV/CSVOrange.csv");
        bool endOfFile = false;
        while(!endOfFile)
        {
            string data_String = strReader.ReadLine();
            if(data_String == null)
            {
                endOfFile = true;
                break;
            }
            var data_values = data_String.Split(",");
            for(int i = 0; i < data_values.Length; i++)
            {
                Orange.Add(data_values[i]);
            } 
        }
    }
     private void ReadRed()
    {
        StreamReader strReader = new StreamReader("Assets/StreamingAssets/CSV/CSVRed.csv");
        bool endOfFile = false;
        while(!endOfFile)
        {
            string data_String = strReader.ReadLine();
            if(data_String == null)
            {
                endOfFile = true;
                break;
            }
            var data_values = data_String.Split(",");
            for(int i = 0; i < data_values.Length; i++)
            {
                Red.Add(data_values[i]);
            } 
        }
    }
}
