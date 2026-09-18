using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clown : AnimatedEntity
{
    public float speed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        base.AnimationSetup();
    }

    // Update is called once per frame
    void Update()
    {
        base.AnimationUpdate();

        if(Input.GetKey(KeyCode.D)){
            Move(Vector3.right);
        }
        if(Input.GetKey(KeyCode.A)){
            Move(Vector3.left);
        }
        if(Input.GetKey(KeyCode.W)){
            Move(Vector3.up);
        }
        if(Input.GetKey(KeyCode.S)){
            Move(Vector3.down);
        }
    }

    void Move (Vector3 direction){
        transform.position += direction*Time.deltaTime*speed;
    }
}
