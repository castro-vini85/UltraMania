using UnityEngine;
using System.Collections;

public class ShotControl : MonoBehaviour
{

    public int force = 1000;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, force));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") && gameObject.CompareTag("PlayerShot"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            ShipControl.playerShotsCount--;
        }

        if (other.CompareTag("Player") && gameObject.CompareTag("EnemyShot"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Level1.emenyShotsCount--;
        }

        if (other.CompareTag("GameController"))
        {
            Destroy(gameObject);

            if (gameObject.CompareTag("EnemyShot"))
                Level1.emenyShotsCount--;

            if (gameObject.CompareTag("PlayerShot"))
                ShipControl.playerShotsCount--;
        }
    }
}
