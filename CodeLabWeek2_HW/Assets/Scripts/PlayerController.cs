using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    Rigidbody2D rb;
    
    public float forceAmount = 1;
    
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;
    
    public int Score = 0;
    
    // Start is called before the first frame update
    void  Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update() {
        
       Vector3 newForce = new Vector3(0, 0, 0); //The force we will add to our player
        
        if (Input.GetKey(upKey)) //When someone presses "W" 
        { 
           //Debug.Log("Pressed W");
            newForce.y += forceAmount;   // += sets it to increment the force by that amount
        }
        
        if (Input.GetKey(downKey)) 
        { 
            newForce.y -= forceAmount;
        }
        
        if (Input.GetKey(leftKey)) 
        { 
            newForce.x -= forceAmount;
        }
        
        if (Input.GetKey(rightKey)) 
        { 
            newForce.x += forceAmount;
        }
        
        
       // I spent 8 hours trying to get these goddamn ducks to turn and Siddarth showed me how to do it in 10 minutes. fml.
       rb.AddForce(newForce);    

        if (newForce != Vector3.zero)  
        {
            transform.up = newForce;    //turns the player('s Rigidbody2D) to face the direction of movement
        }
        
           
    }

}
