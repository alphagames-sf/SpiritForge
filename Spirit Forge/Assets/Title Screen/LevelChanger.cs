using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelChanger : MonoBehaviour {
    public Animator animator;
    private string levelToLoad;

    public void FadeToLevel (string levelName) {
        levelToLoad = levelName;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete () {
        SceneManager.LoadScene(levelToLoad);
    }
}