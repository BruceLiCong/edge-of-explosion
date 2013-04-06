using UnityEngine;
using System.Collections;

public class Puzzle3DestroyTube : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetMouseButtonDown(0)){
 
               Ray rays = Camera.main.ScreenPointToRay(Input.mousePosition);
               RaycastHit hit;
 
            if(Physics.Raycast(rays, out hit, 10f))
            {
                Debug.DrawRay (rays.origin, hit.point);
            }
                 

            if (hit.collider.gameObject.tag.Equals("BrokenTube"))
            {
                Debug.Log("yok edilecek");
                //Destroy(hit.collider.gameObject);
                hit.collider.gameObject.SetActive(false);
            }

        }
    }

}
