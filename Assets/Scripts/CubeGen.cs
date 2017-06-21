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

    if(Input.GetMouseButtonDown(0))
    {
      ray = Camera.main.ScreenPointToRay(Input.mousePosition);

      if(Physics.Raycast(ray, out hit, 100))
      {
        Debug.Log("x: " + Input.mousePosition.x + " y: " + Input.mousePosition.y + " z: "  + Input.mousePosition.z);
        Instantiate(cube, transform.position, transform.rotation);

      }
    }
	}
}
