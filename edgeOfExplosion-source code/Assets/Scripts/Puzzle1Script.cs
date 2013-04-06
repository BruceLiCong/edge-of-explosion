using UnityEngine;
using System.Collections;

public class Puzzle1Script : MonoBehaviour {
	public enum Direction { right, down, left, up}
	public static int counter=0;
	public Direction direction;
	public static bool isBonus=false;
	
	public static bool isCheckPoint = false;
	public static float checkpointTime;
	public static bool isSolved1 = false;
	
	public float controlTimer;
		
	
	// Use this for initialization
	void Start () {
		isBonus=false;
	
	}
	
	void CheckisBonus() {
		if(counter==4 && !isSolved1){
			Debug.Log("okkayyy"+Time.time);
			isBonus=true;
			isCheckPoint = true;
			isSolved1 = true;
			checkpointTime = Time.time;
			controlTimer = Time.time;
			
		}
	
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Piece"){
			Debug.Log("Hit Piece");
			Puzzle1Script otherPiece = other.GetComponent<Puzzle1Script>();
			switch(direction)
			{
			case Direction.right:
				if(otherPiece.direction == Direction.left)
				{

					counter++;
					CheckisBonus();
					Debug.Log("True  " + Time.time);
					Debug.Log (counter);
				}
				break;
			case Direction.down:
				if(otherPiece.direction == Direction.up)
				{
					Debug.Log("True  " + Time.time);
			
					counter++;
					CheckisBonus();
					Debug.Log (counter);
				}
				break;
			}
		}
	}
	void OnTriggerExit(Collider other){
		if(other.gameObject.tag == "Piece"){
			Debug.Log("Hit Piece");
			Puzzle1Script otherPiece = other.GetComponent<Puzzle1Script>();
			switch(direction)
			{
			case Direction.right:
				if(otherPiece.direction == Direction.left)
				{
					
					counter--;
					Debug.Log("True  " + Time.time);
					Debug.Log (counter);
				}
				break;
			case Direction.down:
				if(otherPiece.direction == Direction.up)
				{
					Debug.Log("True  " + Time.time);
					counter--;
					Debug.Log (counter);
				}
				break;
			}
		}
	}
}
