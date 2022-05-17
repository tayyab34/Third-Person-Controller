using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    public CharacterController controller;
    public Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 Movement = new Vector3(horizontalInput, 0, verticalInput);
        //transform.Translate(Movement * -speed * Time.deltaTime);
        if (Movement.magnitude >= 0.1f)
        {
            float Angle = Mathf.Atan2(Movement.x, Movement.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            transform.rotation = Quaternion.Euler(0, Angle, 0);
            Vector3 movDir = Quaternion.Euler(0, Angle, 0) * Vector3.forward;
            controller.Move(movDir * speed * Time.deltaTime);
        }
    }
}
