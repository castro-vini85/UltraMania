using UnityEngine;
using System.Collections;

public class Enemy1 : MonoBehaviour
{
    public int xSpeed = 0;
    public int ySpeed = 0;
    public GameObject shotObj;

    // Update is called once per frame
    void Start()
    {
        var newSpeed = new Vector2
        {
            x = xSpeed,
            y = ySpeed
        };

        GetComponent<Rigidbody2D>().AddForce(newSpeed);
    }

    void Update()
    {
        var x = GetComponent<Rigidbody2D>().position.x;
        var y = GetComponent<Rigidbody2D>().position.y;

        if (x <= -7.5f)
            GetComponent<Rigidbody2D>().position = new Vector2(10.5f, y);

        int shot = Random.Range(1, 200);

        if (shot == 10 && x >= -6.5f && x <= 6.5f && Level1.emenyShotsCount < 3)
        {
            var enemyPosition = GetComponent<Rigidbody2D>().position;
            enemyPosition.y -= 0.5f;
            Instantiate(shotObj, enemyPosition, Quaternion.identity);
            Level1.emenyShotsCount++;
        }
    }
}
