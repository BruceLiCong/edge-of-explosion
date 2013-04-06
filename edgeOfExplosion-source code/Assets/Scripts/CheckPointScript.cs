using UnityEngine;
using System.Collections;

public class CheckPointScript : MonoBehaviour {
	
	public GameObject piece1;
	public GameObject piece2;
	public GameObject piece3;
	public GameObject piece4;
    public GameObject piece5;


	private Vector3 piece1Position;
	private Vector3 piece2Position;
	private Vector3 piece3Position;
	private Vector3 piece4Position;
	private Vector3 piece5Position;
	
	private float waitingTime;
	
	// Use this for initialization
	void Start () {

        piece1Position = piece1.GetComponent<Transform>().position;
        piece2Position = piece2.GetComponent<Transform>().position;
        piece3Position = piece3.GetComponent<Transform>().position;
        piece4Position = piece4.GetComponent<Transform>().position;
        piece5Position = piece5.GetComponent<Transform>().position;

	   


	}
	
	// Update is called once per frame
	void Update ()
	{

	  
				
		if (Puzzle1Script.isCheckPoint){
			
			if(Time.time-Puzzle1Script.checkpointTime > 10 ){
                piece1.GetComponent<Transform>().position = piece1Position;
                piece2.GetComponent<Transform>().position = piece2Position;
                piece3.GetComponent<Transform>().position = piece3Position;
                piece4.GetComponent<Transform>().position = piece4Position;
                piece5.GetComponent<Transform>().position = piece5Position;

			    

            

			Puzzle1Script.isCheckPoint=false;
			Puzzle1Script.isSolved1 = false;
			}
		}
		
		
	
	}
}
