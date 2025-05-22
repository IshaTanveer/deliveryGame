using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 3;
    [SerializeField] float moveSpeed = 0.05f;
    [SerializeField] float slowSpeed = 7f;
    [SerializeField] float fastSpeed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
       float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
       transform.Rotate(0, 0, -steerAmount);
       float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
       transform.Translate(0, moveAmount, 0);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Boost"){
            Debug.Log("Boost");
            moveSpeed = fastSpeed;
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;
    }
}
