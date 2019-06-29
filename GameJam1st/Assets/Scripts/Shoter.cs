using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoter : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(BallInfo.GetIsBallOn()){
            if(Input.GetMouseButtonDown(0))
            {
                BallInfo.SetIsBallOn(false);
                Vector3 ball_vec = new Vector3(
                    0.0f,
                    Random.Range(10.0f, 13.0f),
                    0.0f
                );
                Rigidbody rigidbody = ball.GetComponent<Rigidbody>();
                rigidbody.velocity = ball_vec;
            }
        }
    }
}
