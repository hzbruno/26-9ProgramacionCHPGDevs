using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class timer : MonoBehaviour
{
    public float timeR = 10;

    public Image clock;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("points", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeR > 0)
        {
            timeR -= Time.deltaTime;
            float a = timeR / 10;
            clock.fillAmount = a;

        }
        else
        {
            SceneManager.LoadScene(1);

        }


    }
}
