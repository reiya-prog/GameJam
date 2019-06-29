using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSpeed : MonoBehaviour
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
        GameObject go = col_obj.gameObject;
        Vector3 ball_vec = new Vector3(
            0.0f,
            10.0f,
            0.0f
        );
        Rigidbody rigidbody = go.GetComponent<Rigidbody>();
        rigidbody.velocity = ball_vec;
    }
}
