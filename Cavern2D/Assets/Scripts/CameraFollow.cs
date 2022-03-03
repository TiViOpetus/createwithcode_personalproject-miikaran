using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;
    [Range(1, 500)]
    public float smoothCamera;

    private void FixedUpdate()
    {
        camFollow();
    }


    //Adds delay to camera movement.

    void camFollow()
    {
        Vector3 targetPosition = target.position + offset;

        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothCamera * Time.fixedDeltaTime);

        transform.position = smoothPosition;
    }

}

