using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Start()
    {
        Move();
        InitColor();

        Destroy(gameObject, 15f);
    }

    void Update()
    {

    }

    private float GetLevelMultiplicator()
    {
        return FindObjectOfType<GameController>().Level / 5f + 1;
    }

    private void Move()
    {
        GetComponent<Rigidbody2D>().velocity = Vector3.down * 2f * GetLevelMultiplicator();
    }

    private void InitColor()
    {
        var color = GetComponent<SpriteRenderer>().color;
        color.a = color.a * GetLevelMultiplicator();

        GetComponent<SpriteRenderer>().color = color;
    }
}
