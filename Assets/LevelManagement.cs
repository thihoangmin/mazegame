using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManagement : MonoBehaviour
{

    public void Openlevel(int levelId)
    {
        string Levelname = "level"  + levelId;
        SceneManager.LoadScene(Levelname);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Levelselect");
    }
    // public void Sound(bool Soundon)
    // {
    //     if (Soundon == true)
    //     {
            
    //     }

  
    // }
}
