using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalCameraScript : MonoBehaviour
{
    public Transform player;
    public Transform pointB;


    // Update is called once per frame
    void Update()
    {
        float angleDegrees = Mathf.Atan2(gameObject.transform.position.z - player.position.z, gameObject.transform.position.x - player.position.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x,angleDegrees,transform.eulerAngles.z);
    }

}
