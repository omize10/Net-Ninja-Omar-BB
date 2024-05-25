using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopsMovement : MonoBehaviour
{

    public float speed = 2.0f;
    private int direction = 1;
    public float moveAmmount = 2.0f;



    void Start()
    {
        
    }

void Update() {

    transform.Translate(Vector3.right * speed * direction * Time.deltaTime);


    if (transform.position.x >= moveAmmount || transform.position.x <= -moveAmmount) {
        direction *= -1;
    }
}

}
