using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class Boss1 : MonoBehaviour
{
    public int Hp;
    public int MaxHp = 100;
    public HealthBar healthBar;
    GameObject player;
    public float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        Hp = MaxHp;
        healthBar.SetMaxHealth(MaxHp);
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        findPlayer();
    }


    void TakeDamage (int damage)
    {
        Hp -= damage;
        healthBar.SetHealth(Hp);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            TakeDamage(1);
        }
    }
    private void findPlayer()
    {
        if (player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed* Time.deltaTime);
        }
    }
}
