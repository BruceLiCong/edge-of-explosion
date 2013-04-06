using UnityEngine;
using System.Collections;

public class Puzzle3Script : MonoBehaviour
{

    public static int counter;
    public static bool isBonus3 = false;

    public static bool isCheckPoint = false;
    public static float checkpointTime;
	public static bool isSolved3 = false;

	// Use this for initialization
	void Start ()
	{

	    counter = 0;
	}
	
	// Update is called once per frame
	void CheckIsBonus() {
	
        if(counter == 4 && !isSolved3)
        {
            Debug.Log("PUZZLE SOLVED!!!");
            isBonus3 = true;
            isCheckPoint = true;
			isSolved3 =true;
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
            CheckIsBonus();
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
