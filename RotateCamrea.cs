using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamrea : MonoBehaviour
{
   
    public float RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        float �nputHorizontal = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up,�nputHorizontal*RotationSpeed*Time.deltaTime);
    }
}
