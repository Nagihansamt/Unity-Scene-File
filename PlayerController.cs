using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5f;
    float �nputvertical;
    private Rigidbody PlayerRb;
    private GameObject FocalPoint;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        FocalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        �nputvertical = Input.GetAxis("Vertical");
       
       

        PlayerRb.AddForce(FocalPoint.transform.forward *�nputvertical  * speed);
        
    }
}
