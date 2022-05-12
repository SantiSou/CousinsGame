using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player_Move : NetworkBehaviour
{
    private Rigidbody2D rig;
    public float speedX;
    public float speedY;
    public bool moving;
    public float directionX;
    public float directionY;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (directionX != -1 && speedX > 0)
            {
                speedX -= Time.deltaTime;
            }
            else
            {
                directionX = -1;
                speedX += Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (directionX != 1 && speedX > 0)
            {
                speedX -= Time.deltaTime;
            }
            else
            {
                directionX = 1;
                speedX += Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            if (directionY != 1 && speedY > 0)
            {
                speedY -= Time.deltaTime;
            }
            else
            {
                directionY = 1;
                speedY += Time.deltaTime;
            }

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (directionY != -1 && speedY > 0)
            {
                speedY -= Time.deltaTime;
            }
            else
            {
                directionY = -1;
                speedY += Time.deltaTime;
            }
        }

        transform.position = new Vector3(speedX * directionX, speedY * directionY, 0f);
    }
}
