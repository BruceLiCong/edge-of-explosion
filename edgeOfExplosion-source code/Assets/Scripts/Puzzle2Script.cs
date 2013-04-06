using UnityEngine;
using System.Collections;

public class Puzzle2Script : MonoBehaviour {

	
    public static int counter=0;
    public static bool isBonus2 = false;
    public static bool isCheckPoint = false;
    public static float checkpointTime;
	public static bool isSolved2 = false;

	// Use this for initialization
	void Start ()
	{
		isBonus2=false;
	  
        
	}
	
	// Update is called once per frame
	void Update () {
	
      
	}
    void CheckisBonus()
    {
        if (counter == 3 && !isSolved2)
        {
            Debug.Log("okkayyy" + Time.time);
            isBonus2 = true;
            isCheckPoint = true;
			isSolved2=true;
            checkpointTime = Time.time;

        }

    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag.Equals(gameObject.tag))
        {
            //Debug.Log("ayni");
            
            counter++;
            CheckisBonus();
            Debug.Log(counter);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals(gameObject.tag))
        {
            //Debug.Log("ayni");
            counter--;
            Debug.Log(counter);
        }
    }
}
