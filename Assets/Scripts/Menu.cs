﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	
	public GameObject commandsPanel;
	public GameObject volumePanel;
	
	public void Play()
	{
		SceneManager.LoadScene("Desktop");
	}
	
	public void Quit()
	{
		#if (UNITY_EDITOR || DEVELOPMENT_BUILD)
		UnityEditor.EditorApplication.isPlaying = false;
		#endif
		#if (UNITY_EDITOR)
		UnityEditor.EditorApplication.isPlaying = false;
		#elif (UNITY_STANDALONE) 
		Application.Quit();
		#elif (UNITY_WEBGL)
		Application.OpenURL("about:blank");
		#endif
	}
	
	public void MainMenu()
	{
		SceneManager.LoadScene("Menu");
	}
	
	public void Commands()
	{
		commandsPanel.SetActive (true);
	}
	
	public void BackCommands()
	{
		commandsPanel.SetActive (false);
	}
	
	public void Volume()
	{
		volumePanel.SetActive (true);
	}
	
	public void BackVolume()
	{
		volumePanel.SetActive (false);
	}
}
