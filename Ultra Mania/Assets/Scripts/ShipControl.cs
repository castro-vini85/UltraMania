using UnityEngine;
using System.Collections;

public class ShipControl : MonoBehaviour
{

    public int force = 3000;
    public GameObject shotObj;

    public static int playerShotsCount = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-force, 0));

        if (Input.GetKeyDown(KeyCode.RightArrow))
            GetComponent<Rigidbody2D>().AddForce(new Vector2(force, 0));

        if ((!Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow)) || (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow)))
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;


        if (Input.GetKey(KeyCode.Space) && playerShotsCount == 0)
        {
            var shipPosition = GetComponent<Rigidbody2D>().position;
            shipPosition.y += 0.5f;

            Instantiate(shotObj, shipPosition, Quaternion.identity);

            playerShotsCount++;
        }
    }
}
