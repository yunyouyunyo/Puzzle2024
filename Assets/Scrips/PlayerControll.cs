using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;


public class PlayerControll : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    public int hp;
    public int hp_max = 10;
    public Image hp_bar;
    public GameObject BulletPrefab;
    public Animator animator;

    void Start()
    {
        print("start");
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed",Math.Abs(horizontalMove));
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(BulletPrefab, this.transform.position, Quaternion.identity);
        }//Fire1:left ctrl
        if (hp_bar.transform.localScale.x > 0)
        {
            hp_bar.transform.localScale = new Vector3((float)hp / (float)hp_max, hp_bar.transform.localScale.y, hp_bar.transform.localScale.z);
        }

    }
    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Portal")
        {
            coll.gameObject.transform.GetComponent<Portal>().ChangeScene();
        }


    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Monster")
        {
            print(coll.gameObject.name);
            hp -= 1;
        };

    }

}
