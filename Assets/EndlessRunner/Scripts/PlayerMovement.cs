using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horisontalMove;

    public Joystick Joystick;
    private void Update()
    {
         horisontalMove = Joystick.Horizontal * 5;
    } 


}
