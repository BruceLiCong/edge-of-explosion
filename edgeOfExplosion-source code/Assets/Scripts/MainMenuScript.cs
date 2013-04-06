using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {
	
	public Texture2D playButton;
	public Texture2D howToPlayButton;
	public Texture2D creditsButton;
	public Texture2D exitButton;
	
	public GUISkin customSkin1;
	

	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
	
	void OnGUI(){
		
		GUI.skin = customSkin1;
		
		
		if (GUI.Button(new Rect(200, 280, 200, 100), playButton)){
			
			Application.LoadLevel(4);
			
		}
		
		if (GUI.Button(new Rect(200, 400, 200, 100), howToPlayButton)){
			Application.LoadLevel(2);
		}
		if (GUI.Button(new Rect(600, 280, 200, 100), creditsButton)){
			Application.LoadLevel(3);
		}
		if (GUI.Button(new Rect(600, 400, 125, 125), exitButton)){
			
			Application.Quit();
			Debug.Log("Exit Pressed");
			
		}
	
		
	}
	
	
}
