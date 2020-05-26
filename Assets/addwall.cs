using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addwall : MonoBehaviour
{

 public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        float x = 0.50f;
        float y = 1.25f;
        float z = 0.00f;
        float l1 = 2.25f;
        float l2 = 2.5f;
        float m = 0.10f;
        
        Vector3 pos = new Vector3(x,y,z);
        Vector3 loc = new Vector3(l1,l2,m);
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = pos;
        cube.transform.localScale = loc;

        Vector3 pos1 = new Vector3(x+(l1/2),y,z+(l1/2));
        GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.position = pos1;
        cube1.transform.localScale = loc;
        cube1.transform.eulerAngles = new Vector3(cube1.transform.eulerAngles.x,cube1.transform.eulerAngles.y + 90,cube1.transform.eulerAngles.z);

        Vector3 pos2 = new Vector3(x-(l1/2),y,z+(l1/2));
        GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2.transform.position = pos2;
        cube2.transform.localScale = loc;
        cube2.transform.eulerAngles = new Vector3(cube1.transform.eulerAngles.x,cube1.transform.eulerAngles.y,cube1.transform.eulerAngles.z);

        Vector3 pos3 = new Vector3(x+0.5f,y+0.5f,z+2*l1-0.45f);
        float angleDegrees = 90;
        Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
      
        //GameObject cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //cube3.transform.position = pos3;
        //cube3.transform.localScale = loc;
        //door = GameObject.FindGameObjectWithTag("door");
        
        //Vector3 pos3 = new Vector3(x,y+l1/2,z+l1/2); //if wrong change to l2/2 for y
        //GameObject cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Instantiate(door,pos3, rot);
        //door.transform.position = pos3;
        //door.transform.localScale = loc;
        //cube3.transform.eulerAngles = new Vector3(cube3.transform.eulerAngles.x+90,cube3.transform.eulerAngles.y,cube3.transform.eulerAngles.z);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
