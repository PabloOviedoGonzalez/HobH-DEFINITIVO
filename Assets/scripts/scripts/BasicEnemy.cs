using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    //private Rigidbody2D rb;
    public float speed;
   // private int countdown = 4;
    Vector2 dir;
    public GameObject target;
    private const string Tag = "Player";
    public Transform ObjectToFollow = null;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.GetComponent<Player>())
        {
            Destroy(other.gameObject);
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        ObjectToFollow = GameObject.FindGameObjectWithTag(Tag).GetComponent<Transform>();// invocoar " Player" 
    }

    // Update is called once per frame
    void Update()
    {
        if (ObjectToFollow == null) //por si no hubiese ningun "Player"
            return;

        transform.position = Vector2.MoveTowards(transform.position, ObjectToFollow.transform.position, speed * Time.deltaTime);
        transform.up = ObjectToFollow.position - transform.position;
    }



    //private void ontriggerenter2d(collider2d col)
    //{
    //    if (col.comparetag("bullet"))
    //    {
    //        if (countdown < 3)
    //        {
    //            destroy(col.gameobject);
    //            destroy(gameobject);
    //        }

    //    }
    //    if (col.comparetag("maincharacter"))
    //    {

    //        destroy(col.gameobject);
    //        scenemanager.loadscene("practica2");

    //    }
    //}
}

