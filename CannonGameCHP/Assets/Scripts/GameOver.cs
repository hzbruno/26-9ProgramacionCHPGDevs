using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public float timeR = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(timeR>0)timeR -= Time.deltaTime;

        if (timeR < 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
