using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    Vector2 interpolation;
    public GameObject[] target;
    public float delay;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector2.Lerp(gameObject.transform.position, interpolation, delay*Time.deltaTime);
        gameObject.transform.position += new Vector3(0, 0, -14);
        interpolation.x = Mathf.Lerp(target[1].transform.position.x, target[0].transform.position.x, 0.5f);
        interpolation.y = Mathf.Lerp(target[1].transform.position.y, target[0].transform.position.y, 0.5f);
    }
}
