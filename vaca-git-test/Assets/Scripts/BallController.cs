using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // 球のスピード
    public float speed = 10;

    private void Start()
    {
        // 力の制御
        var force = (transform.forward + transform.right) * speed;
        GetComponent<Rigidbody>().AddForce(force, ForceMode.VelocityChange);
    }
}
