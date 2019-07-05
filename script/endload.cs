using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endload : MonoBehaviour {

	// Use this for initialization
	
	
	// Update is called once per frame
		public void Retry()
		{
			SceneManager.LoadScene("SampleScene");
		}
		public void home()
		{
			SceneManager.LoadScene("menu");
		}
	
}
