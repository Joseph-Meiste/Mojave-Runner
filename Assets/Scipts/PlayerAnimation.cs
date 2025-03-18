using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(Player))]
    [RequireComponent(typeof(Rigidbody2D))]
public class PlayerAnimation : MonoBehaviour
{
    Animator animator;
    Player player;
    Rigidbody2D rigidbody2D;

    public GameObject particlePrefab;
    void Start()
    {
        animator = GetComponent<Animator>(); ;
        player = GetComponent<Player>();   
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Falling", player.isFalling);
        animator.SetFloat("YVelocity", rigidbody2D.velocity.y);
    }

    public void Smoke()
    {
        Instantiate(particlePrefab, transform.position, Quaternion.identity);
    }
}
