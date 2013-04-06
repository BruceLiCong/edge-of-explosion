using UnityEngine;
using System.Collections;

public class CreditsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI(){
		
		
		if (GUI.Button(new Rect(400, 540, 200, 50), "Back to the Menu")){
			
			Application.LoadLevel(0);
			
		}
		
		
	}
}
