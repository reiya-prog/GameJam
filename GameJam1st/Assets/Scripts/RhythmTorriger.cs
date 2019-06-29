using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhythmTorriger : MonoBehaviour
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
        GameObject go = col_obj.gameObject;
        Rigidbody rigidbody = go.GetComponent<Rigidbody>();
        if(rigidbody.velocity.y < 0){
            if((int)Random.Range(1.0f, 10.0f) > 3)
            {
                RhythmMode rhythmMode = new RhythmMode();
                rhythmMode.startRhythm(go);
            }
        }else{
           // Debug.Log("plus");
        }
    }
}