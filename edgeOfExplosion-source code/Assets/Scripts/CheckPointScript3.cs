using UnityEngine;
using System.Collections;

public class CheckPointScript3 : MonoBehaviour
{
    public GameObject piece1;
    public GameObject piece2;
    public GameObject piece3;
    public GameObject piece4;
    public GameObject piece5;
    public GameObject piece6;
    public GameObject piece7;


    private Vector3 piece1Position;
    private Vector3 piece2Position;
    private Vector3 piece3Position;
    private Vector3 piece4Position;
    private Vector3 piece5Position;
    private Vector3 piece6Position;
    private Vector3 piece7Position;

    private float waitingTime;
	
	public GameObject[] brokenTubes;

    // Use this for initialization
    void Start()
    {

        piece1Position = piece1.GetComponent<Transform>().position;
        piece2Position = piece2.GetComponent<Transform>().position;
        piece3Position = piece3.GetComponent<Transform>().position;
        piece4Position = piece4.GetComponent<Transform>().position;
        piece5Position = piece5.GetComponent<Transform>().position;
        piece6Position = piece6.GetComponent<Transform>().position;
        piece7Position = piece7.GetComponent<Transform>().position;

		brokenTubes = GameObject.FindGameObjectsWithTag("BrokenTube");
    }

    // Update is called once per frame
    void Update()
    {

        if (Puzzle3Script.isCheckPoint)
        {

            if (Time.time - Puzzle3Script.checkpointTime > 10)
            {

                piece1.GetComponent<Transform>().position = piece1Position;
                piece2.GetComponent<Transform>().position = piece2Position;
                piece3.GetComponent<Transform>().position = piece3Position;
                piece4.GetComponent<Transform>().position = piece4Position;
                piece5.GetComponent<Transform>().position = piece5Position;
				
				brokenTubes[0].SetActive(true);
				brokenTubes[1].SetActive(true);
				
                piece6.GetComponent<Transform>().position = piece6Position;
                piece7.GetComponent<Transform>().position = piece7Position;

                Puzzle3Script.isCheckPoint = false;
				Puzzle3Script.isSolved3 = false;
	
            }
        }



    }
}
