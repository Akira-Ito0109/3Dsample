using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed=1.0f;
    private float movementInputValueZ;
    private float movementInputValueX;
    private Rigidbody rb;

    public void PlayerMove()
    {
        movementInputValueZ = Input.GetAxis("Vertical");
        movementInputValueX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(movementInputValueX, 0, movementInputValueZ)*moveSpeed;

    }
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }
}
