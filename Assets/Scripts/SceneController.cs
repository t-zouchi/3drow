﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  public void LoadMain()
  {
    SceneManager.LoadScene("Main");
  }

  public void LoadTitle()
  {
    SceneManager.LoadScene("Title");
  }

  public void LoadHowTo()
  {
    SceneManager.LoadScene("HowTo");
  }
}
