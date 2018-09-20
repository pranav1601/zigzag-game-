using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {

    public static UiManager instance;

    public GameObject zigzag;
    public GameObject gameover;
    public GameObject taptext;

    public Text score;
    public Text highscore1;
    public Text highscore2;

    void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }

	// Use this for initialization
	void Start () {
        highscore1.text = "High Score:" + PlayerPrefs.GetInt("highscore");
    }

    public void GameStart()
    {
        
        taptext.SetActive(false);
        zigzag.GetComponent<Animator>().Play("textup");

    }

    public void GameOver()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
        highscore2.text = PlayerPrefs.GetInt("highscore").ToString();
        gameover.SetActive(true);
    }
	
    public void resetButton()
    {
        SceneManager.LoadScene(0);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
