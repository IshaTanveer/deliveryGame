using UnityEngine;

public class Collision : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    SpriteRenderer spriteRenderer;
    [SerializeField] float destroyDelay = 0.5f;
    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // we are not gonna need start or update here
    // this is to find out when the car collides into something
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("oh no!!!!!!");
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Package" && !hasPackage){
            Debug.Log("Package picked!!");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor;
        }
        else if(other.tag == "Customer" && hasPackage){
            Debug.Log("Package dropped!!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
