using UnityEngine;
using System.Collections;

public class IntroScript : MonoBehaviour {
	
	
	public Texture2D skipButton;
	public GUISkin customSkin1;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		
		GUI.skin = customSkin1;
		
		if (GUI.Button(new Rect(550, 600, 200, 50), skipButton)){
			
			Application.LoadLevel(1);
		}
	
	}
}
