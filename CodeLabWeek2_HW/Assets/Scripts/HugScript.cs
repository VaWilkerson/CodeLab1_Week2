using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HugScript : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)    //doesnt return a value unlike int and float //Triggers are not collidable, Collision is effected by gravity and physics 
    {
        Debug.Log("HIT!");
        SceneManager.LoadScene(1);
        GameManger.instance.Score++; //go into gameManager script and change the score 
        //So now the score will carry over no matter how many times we load the scene 
    }
    
}
