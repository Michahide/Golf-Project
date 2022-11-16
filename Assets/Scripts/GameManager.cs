using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] TMP_Text gameOverText;
    [SerializeField] PlayerController player;
    [SerializeField] Hole hole;

    private void Start() {
        gameOverPanel.SetActive(false);
    }

    private void Update() {
        if (hole.Entered && !gameOverPanel.activeInHierarchy)
        {
            gameOverPanel.SetActive(true);
            gameOverText.text = "Finish! Shoot Count: " + player.ShootCount;
        }
    }

    public void BackToMainMenu(){
        SceneLoader.Load("MainMenu");
    }

    public void PlayAgain(){
        SceneLoader.ReloadLevel();
    }

    public void PlayNext(){
        SceneLoader.LoadNextLevel();
    }

    public void QuitBut(){
        Application.Quit();
    }

}
