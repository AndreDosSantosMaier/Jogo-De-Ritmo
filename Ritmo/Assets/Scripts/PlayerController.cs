using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 moveInput;
    public Transform Player;
    public static float moveSpeed = 5;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMove();
    }
    void playerMove() //comando de movimentação de personagem
    {
        moveInput.x = Input.GetAxis("Horizontal");  
        moveInput.y = Input.GetAxis("Vertical");
        transform.Translate(moveInput * Time.deltaTime * moveSpeed);
        anim.SetBool("Move",(Mathf.Abs(moveInput.x) >0 || Mathf.Abs(moveInput.y) > 0)); //ativa animção de andar
    }

}
