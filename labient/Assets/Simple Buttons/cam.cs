using UnityEngine;

public class cam : MonoBehaviour {

    public Transform target;

    public float smoothSpeed = 12.5f;
    public Vector3 offset;

    void LateUpdate ()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }

}