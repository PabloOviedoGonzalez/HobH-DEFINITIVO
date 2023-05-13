using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class Bala : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float damage;
    //public Queue<Sprite> QueueWeapons;
    float currentTime;
    private float maxTime = 4f;
    // Start is called before the first frame update
    void Start()
    {
        //QueueWeapons = new Queue<Sprite>();
        //QueueWeapons.Enqueue(sprite) ;

        if (GameManager.instance.GetEnemyPoints() >= 100)
        {
            damage *= 2;
        }
        if (GameManager.instance.GetEnemyPoints() >= 1)
        {
            damage *= 4;
        }
        if (GameManager.instance.GetEnemyPoints() >= GameManager.instance.IsPlayerLevelMax)
        {
            damage *= 8;
        }
    }

    // Update is called once per frame
   private void Update()
    {
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);
       
        currentTime += Time.deltaTime;
        if (currentTime >= maxTime)
        {
            Destroy(gameObject);
            currentTime = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if( other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemigo>().TomarDamage(damage);
            Destroy(gameObject);
        }
        


    }
}
