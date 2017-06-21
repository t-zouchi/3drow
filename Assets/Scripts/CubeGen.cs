using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGen : MonoBehaviour {
  public GameObject cube;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    Ray ray;
    RaycastHit hit;
    Vector3 hitPoint;

    if(Input.GetMouseButtonDown(0))
    {
      ray = Camera.main.ScreenPointToRay(Input.mousePosition);

      if(Physics.Raycast(ray, out hit, 100))
      {
        hitPoint = hit.point;
        if(hitPoint.y < 0.05f)
        {
          hitPoint.y = 0.05f;
        }
        Instantiate(cube, hitPoint, transform.rotation);

      }
    }
	}
}
