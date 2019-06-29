using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSpeedUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnCollisionStay(Collision col_obj)
    {
        GameObject o = col_obj.gameObject;
        Vector3 ball_vec = new Vector3(
            1.5f,
            -0.8f,
            0f
        );
        Rigidbody rigidbody = o.GetComponent<Rigidbody>();
        rigidbody.velocity = ball_vec;
    }
}
