using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

    public string nextSceneName;
    public string prevSceneName;
    public string lastSceneName;

    public void NextScene() {
        SceneManager.LoadScene(nextSceneName);
    }

    public void PrevScene() {
        SceneManager.LoadScene(prevSceneName);
    }

    public void LastScene() {
        SceneManager.LoadScene(lastSceneName);
    }
}