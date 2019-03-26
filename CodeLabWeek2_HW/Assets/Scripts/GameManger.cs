using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    private int score = 0; //private = not available in the inspector 

    public static GameManger instance;
    
    public Text scoreText;

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
            
            print("Score now equals " + score); //once you finish using a message to help with your code, comment it out. or dont, it's your life
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null) //if this game object is uninitialized, dont destroy this game object and set the "instance" to "this"
        {
            DontDestroyOnLoad(gameObject);
            instance = this; //"this" means this instance of a script I am currently in 
            //if you haven't (null) seen a Game Manager script, don't get rid of it. 
            //if a gameManager script DOES exist, destroy any duplicates 
        }
    }

    // Update is called once per frame
    void Update()
    {
//    private bool paused;
    
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Reloads current scene
        }
        
        //scoreText.text = other.gameObject.GetComponent<PlayerController>().Score++.ToString();
        //^ need to find a way to reference the player scores in game manager 

        //Score ++;
        //print("Your current score is: " + Score);
    }
    
    
    
}
