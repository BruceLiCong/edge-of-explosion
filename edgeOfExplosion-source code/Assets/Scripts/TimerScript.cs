using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour
{

    public float timerBar;
	public AudioClip explosion;
	private float timepast;
	private float finishTime;
	private float beginTime;
	
	/*
    public Puzzle1Script otherPiece1;
	 public Puzzle2Script otherPiece2;
	 public Puzzle3Script otherPiece3;
	 public Puzzle4Script otherPiece4;
	 */
    //public GameObject PuzzlePiece;
    // Use this for initialization

   // Puzzle1Script mScript;

	void Awake(){
		
	}
    void Start()
    {
		beginTime=Time.time;
		timepast =0;
		Puzzle1Script.isSolved1=false;
					Puzzle2Script.isSolved2 = false;
		Puzzle1Script.isBonus = false;
			Puzzle2Script.isBonus2 = false;
		//gametime = 0.0f;
		
     /*   otherPiece1 = GetComponent<Puzzle1Script>();
		 otherPiece2 = GetComponent<Puzzle2Script>();
		 otherPiece3 = GetComponent<Puzzle3Script>();
		 otherPiece4 = GetComponent<Puzzle4Script>();
    */
    }

    // Update is called once per frame
        void Update ()
        {
	
		
			
		
		
            
            transform.localScale += new Vector3(0, 0, -timerBar*Time.deltaTime);
		

            //Debug.Log(transform.localScale);

            if (transform.localScale.z <= 0)
            {
				if(timerBar != 0)
				{
					Camera.main.audio.Stop();
					//Camera.main.audio.PlayOneShot(explosion);
				//finishTime = Time.realtimeSinceStartup;
				}
              //  Debug.Log("Bitti");
                timerBar = 0;
				Application.LoadLevel(5);
			
			/*	finishTime = Time.time;
			float result = finishTime - beginTime;
			
			
				Debug.Log ("oyun bitti lan " + result);*/
				
                //Application.LoadLevel();
			
			
            }
		if(transform.localScale.z==1.0f){
			finishTime = Time.realtimeSinceStartup;
			Debug.Log(finishTime);
		}
		
/*
		if(puzzlePiece.GetComponent<Puzzle1Script>().isBonus){
			transform.localScale += new Vector3(0, 0 , 1.3f*Time.deltaTime);
		}
		puzzlePiece.GetComponent<Puzzle1Script>().isBonus=false;
*/

            if (Puzzle1Script.isBonus && transform.localScale.z>0)
            {
				
				transform.localScale += new Vector3(0, 0, 1.5f);
									
				if(transform.localScale.z>10.5f){
					transform.localScale= new Vector3(transform.localScale.x, transform.localScale.y, 10.5f);
				}
			
				
				Puzzle1Script.isBonus = false;
				
		}
            
            if (Puzzle4Script.isBonus4 && transform.localScale.z>0)
            {
                transform.localScale += new Vector3(0, 0, 1.5f);
                if (transform.localScale.z > 10.5f)
                {
                    transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 10.5f);
                }


                Puzzle4Script.isBonus4 = false;

            }
            
            if (Puzzle2Script.isBonus2 && transform.localScale.z>0)
            {
                transform.localScale += new Vector3(0, 0, 1.5f);
                if (transform.localScale.z > 10.5f)
                {
                    transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 10.5f);
                }


                Puzzle2Script.isBonus2 = false;

            }


            if (Puzzle3Script.isBonus3 && transform.localScale.z>0)
            {
                transform.localScale += new Vector3(0, 0, 1.5f);
                if (transform.localScale.z > 10.5f)
                {
                    transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 10.5f);
                }


                Puzzle3Script.isBonus3 = false;

            }
            
            
		

        }
	


}
