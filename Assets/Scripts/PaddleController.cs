using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    public bool isHorizontal;

    private Rigidbody rig;

    // Start is called before the first frame update
    public void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void Update()
    {
        MoveObject(GetInput());
    }

    private Vector3 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            if (isHorizontal)
            {
                return Vector3.right * speed;
            }
            else
            {
                return Vector3.forward * speed;
            }
        }
        else if (Input.GetKey(downKey))
        {
            if (isHorizontal)
            {
                return Vector3.left * speed;
            }
            else
            {
                return Vector3.back * speed;
            }
        }

        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {
        transform.Translate(movement * Time.deltaTime);
    }
}
