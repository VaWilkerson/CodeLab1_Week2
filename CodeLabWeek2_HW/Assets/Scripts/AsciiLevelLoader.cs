using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class AsciiLevelLoader : MonoBehaviour
{
    //INTENT: create a script that creates walls at position of "X" in file
    
    void Start()
    {
        string filePath = Application.dataPath + "/level0.txt";    //filePath    

        if (!File.Exists(filePath))    //if the file does not exist...
        {
            File.WriteAllText(filePath, "X");    //...make a file with a single X in it. 
        }

        string[] inputLines = File.ReadAllLines(filePath);    //Get all the lines from the file, then- 

        for (int y = 0; y < inputLines.Length; y++)    // -loop to go through all the lines
        {
            string line = inputLines[y];    //fuck if i know. inputs Xs as cubes on the y axis? 

            for (int x = 0; x < line.Length; x++) //"length" in strings = the number of character in the string. 
            {
                //int x  = x pos
                if (line[x] == 'X')
                {
                    //make a wall
                    GameObject newWall = Instantiate(Resources.Load<GameObject>("Prefabs/Wall"));
                    newWall.transform.position = new Vector2(x - line.Length / 2f, y - inputLines.Length/2f);
                }
                else if (line[x] == 'P')    //makes a player
                {
                    GameObject player = Instantiate(Resources.Load<GameObject>("Prefabs/Player"));
                    player.transform.position = new Vector3(x - line.Length/2f, inputLines.Length/2f - y);
                }

//                //Creating the walls and player w/in the scene 
//                GameObject tile;
//
//                switch (line[x])
//                {
//                    case 'X':
//                        GameObject wall = Instantiate(Resources.Load <GameObject>("Prefabs/Wall"));
//                        wall.transform.position = new Vector2(x - line.Length/2f, inputLines.Length/2f - y);
//                        break;
//                    case 'P':
//                        tile = Instantiate(Resources.Load<GameObject>("Prefabs/Player"));
//                        break;
//                    case 'T':
//                        
//                        break;
//                    default: //if its none of those things above, do this instead. 
//                        tile = null;
//                        break;
//                }
//
//                if (tile != null)
//                {
//                    tile.transform.position = new Vector2(x- line.Length/2f, inputLines.Length/2f - y);
//                }
                
            }
        }

    }
    
}
