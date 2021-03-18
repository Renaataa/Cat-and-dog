using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameOverPanelController : MonoBehaviour
{
    GameManager gm;
    
    void Awake(){
        gm = GameManager.Instance;
    }

    // Start is called before the first frame update
    void Start() 
    {
    
    }

    public void LoadLevelAgain(){
        Debug.Log("GameOverPanelController.LoadLevelAgain"+gm.currentLevel);
        gm.OpenLevel(gm.currentLevel);
    }
    
    public void LoadNextLevel(){
        
        gm.currentLevel++;
        
        if(gm.currentLevel < gm.levelNames.Length){
            gm.OpenLevel(gm.currentLevel);
        }
        else{
            gm.currentLevel = 0;
            gm.OpenLevel(gm.currentLevel);
        }
        Debug.Log("GameOverPanelController.LoadNextLevel"+gm.currentLevel);
    }

    public void LoadMenu(){
        Debug.Log("GameOverPanelController.LoadMenu"+gm.currentLevel);
        SceneManager.LoadScene("menu");
    }
}
