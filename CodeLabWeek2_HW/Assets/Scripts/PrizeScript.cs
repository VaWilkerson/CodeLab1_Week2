using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PrizeScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  //if the collider that hit us has a tag "player" 
        {
            other.gameObject.GetComponent<PlayerController>().Score++; //get the playerController and add 1 to its score
        }
   
    Destroy(gameObject); //destroy the gameObject this script is attached to
    }

    
}
