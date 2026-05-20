using UnityEngine;

// Move o porco cara ao obxecto goal usando Rigidbody
public class PigMove : MonoBehaviour
{
    public GameObject goal;
    public float speed = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 direction = goal.transform.position - rb.position;

        if (direction.magnitude > 2f)
        {
            Vector3 movement = direction.normalized * speed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + movement);

            // Rotar cara ao obxectivo
            Quaternion rotation = Quaternion.LookRotation(direction);
            rb.MoveRotation(rotation);
        }
    }
}
