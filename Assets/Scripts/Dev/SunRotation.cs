using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotation : MonoBehaviour
{

    private GameObject Sun;

    [SerializeField]
    private float rotationSpeed = 100f;

    private Vector3 mouseRotation;
    private bool bRotating;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKey(KeyCode.L))
        {
            bRotating = true;
        }
        else
        {
            bRotating = false;
        }


        if (bRotating)
        {
            RotateSun();
        }
        
    }

    private void RotateSun()
    {
        mouseRotation = new Vector3(Input.GetAxis("Mouse Y"),
            Input.GetAxis("Mouse X"),
            0f);

        transform.Rotate(mouseRotation * rotationSpeed * Time.deltaTime);
        
    }
}
