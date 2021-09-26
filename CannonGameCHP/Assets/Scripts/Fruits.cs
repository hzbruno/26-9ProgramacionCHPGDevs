using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruits : MonoBehaviour
{
     
    string b;

    private void Start()
    {
        
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            int a = PlayerPrefs.GetInt("points");
            a += 10;
            PlayerPrefs.SetInt("points", a);
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "floor" )
        {

            Destroy(this.gameObject);
        }

        
    }
}
