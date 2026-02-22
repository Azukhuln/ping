using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
   

    Rigidbody2D rb;

    float moveInput = 1f;
    float playerSpeed = 5f;
    //[SerializeField] float baseSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, moveInput * playerSpeed);  
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>().y;
    }
    // add player abilities 
}
