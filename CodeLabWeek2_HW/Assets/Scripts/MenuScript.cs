using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
        //Gets the number of the active (Menu) scene and adds 1 to go to the next scene in the build order
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");    //checks for functionality in play mode
        Application.Quit();
        //function to quit the game application 
    }
}
