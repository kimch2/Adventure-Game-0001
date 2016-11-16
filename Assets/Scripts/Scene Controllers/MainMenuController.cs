﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	public void StartGame()
	{
		SceneManager.LoadScene("Level 1");
	}
	public void LoadGame()
	{
		//SceneManager.LoadScene("Level 1");
	}
	public void ToOption()
	{
		SceneManager.LoadScene("OptionMenu");
	}
	public void Quit()
	{
		Application.Quit();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Escape))
			Application.Quit();
	}
}
