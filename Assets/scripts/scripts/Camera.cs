using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float speed;
    public float posi = 1f;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicam = new Vector3(target.position.x + posi, target.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, posicam, speed * Time.deltaTime);
    }
}
