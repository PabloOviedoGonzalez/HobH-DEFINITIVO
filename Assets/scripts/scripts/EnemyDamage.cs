using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private float damage2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().GetDamage(damage);
            other.GetComponent<PlayerHealth>().GetDamage2(damage2);
            Vector2 enemyDir = -(transform.position - other.transform.position).normalized;
            other.GetComponent<Rigidbody2D>().AddForce(enemyDir*500);
            StartCoroutine(DeactivatePlayerController(other.gameObject));
        }
    }

    IEnumerator DeactivatePlayerController(GameObject player)
    {
        player.GetComponent<PlayerController>().enabled = false;
        yield return new WaitForSeconds(1);
        player.GetComponent<PlayerController>().enabled = true;
    }

}
