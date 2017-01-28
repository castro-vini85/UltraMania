using UnityEngine;
using System.Collections;

public class Level1 : MonoBehaviour
{
    public GameObject enemyObj;
    public float startX = 0f;
    public float startY = 0f;
    public int enemyAmount = 18;

    public static int emenyShotsCount = 0;

    // Use this for initialization
    void Start()
    {
        var x = startX;
        var y = startY;

        for (var i = 1; i <= enemyAmount; i++)
        {
            Instantiate(enemyObj, new Vector3(x, y, 0), Quaternion.identity);

            switch (i % 3)
            {
                case 1:
                    y = startY - 1.5f;
                    break;
                case 2:
                    x += 1.5f;
                    y = startY - 0.75f;
                    break;
                default:
                    x += 1.5f;
                    y = startY;
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
