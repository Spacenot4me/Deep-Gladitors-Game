using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    private float horizontalInput;
    private float verticalInput;
    private Vector2 mousePos;
    
    private Rigidbody2D rb2d;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private float fireRate = 1f;
    private float fireTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
        
        // transform.Translate(Vector3.right * (horizontalInput * speed * Time.deltaTime));
        // transform.Translate(Vector3.up * (verticalInput * speed * Time.deltaTime));
        
        rb2d.linearVelocity = new Vector2(horizontalInput, verticalInput).normalized * speed;

        if (Input.GetMouseButton(0) && fireTimer<=0f)
        {
            Shoot();
            fireTimer = fireRate;
        }
        else
        {
            fireTimer -= Time.deltaTime;
        }
        
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
    }
    
}
