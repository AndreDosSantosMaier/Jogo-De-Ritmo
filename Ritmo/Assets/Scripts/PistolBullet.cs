using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolBullet : MonoBehaviour
{
    public float shotSpeed;
    private float bulletRange = Gun.PistolbulletRange; //variavel de range da arma retirada do script "Pistol" 
    
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * shotSpeed); //faz o tiro andar sempre na direção do cano da arma
        
        Destroy(gameObject, bulletRange); //faz a tiro sumir depois de meio segundo para limitar o range da arma
    }
    private void OnTriggerEnter2D(Collider2D collision) //função que sera ativada sempre que o tiro colidir com um objeto que possua rigiBody
    {
        if (collision.CompareTag("Enemy")|| collision.CompareTag("Obstacle")) //se acertar um inimigo ou obstaculo...
        Destroy(gameObject); //destroi o tiro
    }
}
