using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Resolvers;
using UnityEditor;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;
                        
    public class Restart : MonoBehaviour
    {
        void Update ()
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                //SceneManager.LoadScene("SampleScene");    //Loads the scene named "SampleScene"
                //SceneManager.LoadScene(0);    //Loads the first scene in Build Settings
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);    //Reloads current scene
            }
        }
    }

    
  

