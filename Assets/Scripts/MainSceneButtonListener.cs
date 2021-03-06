﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSceneButtonListener : MonoBehaviour {

	public GameObject quad;

    public Text recordText;

    public string action;

    void Start()
    {
		WelcomeDialog.isDialog = false;
		Time.timeScale = 1;
        initializeAd();    
   //     Preferences.resetAttempts();
		Preferences.setWelcomeShown(false);
		recordText.text = PlayerPrefs.GetInt("Record").ToString();
    }


	void OnMouseDown()
    {

    }

	void Update(){
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit();
		}
	}

    void OnMouseUp()
    {

    }

    void OnMouseUpAsButton()
    {
		
        switch (action)
        {
		case "Play":
			gameObject.transform.localScale = new Vector3 (0.34f, 0.34f, 1f);
			WelcomeDialog.isDialog = true;
			WelcomeDialog.isActive = true;
			StartCoroutine ("wait");
            break;
        }
    }

    public void initializeAd()
    {
        string appKey = "b1312497ddd5c9fdc3ba969a9488d90b5278eb4b1f8c0a22";
  //      Appodeal.initialize(appKey, Appodeal.NON_SKIPPABLE_VIDEO);
    }

	IEnumerator wait(){
		yield return new WaitForSeconds (0.1f);
		SceneManager.LoadScene("Play");
		gameObject.transform.localScale = new Vector3(0.3f,0.3f,1f);
	}


}
