using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotateAmp;

    [SerializeField] float mainThrust;
    private Rigidbody playerRb;
    private float rotateInput;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rotateInput = Input.GetAxis("Horizontal");
        ProcessInput();
        ProcessRotation(rotateInput);
    }

    void ProcessInput()
    {
        if (Input.GetKey("space"))
        {
            playerRb.AddRelativeForce(Vector3.up * Time.deltaTime * mainThrust);
            Debug.Log("Pressed SPACE - Thrusting");
        }
    }

    void ProcessRotation(float rotationThrust)
    {
        // playerRb.freezeRotation = true;
        transform.Rotate(new Vector3(0, 0, -rotationThrust) * rotateAmp);
    }
}
