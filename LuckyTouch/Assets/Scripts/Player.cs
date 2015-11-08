using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameController GameController;
    public EnemyCreator EnemyCreator;

    private readonly List<Vector3> _playerPositions = new List<Vector3>();
    private Vector3 _endPos;

    void Start()
    {
        _endPos = transform.position;
        LoadPlayerPositions();
    }

    void Update()
    {
        UpdatePlayerPosition();
    }

    private void OnCollisionEnter2D(Collision2D otherCollision2D)
    {
        DieIfEnemy(otherCollision2D);
    }

    private void DieIfEnemy(Collision2D otherCollision2D)
    {
        if (otherCollision2D.transform.CompareTag("Enemy"))
        {
            GameController.MinusLife();
            if (!GameController.IsDead())
            {
                Destroy(otherCollision2D.gameObject);
            }
        }
    }

    private void LoadPlayerPositions()
    {
        foreach (var enemyPos in EnemyCreator.InstantiatePositions)
        {
            var playerPos = enemyPos.position;
            playerPos.y = transform.position.y;

            _playerPositions.Add(playerPos);
        }
    }

    private void UpdatePlayerPosition()
    {
        transform.position = Vector3.Lerp(transform.position, _endPos, Time.deltaTime * 10);
    }

    public void MovePlayer()
    {
        if (_endPos == _playerPositions[0] || _endPos == _playerPositions[2])
        {
            _endPos = _playerPositions[1];
        }
        else
        {
            _endPos = Random.Range(0, 2) == 1 ? _playerPositions[0] : _playerPositions[2];
        }
    }
}
