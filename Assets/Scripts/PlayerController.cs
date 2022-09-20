using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speedModifier;
    private float force;
    private float maxSpeed;

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speedModifier = 100.5f;
        maxSpeed = 100f;
        force = 50f;
        rb.AddForce(new Vector3(0, 0, force));
    }

    // Update is called once per frame
    void Update()
    {

        //rb.AddForce(new Vector3 (0, 0, 200f * Time.deltaTime));
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);


            if (touch.phase == TouchPhase.Moved)
            {
                /*transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedModifier,
                    transform.position.y,
                    transform.position.z + touch.deltaPosition.y * speedModifier);*/
                rb.velocity = Vector3.ClampMagnitude(new Vector3(touch.deltaPosition.x, 0, touch.deltaPosition.y), maxSpeed);
                
            }
        }


    }
}
