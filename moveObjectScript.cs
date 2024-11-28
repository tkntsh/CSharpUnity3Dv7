using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObjectScript : MonoBehaviour
{
    //rigidbody component
    [SerializeField] private Rigidbody rigi_controller;
    //joystick ui element used for input
    [SerializeField] private FixedJoystick joystick_controller;
    //[SerializeField] private Animator anim_controller;
    //speed gameobject moves
    [SerializeField] private float move_speed;


    void Start()
    {
        
    }

    //method called at fixed time intervals (used to perform physics calculations)
    private void FixedUpdate()
    {
        //control the movement of the   3D object
        rigi_controller.velocity = new Vector3(joystick_controller.Horizontal * move_speed, rigi_controller.velocity.y, joystick_controller.Vertical * move_speed);
        //checks if horizontal or veritcal input of joystick is = 0 (joystick is not being used)
        if (joystick_controller.Horizontal != 0 || joystick_controller.Vertical != 0)
        {
            //rotation of gameobject
            transform.rotation = Quaternion.LookRotation(rigi_controller.velocity);
        }
    }
    /*
    void Update()
    {

    }*/
}
