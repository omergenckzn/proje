using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComeAndGo : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 firstPosition;
    [SerializeField] Vector3 movementVector;
    [SerializeField][Range(0, 1)] float movementFactor;
    [SerializeField] float period = 2f;

    void Start()
    {
        firstPosition = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {

        float cycles = Time.time / period;
        const float tau = Mathf.PI * 2;
        float rawSineWave = Mathf.Sin(cycles * tau);

        movementFactor = (rawSineWave + 1f) / 2f ;

        Vector3 offset = movementVector * movementFactor;

        transform.position = firstPosition + offset;
        
    }
}
