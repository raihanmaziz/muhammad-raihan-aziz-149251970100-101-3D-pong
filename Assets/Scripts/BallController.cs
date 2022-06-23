using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    private Rigidbody rig;
    public Vector3 resetPosition;
    
    // Start is called before the first frame update
    public void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void ResetBall()
    {
        transform.position = resetPosition;
    }
}
