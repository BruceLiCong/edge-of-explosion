using UnityEngine;
using System.Collections;

public class HowToPlayScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI(){
		
		
	if (GUI.Button(new Rect(100, 520, 200, 50), "Back to the Menu")){
			
			Application.LoadLevel(0);
			
		}
		
		
	}
}
