using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public  float angle = 90f;
    public Vector3 offset = new Vector3(-20, 4, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(Vector3.up, angle);
    }

    // Update is called once per frame
    void Update()
    {
      
        transform.position = plane.transform.position + offset;
        
    }
}
