using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventurePlayer : MonoBehaviour
{
    float moveSpeed = 3f;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("running_up", true);

            newPos.y += Time.deltaTime * moveSpeed;
        }
        else
        {
            anim.SetBool("running_up", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("running_down", true);

            newPos.y -= Time.deltaTime * moveSpeed;
        }
        else
        {
            anim.SetBool("running_down", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("running_side", true);

            newPos.x += Time.deltaTime * moveSpeed;
            gameObject.transform.localScale = new Vector3(2, 2, 2);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("running_side", true);

            newPos.x -= Time.deltaTime * moveSpeed;
            gameObject.transform.localScale = new Vector3(-2, 2, 2);
        }
        else
        {
            anim.SetBool("running_side", false);
        }

        transform.position = newPos;
    }
}
