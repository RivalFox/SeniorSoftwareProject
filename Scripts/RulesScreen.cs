using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RulesScreen : MonoBehaviour
{
    public GameObject rulesScreen;

    private void Start()
    {

    }
    public void GoToGameScreen()
    {
        //end of save data reader code.
        SceneManager.LoadScene(GameManager.GetPreviousScene());
    }

    
}
