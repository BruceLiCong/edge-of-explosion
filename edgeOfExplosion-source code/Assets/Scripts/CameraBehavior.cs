using UnityEngine;
using System.Collections;

public class CameraBehavior : MonoBehaviour
{

    public bool cameraZoomedIn;
    public string whichRoomIsActive;

    public GUISkin customSkin1;
    public Texture2D room1Avatar;
    public Texture2D room1Dialog;

    public Texture2D room2Avatar;
    public Texture2D room2Dialog;

    public Texture2D room3Avatar;
    public Texture2D room3Dialog;

    public Texture2D room4Avatar;
    public Texture2D room4Dialog;

    public Texture2D room5Avatar;
    public Texture2D room5Dialog;

    public Texture2D room6Avatar;
    public Texture2D room6Dialog;
	
	


	// Use this for initialization
	void Start ()
	{

	    cameraZoomedIn = false;

	}
	IEnumerator ZoomIn()
	{
	    float targetSize = 5.15f;
        while(Camera.main.orthographicSize > targetSize)
        {
            Camera.main.orthographicSize -= 0.3f;
            yield return new WaitForEndOfFrame();
            cameraZoomedIn = true;
        }

	}

    IEnumerator ZoomOut()
    {
        float targetSize = 17.06f;
        while (Camera.main.orthographicSize < targetSize)
        {
            Camera.main.orthographicSize += 0.3f;
            yield return new WaitForEndOfFrame();
            cameraZoomedIn = false;
        }
    }

	// Update is called once per frame
	void Update () {

        //Debug.Log(cameraZoomedIn);

            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100))
                {
                    if(!cameraZoomedIn)
                    {
                        whichRoomIsActive = hit.transform.gameObject.tag;
                    }
                    

                    if (hit.transform.gameObject.tag.Equals("Room1"))
                    {
                        Go.to(transform, 1,
                              new TweenConfig().position(new Vector3(-1.079656f, -0.02581978f, -2.247413f)).setEaseType(
                                  EaseType.QuadInOut));
                        StartCoroutine(ZoomIn());
						
						//Camera.main.audio.PlayOneShot(heartbeat);
                    }
                    else if (hit.transform.gameObject.tag.Equals("Room2"))
                    {
                        Go.to(transform, 1,
                              new TweenConfig().position(new Vector3(10.079656f, -0.02581978f, -2.247413f)).setEaseType(
                                  EaseType.QuadInOut));
                        StartCoroutine(ZoomIn());
                    }
                    else if (hit.transform.gameObject.tag.Equals("Room3"))
                    {
                        Go.to(transform, 1,
                              new TweenConfig().position(new Vector3(-1.079656f, -11.3069f, -2.247413f)).setEaseType(
                                  EaseType.QuadInOut));
                        StartCoroutine(ZoomIn());
                    }
                    else if (hit.transform.gameObject.tag.Equals("Room4"))
                    {
                        Go.to(transform, 1,
                              new TweenConfig().position(new Vector3(10.079656f, -11.3069f, -2.247413f)).setEaseType(
                                  EaseType.QuadInOut));
                        StartCoroutine(ZoomIn());
                    }
                    //else if (hit.transform.gameObject.tag.Equals("Room5"))
                    //{
                    //    Go.to(transform, 3,
                    //          new TweenConfig().position(new Vector3(-1.079656f, -22.51644f, -2.247413f)).setEaseType(
                    //              EaseType.QuadInOut));
                    //    StartCoroutine(ZoomIn());
                    //}

                    //else if (hit.transform.gameObject.tag.Equals("Room6"))
                    //{
                    //    Go.to(transform, 3,
                    //          new TweenConfig().position(new Vector3(10.079656f, -22.51644f, -2.247413f)).setEaseType(
                    //              EaseType.QuadInOut));
                    //    StartCoroutine(ZoomIn());
                    //}
                }
            }

            else if (Input.GetMouseButtonDown(1))
            {
                Go.to(transform, 1,
                      new TweenConfig().position(new Vector3(3.501272f, -11.60932f, -2.247413f)).setEaseType(
                          EaseType.QuadInOut));
                StartCoroutine(ZoomOut());

            }

	}

    void OnGUI()
    {
        GUI.skin = customSkin1;

        if(cameraZoomedIn)
        {
            //Debug.Log(whichRoomIsActive);
            if(whichRoomIsActive.Equals("Room1"))
            {
                GUI.Button(new Rect(800, 400, 200, 200), room1Avatar);
                GUI.Button(new Rect(100, 490, 500, 200), room1Dialog);
                
            }
            else if(whichRoomIsActive.Equals("Room2"))
            {
                GUI.Button(new Rect(800, 400, 200, 200), room2Avatar);
                GUI.Button(new Rect(200, 490, 500, 200), room2Dialog);
            }
            else if (whichRoomIsActive.Equals("Room3"))
            {
                GUI.Button(new Rect(800, 400, 200, 200), room3Avatar);
                GUI.Button(new Rect(100, 490, 500, 200), room3Dialog);
            }
            else if (whichRoomIsActive.Equals("Room4"))
            {
                GUI.Button(new Rect(800, 400, 200, 200), room4Avatar);
                GUI.Button(new Rect(200, 490, 500, 200), room4Dialog);
            }
            //else if (whichRoomIsActive.Equals("Room5"))
            //{
            //    GUI.Button(new Rect(800, 400, 200, 200), room5Avatar);
            //    GUI.Button(new Rect(300, 400, 500, 200), room5Dialog);
            //}
            //else if (whichRoomIsActive.Equals("Room6"))
            //{
            //    GUI.Button(new Rect(800, 400, 200, 200), room6Avatar);
            //    GUI.Button(new Rect(300, 400, 500, 200), room6Dialog);
            //}
        }


    }

}
