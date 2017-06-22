using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGen : MonoBehaviour {
  public GameObject cube;
  float drewTime;
  // Use this for initialization
  void Start () {
    drewTime = Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
    Ray ray;
    RaycastHit hit;
    Vector3 hitPoint;
    

    if (Input.GetMouseButton(0))
    {
      ray = Camera.main.ScreenPointToRay(Input.mousePosition);

      if (Physics.Raycast(ray, out hit, 100))
      {
        hitPoint = hit.point;
        if (hitPoint.y < 0.05f)
        {
          hitPoint.y = 0.05f;
        }

        if (hit.collider.tag == "Plane")
        {
          Instantiate(cube, hitPoint, transform.rotation);
        }
        else if (hit.collider.tag == "cube")
        {
          if (drewTime > 0.075)
          {
            Instantiate(cube, hitPoint, transform.rotation);
            drewTime = 0;
          }
          drewTime += Time.deltaTime;
        }
      }
    }
	}
}
