using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyControll : MonoBehaviour
{
    public GameObject Camera;

    float Xinput;
    float Yinput;

    public float ForwardSpeed;
    public float StrafeSpeed;
    public float BackPedalSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        YrotationCopy();
        Movement();
    }

    void YrotationCopy()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, Camera.transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
    }

    void Movement()
    {
        Xinput = Input.GetAxisRaw("Horizontal");
        Yinput = Input.GetAxisRaw("Vertical");

        if(Yinput != 0)
        {

            if(Yinput > 0)
            {
                GetComponent<Rigidbody>().velocity = transform.forward * ForwardSpeed;
            }
            else
            {
                GetComponent<Rigidbody>().velocity = -transform.forward * BackPedalSpeed;
            }
       
        }
    }
}
