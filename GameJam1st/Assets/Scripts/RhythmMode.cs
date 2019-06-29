using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class RhythmMode : MonoBehaviour
{
    static Vector3 leftPos = new Vector3(-0.48f, -3.1f, -0.3f);
    static Vector3 rightPos = new Vector3(0.1f, -3.1f, -0.3f);
    static Vector3 finalPos = new Vector3(-0.23f, -4.2f, -0.3f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public async void startRhythm(GameObject ball)
    {
        Vector3 new_vec = new Vector3(0.0f, 0.0f, 0.0f);
        Rigidbody rigidbody = ball.GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
        rigidbody.velocity = new_vec;
        int times = (int)Random.Range(3.0f, 6.0f);
        Vector3 ballPos = rigidbody.position;
        Vector3 length = new Vector3(0.0f, 0.0f, 0.0f);
        if(Random.Range(0.0f, 1.0f) > 0.5f)
        {
            length = ballPos - rightPos;
            length.x /= (float)times;
            length.y /= (float)times;
            length.z /= (float)times;
        }
        else
        {
            length = ballPos - leftPos;
            length.x /= (float)times;
            length.y /= (float)times;
            length.z /= (float)times;
        }
        Vector3 prevPos = rigidbody.position;
        int flg = 0;
        int delay = (int)Random.Range(500.0f, 1000.0f);
        for(int i=0;i<times;++i){
            if(rigidbody.position != prevPos){
                rigidbody.useGravity = true;
                flg = 1;
                break;
            }
            rigidbody.position -= length;
            prevPos = rigidbody.position;
            await Task.Delay(delay);
            if(rigidbody.position != prevPos){
                rigidbody.useGravity = true;
                flg = 1;
                break;
            }
        }
        if(flg==0) rigidbody.position = finalPos;
        rigidbody.useGravity = true;
    }
}
