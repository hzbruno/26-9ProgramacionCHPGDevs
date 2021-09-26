using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsInstantiate : MonoBehaviour
{
    public Transform prefab;
    int TimeNeed;
    public float Times=0;

    // Start is called before the first frame update
    void Start()
    {
        TimeNeed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Times += Time.deltaTime;
        
        if ((int)Times ==TimeNeed)
        {
            Instantiate(prefab, this.transform.position, Quaternion.identity);
            TimeNeed += 1;
        }

    }
}
