using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public bool gameOver;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
	// Use this for initialization
	void Start () {
        gameOver = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startgame()
    {
        UiManager.instance.GameStart();
        scoremanager.instance.startscore();
        GameObject.Find("PlatformSpawner").GetComponent<PlatformSpawner>().startspawning();

    }

    public void gameover()
    {
        UiManager.instance.GameOver();
        scoremanager.instance.stopscore();
        gameOver = true;

    }
}
