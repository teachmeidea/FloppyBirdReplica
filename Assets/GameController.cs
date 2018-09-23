using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public static GameController instance;

    public bool isPlaying = false;
    public Transform panel;
    public Text scoreText;

    private int currentScore;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        isPlaying = true;
    }

    void Update()
    {
        scoreText.text = currentScore.ToString();

        if(Input.GetMouseButtonDown(0) && !isPlaying)
        {
            Restart();
        }
    }

    public void Pass()
    {
        currentScore += 1;
    }

    public void GameOver()
    {
        isPlaying = false;
        panel.gameObject.SetActive(true);
    }

    public void Restart()
    {
        isPlaying = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
