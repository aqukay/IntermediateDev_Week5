using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class player_collide : MonoBehaviour
{
    bool have_key = false;
    public string farmer_dialogue;

    public TMP_Text speechUI;
    public GameObject textObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "gate" && have_key)
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "farmer" && Input.GetKeyDown(KeyCode.Space))
        {
            text.Object.SetActive(true);
            speechUI.text = farmer_dialogue;
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

        if (!collision.gameObject.name == "farmer" && textObject.Object.activeSelf == true)
        {
            textObject.SetActive(false);
        }
    }
}
