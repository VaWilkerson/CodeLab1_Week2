using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1, 2);    //spawns 1 BreadSlice every 2 seconds, repeating 
        //VCS comment to test update
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn() 
    {
        GameObject newPrize = Instantiate(Resources.Load<GameObject>("Prefabs/BreadSlice"));    //instantiates prefab "BreadSlice"
        newPrize.transform.position = new Vector2(Random.Range(-10, 10), Random.Range(-10, 10));    //spawns the BreadSlice in a random location within a fixed area
        newPrize.transform.eulerAngles = new Vector3(0,0,Random.Range(0, 360));    //rotates the BreadSlice randomly 

    }   
}
