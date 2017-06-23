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
    set_000000();
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

  public void set_000000()
  {
    cube = color.get_000000();
  }

  public void set_0000FF()
  {
    cube = color.get_0000FF();
  }

  public void set_00FF00()
  {
    cube = color.get_00FF00();
  }

  public void set_00FFFF()
  {
    cube = color.get_00FFFF();
  }

  public void set_80FF80()
  {
    cube = color.get_80FF80();
  }

  public void set_80FFFF()
  {
    cube = color.get_80FFFF();
  }

  public void set_8080FF()
  {
    cube = color.get_8080FF();
  }

  public void set_555555()
  {
    cube = color.get_555555();
  }

  public void set_CCCCCC()
  {
    cube = color.get_CCCCCC();
  }

  public void set_FF0000()
  {
    cube = color.get_FF0000();
  }
  public void set_FF8080()
  {
    cube = color.get_FF8080();
  }

  public void set_FF00FF()
  {
    cube = color.get_FF00FF();
  }

  public void set_FF80FF()
  {
    cube = color.get_FF80FF();
  }

  public void set_FFFF00()
  {
    cube = color.get_FFFF00();
  }

  public void set_FFFF80()
  {
    cube = color.get_FFFF80();
  }

  public void set_FFFFFF()
  {
    cube = color.get_FFFFFF();
  }
}
