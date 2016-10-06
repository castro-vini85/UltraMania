using UnityEngine;
using System.Collections;

public class ShipControl : MonoBehaviour
{

    public int force = 3000;
    public GameObject shotObj;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-force, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(force, 0));
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var shipPosition = GetComponent<Rigidbody2D>().position;

            shipPosition.y += 0.5f;

            Instantiate(shotObj, shipPosition, Quaternion.identity);
        }
    }
}
