using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounders : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-21f,21f),
                Mathf.Clamp(transform.position.y,-7f,7f) , transform.position.z);
        
    }
}