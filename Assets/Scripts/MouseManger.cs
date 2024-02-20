using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManger : MonoBehaviour
{

    private Vector2 OGposs;
    private Quaternion Rot;
    public Transform ballTrasfrom;
    public Rigidbody ballRigidbody;
    public Vector2 clickStartLocation;
    public Vector2 launchVector;
    public float launchForce;
    void Start()
    {
        OGposs = ballTrasfrom.position;
        Rot = ballTrasfrom.rotation;
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            clickStartLocation = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector2 MouseP = Input.mousePosition;
            Vector2 mouseDifference = clickStartLocation - MouseP;
            launchVector = new Vector2(
                mouseDifference.x * 1f,
                mouseDifference.y * 1.2f
                );
            //ballTrasfrom.position = orignalballPostion - launchVector / 400;
            //launchVector.Normalize;
        }

        if (Input.GetMouseButtonUp(0))
        {

            print("Release!");
            ballRigidbody.isKinematic = false;
            ballRigidbody.AddForce(launchVector * launchForce);
        }
        if (Input.GetMouseButtonDown(1))
        {
            ballRigidbody.isKinematic = false;
            ballRigidbody.position = OGposs;
            ballTrasfrom.rotation = Rot;


        }
    }
}
