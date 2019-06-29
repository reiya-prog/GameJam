using UnityEngine;
using System.Collections;

public class LeftFlipper : MonoBehaviour {

    public float spring = 40000;
    public float damper = 1000;
    public float openAngle = 45;
    public float closeAngle = -60;

    private HingeJoint hj;
    private Rigidbody rb;

    void Start () {
        hj = gameObject.GetComponent<HingeJoint>();
        hj.useSpring = true;
        rb = gameObject.GetComponent<Rigidbody>();
        rb.useGravity = false;
        closeFlipper ();
    }

    void Update () {

        if (Input.GetKey("a")) {
            openFlipper();
        }
        if (!Input.GetKey("a")) {
            closeFlipper();
        }

    }

    public void openFlipper(){
        JointSpring spr = hj.spring;
        spr.spring = spring;
        spr.damper = damper;
        spr.targetPosition = openAngle;
        hj.spring = spr;
    }

    public void closeFlipper(){
        JointSpring spr = hj.spring;
        spr.spring = spring;
        spr.damper = damper;
        spr.targetPosition = closeAngle;
        hj.spring = spr;
    }

}