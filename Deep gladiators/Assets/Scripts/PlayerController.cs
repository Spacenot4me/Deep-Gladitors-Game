using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    private float horizontalInput;
    private float verticalInput;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.right * (horizontalInput * speed * Time.deltaTime));
        transform.Translate(Vector3.up * (verticalInput * speed * Time.deltaTime));
    }
}
