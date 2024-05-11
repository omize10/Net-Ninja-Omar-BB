using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragController : MonoBehaviour
{

    public LineRenderer line;
    public Rigidbody2D rb;

    public float dragLimit = 3f;
    public float forceToAdd = 10f;

    private Camera cam;
    private bool isDragging;
    
    Vector3 MousePosition
    {
        get
        {
            Vector3 pos = cam.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0f;
            return pos;
        }
    }


    private void Start()
    {
        cam = Camera.main;
        line.positionCount = 2;
        line.SetPosition(0, Vector2.zero);
        line.SetPosition(1, Vector2.zero);
        line.enabled = false;
        //GameObject ball =  GameObject.FindGameObjectWithTag("ball");
       // rb = ball.GetComponent<Rigidbody2D>();

    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDragging)
        {
            DragStart();
        }

        if (isDragging)
        {
            Drag();
        }

        if(Input.GetMouseButtonUp(0) && isDragging)
        {
            DragEnd();
        }
    }

    void DragStart()
    {
        line.enabled = true;
        isDragging = true;
        line.SetPosition(0, MousePosition);
    }

    void Drag()
    {
        Vector3 startpos = line.GetPosition(0);
        Vector3 currentPos = MousePosition;

        Vector3 distance = currentPos - startpos;

        

        if (distance.magnitude <= dragLimit)
        {
            line.SetPosition(1, currentPos);
        }
        else
        {
            Vector3 limitVector = startpos + (distance.normalized * dragLimit);
            line.SetPosition(1, limitVector);
        }
    }
    
    private void DragEnd()
    {
        isDragging = false;
        line.enabled = false;

        Vector3 startpos = line.GetPosition(0);
        Vector3 currentPos = line.GetPosition(1);

        Vector3 distance = currentPos - startpos;
        Vector3 finalForce = distance * forceToAdd;


        rb.AddForce(-finalForce, ForceMode2D.Impulse);
    }
}

