using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Player Player;

    void Start() { }

    void Update() { }

    void OnMouseDown()
    {
        Player.MovePlayer();
    }
}
