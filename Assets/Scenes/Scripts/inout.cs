using UnityEngine;
using System.Collections;

public class inout : MonoBehaviour
{
    private Camera cam;
    private GameObject ball;


    void Start()
    {
        cam = Camera.main;
        if (cam == null)
        {
            Debug.LogError("No Camera component found.");
            return;
        }

        ball = GameObject.FindGameObjectWithTag("ball");
        if (ball == null)
        {
            Debug.LogError("No GameObject with tag 'ball' found.");
            return;
        }
    }

    public void ZoomInAndOut(float zoomAmount, float zoomSpeed)
    {
        StartCoroutine(ZoomCoroutine(ball, zoomAmount, zoomSpeed));
    }

    private IEnumerator ZoomCoroutine(GameObject target, float zoomAmount, float zoomSpeed)
    {
        Debug.Log("WORKING");
        float originalFOV = cam.fieldOfView;
        Vector3 originalPosition = cam.transform.position;

        // Zoom In
        while (Mathf.Abs(cam.fieldOfView - zoomAmount) > 0.1f)
        {
            cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, zoomAmount, zoomSpeed * Time.deltaTime);
            cam.transform.position = Vector3.Lerp(cam.transform.position, target.transform.position - cam.transform.forward * 5, zoomSpeed * Time.deltaTime);
            yield return null;
        }

        cam.fieldOfView = zoomAmount;

        // Pause for a moment
        yield return new WaitForSeconds(0.5f);

        // Zoom Out
        while (Mathf.Abs(cam.fieldOfView - originalFOV) > 0.1f)
        {
            cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, originalFOV, zoomSpeed * Time.deltaTime);
            cam.transform.position = Vector3.Lerp(cam.transform.position, originalPosition, zoomSpeed * Time.deltaTime);
            yield return null;
        }

        cam.fieldOfView = originalFOV;
    }
}
