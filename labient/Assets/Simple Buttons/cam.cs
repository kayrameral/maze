using UnityEngine;

public class cam : MonoBehaviour {

    public Transform target;
    private float speed = 40f;
    public float smoothSpeed = 12.5f;
    public Vector3 offset;

    void LateUpdate ()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        transform.LookAt(target);
        if (Input.GetKey(KeyCode.Q))
        {
            transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);
            offset = transform.position - target.position;
        }

        if (Input.GetKey(KeyCode.E)){
                transform.RotateAround(target.position, Vector3.up, -1 * speed * Time.deltaTime);
            offset = transform.position - target.position;
        }
    }

}
