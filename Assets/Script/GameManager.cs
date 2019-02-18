using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {
    bool GameHasEnded = false;
    public GameObject WiningUI;
    public float RestartDelay = 2f;


    public void CompleteLevel(){

        WiningUI.SetActive(true);
        Debug.Log("youwon");
    }

    public void GameOver(){
    
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Gameover");
            Invoke("Restart", RestartDelay );
        }

    }
    void Restart (){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
