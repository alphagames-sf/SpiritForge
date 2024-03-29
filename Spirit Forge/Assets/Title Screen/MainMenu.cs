using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public Animator animator;
    private string levelToLoad;

    public void FadeToLevel (string levelName) {
        levelToLoad = levelName;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete () {
        SceneManager.LoadScene(levelToLoad);
    }

    public void PlayGame() {
        FadeToLevel("Level 1");
        //SceneManager.LoadScene("Level 1");
    }

    public void QuitGame() {
        Application.Quit();
    }
}
