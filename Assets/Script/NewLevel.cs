using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewLevel : MonoBehaviour {

    public void Newlevel(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
