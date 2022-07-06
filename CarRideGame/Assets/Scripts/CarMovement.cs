using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float carSpeed = 10f;
    [SerializeField] float rotationSpeed = 125f;
    [SerializeField] float horizontalInput;
    [SerializeField] float verticalInput;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * carSpeed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontalInput);

        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
