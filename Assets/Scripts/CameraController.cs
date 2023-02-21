using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // This is what the camera follows.
    public float smoothSpeed = 10f; // The higher this value is, the faster the camera will lock onto target; the smaller it is, the slower it will be.
    public Vector3 offset; // To be able to offset camera on all 3 axes.

    void FixedUpdate() 
    {
        Vector3 desiredPosition = target.position + offset; // This adds two Vector3s to get the desired position: target position axis plus offset axis.
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, (smoothSpeed * Time.fixedDeltaTime)); // Lerp stands for linear interpolation, the process of smoothly going from a position A to a position B.
        // This method takes the current position (the starting point) and then takes the desired position (the end point), and then takes a float t (smoothSpeed).
        // SmoothSpeed multiplied by Time.fixedDeltaTime to make the smoothing occur at the same speed no matter the frame rate.

        transform.position = smoothedPosition;
    }
}