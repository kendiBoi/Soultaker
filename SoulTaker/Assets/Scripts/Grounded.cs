using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    GameObject chara;
    // Start is called before the first frame update
    void Start()
    {
        chara = gameObject.transform.parent.gameObject;
    }
    
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            chara.GetComponent<playerMovement>().isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            chara.GetComponent<playerMovement>().isGrounded = false;
        }
    }

    
}
