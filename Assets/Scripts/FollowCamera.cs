using UnityEngine;

class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject Rocky;
    // position of the camera should be the same as the position of the car
    void LateUpdate()
    {
        transform.position = Rocky.transform.position + new Vector3(0,0,-10);
    }
}
