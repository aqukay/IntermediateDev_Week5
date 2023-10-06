using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventurePlayer : MonoBehaviour
{
    float horizontalMove;
    float verticalMove;
    public float speed = 10f;

    SpriteRenderer myRend;
    Animator myAnim;

    void Start()
    {
        myAnim = GetComponent<Animator>();
        myRend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    } 
}
