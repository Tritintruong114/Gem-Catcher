using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 5.0f;
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float moveHorizontal = horizontalInput * speed * Time.deltaTime;
        transform.position = new Vector2(transform.position.x + moveHorizontal,transform.position.y);
    }
}
