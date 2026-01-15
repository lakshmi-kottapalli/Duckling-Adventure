using UnityEngine;

public class DuckController : MonoBehaviour
{
    public float moveSpeed = 5f;    // faster forward movement
    public float turnSpeed = 60f;   // slower turning

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    void FixedUpdate()
    {
        // turning
        float turnInput = 0f;
        if (Input.GetKey(KeyCode.LeftArrow))
            turnInput = -1f;
        if (Input.GetKey(KeyCode.RightArrow))
            turnInput = 1f;

        // apply slower turn
        float turnAmount = turnInput * turnSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turnAmount, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);  // smoother, slower turn

        // forward movement
        if (Input.GetKey(KeyCode.UpArrow))
        {
           // Vector3 forwardMovement = transform.TransformDirection(Vector3.forward) * moveSpeed * Time.fixedDeltaTime;

            Vector3 forwardMovement = transform.forward * moveSpeed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + forwardMovement);
        }

        //back movement
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 backwardMovement = -transform.forward * (moveSpeed / 2) * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + backwardMovement);
        }
    }
}
