//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CameraController : MonoBehaviour
//{
//    public Transform target, player;
//    private float mouse_X;
//    private float mouse_Y;

//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void LateUpdate()
//    {
//        mouse_X = Input.GetAxis("Mouse X") * 10;
//        mouse_Y = Input.GetAxis("Mouse Y") * 10;
//        transform.LookAt(target);

//        target.rotation = Quaternion.Euler(mouse_Y, mouse_X, 0);
//        player.rotation = Quaternion.Euler(0, mouse_X, 0);

//    }
//}
