using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{

    public void goToMenu(string nameScene) {

        SceneManager.LoadScene(nameScene);
    
    }

}
