using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGen : MonoBehaviour {
  public GameObject cube;
  colorManager color;
  float drewTime;
  //Mode 0 = drow, 1 = erease
  int mode = 0;
  // Use this for initialization
  void Start () {
    drewTime = Time.deltaTime;
    color = GetComponent<colorManager>();
    cube = color.set_000000();
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
          if(mode == 0) {
            Instantiate(cube, hitPoint, transform.rotation);
          }
        }
        else if (hit.collider.tag == "cube")
        {
          if (drewTime > 0.075)
          {
            if (mode == 0)
            {
              Instantiate(cube, hitPoint, transform.rotation);
              drewTime = 0;
            }
            else if (mode == 1)
            {
              Destroy(hit.collider.gameObject);
            }
          }
          drewTime += Time.deltaTime;
        }
      }
    }
	}

  public void setDrowMode()
  {
    mode = 0;
  }

  public void setEreaseMode()
  {
    mode = 1;
  }
}
