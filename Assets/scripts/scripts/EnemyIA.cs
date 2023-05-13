using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum EnemyState
{
    Wander,
    Follow,
    Fear,
    Die,
};

public class EnemyIA : MonoBehaviour
{
    GameObject Player;
    public EnemyState currState = EnemyState.Wander;
    public Transform target;
    Rigidbody2D myRigidbody;
    public float range = 2f;
    public float moveSpeed = 2f;
    private Animator animator;
    public string boolwalk = "walking";
    public string boolruning = "runing";
    public float currentTime;
    public Vector2 dir;

    public AudioClip wolfMusic;
    [Range(0, 1)]
    public float volumeMusic;


    public float maxTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<PlayerController>().gameObject;
        myRigidbody = GetComponent<Rigidbody2D>();
        //target = Player.GetComponent<Transform>();
        animator = GetComponent<Animator>();
        dir.x = Random.Range(-1, 2);
        dir.y = Random.Range(-1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        switch (currState)
        {
            case (EnemyState.Wander):
                Wander();
                break;
            case (EnemyState.Follow):
                Follow();
                break;
            case (EnemyState.Fear):
                Fear();
                break;
            case (EnemyState.Die):
                Die();
                break;
        }

        if (IsPlayerInRange(range) && currState != EnemyState.Die)
        {
            currState = EnemyState.Follow;
        }
        else if (!IsPlayerInRange(range) && currState != EnemyState.Die)
        {
            currState = EnemyState.Wander;

        }
        else if(!IsPlayerInRange(range) && !IsPlayerLevelMax(range) && currState != EnemyState.Die)
        {
            currState = EnemyState.Fear;
        }
        
       
        if (GameManager.instance.GetEnemyPoints() >= GameManager.instance.IsPlayerLevelMax)
        {
            Enemigo e = GetComponent<Enemigo>();
            if (e.GetHealth() > 2000)
                e.SetHealth(2000);
        }
        else if (GameManager.instance.GetEnemyPoints() >= 1)
        {
            GetComponent<Enemigo>().SetHealth(GetComponent<Enemigo>().GetHealth() / 2);
        }
        
    }
    public bool IsPlayerInRange(float range)
    {
        
        return Vector3.Distance(transform.position, Player.transform.position) <= range; //Devuelve el resultado de si la posicion de range es verdfadera o falso.
       

    }
    private bool IsPlayerLevelMax(float range)
    {
        
        
        return GameManager.instance.GetEnemyPoints() >= 10;
        
    }

    void Wander()
    {
        //Debug.Log("Wander");
        myRigidbody.velocity = dir * moveSpeed;
        currentTime += Time.deltaTime;
        if (currentTime >= maxTime)
        {
            dir.x = Random.Range(-1, 2);
            dir.y = Random.Range(-1, 2);
            currentTime = 0;
        }
        animator.SetBool(boolwalk, true);
        
        transform.localScale = new Vector3(3f, 2.3f, 1f);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        moveSpeed *= -1;
        transform.localScale = new Vector3(-transform.localScale.x, -transform.localScale.y, -transform.localScale.z);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {


        if (other.collider.GetComponent<Player>())
        {



            Destroy(other.gameObject);
            GameManager.instance.ChangeScene("GameOver");
        }


    }
   
    void Fear()
    {
        Vector2 dir = (target.transform.position - transform.position).normalized;
        //Debug.Log(dir);
        Vector2 pos = -dir * range;
        transform.Translate(pos * Time.deltaTime * 2);
        animator.SetBool(boolruning, true);
        transform.localScale = new Vector3(3f, 2.3f, 1f);
    }
    void Follow() 
    {
        //Debug.Log("follow");
        myRigidbody.velocity = new Vector2(0f, 0f);
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed *Time.deltaTime *2);
        animator.SetBool(boolruning, true);
        transform.localScale = new Vector3(-3f, 2.3f, -1f);
        AudioManager.instance.PlayAudio(wolfMusic, volumeMusic);

    }
    
    void Die()
    {
        Destroy(gameObject);
        GameManager.instance.ChangeScene("Victory");
        
    }
    
}

