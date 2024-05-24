using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopsMovement : MonoBehaviour
{

    public float speed = 2.0f;
    private int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

void Update() {
    // Move the hoops
    transform.Translate(Vector3.right * speed * direction * Time.deltaTime);

    // Check if hoops reach screen edges and change direction
    if (transform.position.x >= 4.0f || transform.position.x <= -4.0f) {
        direction *= -1;
    }
}

}
