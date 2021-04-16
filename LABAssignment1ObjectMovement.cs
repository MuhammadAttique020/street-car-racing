using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{


    float a, b;


    void Update()
    {
        a = Input.GetAxis("Horizontal");
        transform.Translate(Input.GetAxis("Horizontal") * 15f * Time.deltaTime, 0f, 0f);
        Vector3 character = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            character.x = 10;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            character.y = 10;
        }
        transform.localScale = character;

        b = Input.GetAxis("Vertical");
        transform.Translate(0f, Input.GetAxis("Vertical") * 15f * Time.deltaTime, 0f);
        Vector3 character2 = transform.localScale;
        if (Input.GetAxis("Vertical") > 0)
        {
            character2.x = 10;
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            character2.y = 10;
        }
        transform.localScale = character2;
    }

}
