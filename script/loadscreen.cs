using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscreen : MonoBehaviour {

	// Use this for initialization
	
	
	// Update is called once per frame
		public void newgame()
		{
			SceneManager.LoadScene("SampleScene");
		}
		public void exiit()
		{
			Application.Quit();
		}
	
}
