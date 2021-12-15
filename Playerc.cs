using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerc : MonoBehaviour
{
    public float limitX;
    public float runingspeed;
    private float _currentrunningspeed;
    public float xspeed;
    void Start()
    {
        _currentrunningspeed = runingspeed;
    }

    // Update is called once per frame
    void Update()
    {
       
        
        float newX = 0;
        float touchXDelta = 0;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            touchXDelta = Input.GetTouch(0).deltaPosition.x / Screen.width;
        }
        else if (Input.GetMouseButton(0))
        {
            touchXDelta = Input.GetAxis("Mouse X");
        }
        newX = transform.position.x + xspeed * touchXDelta * Time.deltaTime;
        newX = Mathf.Clamp(newX, -limitX, limitX);

        Vector3 newPosition = new Vector3(newX, transform.position.y, transform.position.z + _currentrunningspeed * Time.deltaTime);
        transform.position = newPosition;

    }
}
