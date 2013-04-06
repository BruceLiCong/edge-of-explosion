using UnityEngine;
using System.Collections;

public class Puzzle3Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetMouseButtonDown(2))
        {

            Ray rays = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(rays, out hit, 10f))
            {
                Debug.DrawRay(rays.origin, hit.point);
            }


            if (hit.collider.gameObject.tag.Equals("Puzzle3Pieces"))
            {
                Debug.Log("dondur");
                //Destroy(hit.collider.gameObject);
                hit.transform.gameObject.transform.Rotate(0, 0, 180);
            }

        }

/*

        if (Input.GetMouseButtonDown(2))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {

                if (hit.collider.gameObject.tag.Equals("Puzzle3Pieces"))
                {
                    hit.transform.gameObject.transform.Rotate(0, 0, 180);
                }

            }
        }
*/
	}
}
