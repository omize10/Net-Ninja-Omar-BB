using UnityEngine;

public class HoopsVerticalMovement : MonoBehaviour
{
    public float speed = 2.0f;
    private int direction = 1;
    public float maxYHeight = 9.0f;

    void Update()
    {
        // Move the hoops
        transform.Translate(Vector3.up * speed * direction * Time.deltaTime);

        // Check if hoops reach max height and change direction
        if (transform.position.y >= maxYHeight || transform.position.y <= 0)
        {
            direction *= -1;
        }
    }
}
