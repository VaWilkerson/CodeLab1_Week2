using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ASCIIHighScoreManager : MonoBehaviour
{
    //INTENT: load a series of high scores from a file

    public List<string> hsNames;    //Lists 
    public List<int> hsScores;
    
    
    void Start()
    {
        string filePath = Application.dataPath + "/highScore.txt";    // "/" means you're going into the folder at the end of Application.datapath

        if (!File.Exists(filePath))    //if the file does not exist - "!" means "not"
        {
            //CREATE A FILE
            string output = "";
            for (int i = 0; i < 10; i++)    
                //for loops have 3 parths: 1. declare a variabel that helps to keep track of where you are in the loop. 
                //1. its a temp variable that only exists in the loop. 
                //2. tells the loop to keep executing until the condition is met.
                //3. is the thing we change with each execution so that the loop condidtion is eventually met. Dont make an infinite loop. Please don't.  
            {
                output += "Matt:" + (10 - i) + '\n'; //+= adds what is on one side of the equation to the other side of the equation. 
                //output = "Matt:10\nMatt:9";    //"\| backslash n means new line before the next words in the string. it is a single character recognized by C#
            }
            
            Debug.Log("output: " + output);

            File.WriteAllText(filePath, output);    //WriteAllText builds up a string and then pushes the string into a file. 
        }
        //if the file does exist, read file. Don't need an else statement b/c we have ensured that the file exists. 

        string[] inputLines = File.ReadAllLines(filePath); 
        //loops through liens and use them into put into the list.
        for (int i = 0; i < inputLines.Length; i++)    //count is for lists, length is for arrays. 
        {
            string line = inputLines[i];    //ex: Matt:10
            string[] splitLine = line.Split(':');      //split the line on the ":" and go to the next
            //ex: "Matt" | "10" 
            string name = splitLine[0];    //ex: "Matt"
            int score = Int32.Parse(splitLine[1]);    //converts a string (string number) into a number
            //ex: 10 
            
            
            //with lists you can add and take away, arrays are forever.
            hsNames.Add(name);    //put name in my list of names
            hsScores.Add(score);    //put score in my list of scores
        }
    }

  
}
