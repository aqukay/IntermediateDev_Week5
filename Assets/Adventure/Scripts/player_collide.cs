using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class player_collide : MonoBehaviour
{
    public Transform t1;
    public Transform t2;
    public Transform t3;

    public TMP_Text speechUI;
    
    bool have_key = false;

    public string farmer_dialogue;

    public GameObject textObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(t1.position, t2.position) < 50 && Input.GetKeyDown(KeyCode.Space))
        {
            textObject.SetActive(true);
            speechUI.text = farmer_dialogue;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "gate" && have_key)
        {
            Destroy(collision.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Overlapped with" + collision.gameObject.name);

        //pick up the object you overlapped with
        if (collision.gameObject.name == "green grass")
        {
            Destroy(collision.gameObject);

            have_key = true;
        }
    }
}
