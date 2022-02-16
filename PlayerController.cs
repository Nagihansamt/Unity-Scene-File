using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5f;
    float ýnputvertical;
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
        ýnputvertical = Input.GetAxis("Vertical");
       
       

        PlayerRb.AddForce(FocalPoint.transform.forward *ýnputvertical  * speed);
        
    }
}
