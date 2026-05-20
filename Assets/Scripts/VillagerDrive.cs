using UnityEngine;

// Controla o movemento dun aldeán usando WASD con Rigidbody
public class VillagerDrive : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 120f;

    private Rigidbody rb;
    private float moveInput;
    private float rotateInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Leer input (WASD)
        moveInput = Input.GetAxis("Vertical");
        rotateInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        // Movimiento hacia adelante / atrás
        Vector3 movement = transform.forward * moveInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);

        // Rotación izquierda / derecha
        Quaternion rotation = Quaternion.Euler(0f, rotateInput * rotationSpeed * Time.fixedDeltaTime, 0f);
        rb.MoveRotation(rb.rotation * rotation);
    }
}
