using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrownFlame : MonoBehaviour
{
    public Rigidbody2D m_Rigidbody;
    Transform magnet;
    public float m_Thrust = 20f;


    // Start is called before the first frame update
    void Start()  {
       m_Rigidbody = GetComponent<Rigidbody2D>(); 
       magnet = GameObject.Find("House").GetComponent<Transform>();
       Physics.IgnoreLayerCollision(3, 3);

       //m_Rigidbody.AddForce(transform.right * m_Thrust, ForceMode2D.Impulse);
    }

    void Update()
    {
        float distance = Vector2.Distance(magnet.position, transform.position);
        if(distance > 5) {
            Vector2 direction = magnet.position - transform.position;
            m_Rigidbody.AddForce(direction / m_Thrust);
        } else {
            m_Rigidbody.velocity = Vector2.zero;
        }

    }
    /*
    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.layer == 5) {
            Physics.IgnoreCollision()
        }
    }
    */
}
