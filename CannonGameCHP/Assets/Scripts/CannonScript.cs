using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{

    public float y;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

         y = this.gameObject.transform.localRotation.z;
        if (Input.GetKeyDown(KeyCode.W) && y < 0.7f && y >= -0.1f)
        {
            this.gameObject.transform.Rotate(0.0f,0.0f,5.0f);
            Debug.Log(1);
        }

        if (Input.GetKeyDown(KeyCode.S) && y < 0.8f && y >= 0.0f)
        {
            this.gameObject.transform.Rotate(0.0f, 0.0f, -5.0f);
            Debug.Log(1);
        }
    }
}
