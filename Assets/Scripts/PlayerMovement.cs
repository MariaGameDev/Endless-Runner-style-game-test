using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]float playerSpeed = 10;
    Rigidbody2D rb;
    Vector2 playerDirection;
    bool isScrolled;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float dirY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, dirY).normalized;
        ReadDrag();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }

    private void ReadDrag()
    {
        if (!isScrolled && (Input.GetAxis("Mouse ScrollWheel") < 0))
        {
            playerDirection = new Vector2(0, 1).normalized;
        }
        else if (!isScrolled && (Input.GetAxis("Mouse ScrollWheel") > 0))
        {
            playerDirection = new Vector2(0, -1).normalized;
        }
    }
}
