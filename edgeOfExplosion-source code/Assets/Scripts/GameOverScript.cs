using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {
	
	public AudioClip explosion;
	
	
	// Use this for initialization
	void Start () {
		
		audio.PlayOneShot(explosion);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI(){
		
		if (GUI.Button(new Rect(400, 440, 200, 50), "Back to the Menu")){
			
			Application.LoadLevel(0);
		}
		
		
	}
}
