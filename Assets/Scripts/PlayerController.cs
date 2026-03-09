using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed ;
    public float horizontalSpeed;
    public float forwardInput;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalSpeed = Input.GetAxis("Horizontal") ;
        forwardInput = Input.GetAxis("Vertical") ;


        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput * 5);
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalSpeed * turnSpeed);
    }
}
