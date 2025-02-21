using UnityEngine;

[ExecuteInEditMode]
public class FaceCamera : MonoBehaviour
{
    public Transform cameraTransform;
    Vector3 targetAngle = Vector3.zero;

    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        transform.LookAt(cameraTransform);
        targetAngle = transform.localEulerAngles;

        targetAngle.x = 270;
        targetAngle.z = 0;
        transform.localEulerAngles = targetAngle;
    }
}
