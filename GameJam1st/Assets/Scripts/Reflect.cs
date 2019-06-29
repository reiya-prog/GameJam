using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider col_obj)
    {
        GameObject o = col_obj.gameObject;
        Vector3 ball_vec = new Vector3(
            0.0f,
            Random.Range(3.0f, 8.0f),
            0.0f
        );
        Rigidbody rigidbody = o.GetComponent<Rigidbody>();
        rigidbody.velocity = ball_vec;
    }
}
