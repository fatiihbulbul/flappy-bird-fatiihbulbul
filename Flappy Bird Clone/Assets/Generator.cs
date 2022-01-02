using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public float timing = 1;
    private float chronometer = 0;
    public GameObject tube;
    public float height;

    void Start()
    {
        GameObject newtube = Instantiate(tube);
        newtube.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    void Update()
    {
        if (chronometer > timing)
        {
            GameObject newtube = Instantiate(tube);
            newtube.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newtube, 4);
            chronometer = 0;
        }
        chronometer += Time.deltaTime;
    }
}
