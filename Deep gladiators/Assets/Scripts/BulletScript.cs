using UnityEngine;

public class BulletScript : MonoBehaviour
{

    [SerializeField] private float strenght = 1000f;
    private Rigidbody2D rb2d;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
        Destroy(gameObject, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.AddForce(transform.up * strenght * Time.deltaTime, ForceMode2D.Impulse);
    }
}
