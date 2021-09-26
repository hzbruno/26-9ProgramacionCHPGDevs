using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector3 jump;
    


    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        
        GetComponent<Rigidbody2D>().AddForce(jump, ForceMode2D.Impulse);


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="floor")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Fruit")
        {
            Destroy(this.gameObject);
        }
    }

}