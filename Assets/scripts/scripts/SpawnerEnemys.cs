using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemys : MonoBehaviour
{
    
    public GameObject EnemyPrefab;
    float currentTime;
    public float maxTime = 15f;
    public Queue<int> QueueEnemy;
    private int Aux;
    public Vector2 pos;


    public List<string> Enemy = new List<string>();
     


    private void Start()
    {
        QueueEnemy = new Queue<int>();
        QueueEnemy.Enqueue(3);
        QueueEnemy.Enqueue(7);
        QueueEnemy.Enqueue(13);
        QueueEnemy.Enqueue(19);


        SpawnEnemies();

    }

   


    void Update()
    {

        




        currentTime += Time.deltaTime;
        if (currentTime >= maxTime)
        {
            SpawnEnemies();
            currentTime = 0;
            //Debug.Log(Enemy.Capacity);
            //Enemy.Add("Enemy");


            //foreach (string Asteroids in Enemy)
            //{
            //    Debug.Log(Asteroids);
            //}

        }


    }

    void SpawnEnemies() {
        Aux = QueueEnemy.Count <= 0 ? Aux : QueueEnemy.Dequeue();

        for(int i = 0; i < Aux; i++)
        {
            Instantiate(EnemyPrefab, new Vector2(Random.Range(-35, 35), Random.Range(33, 0)), Quaternion.identity);

        }
    }
}
