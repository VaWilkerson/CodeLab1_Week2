using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    private int score = 0; //private = not available in the inspector 

    public static GameManger instance;

    public int Score //Property's are for getting and setting a value'
    {
        get { return score; }
        set
        {
            score = value;

            if (score > 10)
            {
                //Score = 10; //sets the maximum score to 10.  
            }

            if (score < 0)
            {
                score = 0; //sets the minimum score to 0 if there were a way to get a negative score. 
            }
            
            print("Score now equals " + score); //once you finish using a message to help with your code, comment it out 
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null) //if this game object is uninitialized, dont destroy this game object and set the "instance" to "this"
        {
            DontDestroyOnLoad(gameObject);
            instance = this; //"this" means this instance of a script I am currently in 
            //if you havent (null) seen a Game Manager script, dont get rid of it. 
            //if a gamemanager script DOES exist, destroy any duplicates 
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Score ++;
        //print("Your current score is: " + Score);
    }
    
    
    
}
