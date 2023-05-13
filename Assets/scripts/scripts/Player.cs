using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode LeftArrow, RightArrow, UpArrow, DownArrow, Space, LeftShift; //cambiar las teclas desde el editor
    public float speed = 10;
    public SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    //private Animator animator;
    public string Boolwalk = "walking";
    public string Boolruning = "runing";
    private int Health;
    public float shootRate = 0.5f;
    public GameObject bulletPrefab;
    public Transform bulletSpawner;
    private bool canShoot = true;
    private bool shooting;

   




    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // accion teclas wasd ( arriba abajo izq drch + sollucion framerate)
        {
            float auxiliarspeed = speed;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                auxiliarspeed *= 2;
                //animator.SetBool(Boolruning, true);
                //animator.SetBool(Boolruning, false);
            }
            //else
            {
                //animator.SetBool(Boolruning, false);
                //animator.SetBool(Boolruning, true);

            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.velocity = new Vector3(-auxiliarspeed, rb.velocity.y, 0);
                //animator.SetBool(Boolwalk, true);
                transform.localScale = new Vector3(-3f, 2.3f, 1f);
            }
           else if (Input.GetKey(KeyCode.D))
            {
                rb.velocity = new Vector3(auxiliarspeed, rb.velocity.y, 0);
                //animator.SetBool(Boolwalk, true);
                transform.localScale = new Vector3(3f, 2.3f, 1f);

            }
            else
            {
            

            }
           if (Input.GetKey(KeyCode.W))
            {
                rb.velocity = new Vector3(rb.velocity.x, auxiliarspeed, 0);
                //animator.SetBool(Boolwalk, true);
                transform.localScale = new Vector3(-3f, 2.3f, 1f);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                rb.velocity = new Vector3(rb.velocity.x, -auxiliarspeed, 0);
                //animator.SetBool(Boolwalk, true);
                transform.localScale = new Vector3(3f, -2.3f, 1f);

            }
            shooting = ShootManager.Fire;
            Shoot();
            //Level 
            if (GameManager.instance.GetEnemyPoints() >= 1)
                Debug.Log("Level1");
            {
               Health *= 2;
            }
            if (GameManager.instance.GetEnemyPoints() >= GameManager.instance.IsPlayerLevelMax)
            {
                Debug.Log("Lavel MAx");
                Health = 2000;
            }

        }
    }
    private void Shoot()
    {
        
        if (shooting && canShoot)
        {
            StartCoroutine(FireRate());
             
        }
    }

   
    private IEnumerator FireRate()
    {
        canShoot = false;
        var bullet = Instantiate(
            bulletPrefab,
            bulletSpawner.position,
            bulletSpawner.rotation);
        Destroy(bullet, 5);
        yield return new WaitForSeconds(shootRate);
        canShoot = true;
    }
    
}

