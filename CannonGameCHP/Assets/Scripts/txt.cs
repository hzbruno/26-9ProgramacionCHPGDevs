using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class txt : MonoBehaviour
{
    public Text txt2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int a = PlayerPrefs.GetInt("points");
        string b = ""+a;
        txt2.text = b;
    }
}
