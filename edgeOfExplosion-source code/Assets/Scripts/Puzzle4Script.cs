using UnityEngine;
using System.Collections;

public class Puzzle4Script : MonoBehaviour
{

    public static int counter=0;
    public static bool isBonus4 = false;
	public static bool isSolved4 = false;
	public static bool isCheckPoint = false;
	public static float checkpointTime;
    // Use this for initialization
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
		
       
    }
    void CheckisBonus()
    {
        if (counter == 10 && !isSolved4)
        {
            Debug.Log("okkayyy" + Time.time);
            isBonus4 = true;
			isSolved4 = true;
            isCheckPoint = true;
            checkpointTime = Time.time;

        }

    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag.Equals(gameObject.tag))
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
