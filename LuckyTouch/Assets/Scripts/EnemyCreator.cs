using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    public Transform[] InstantiatePositions;
    public Enemy Enemy;

    void Start()
    {
        InvokeRepeating("CreateEnemy", 2, 2);
    }

    void Update()
    {

    }

    void CreateEnemy()
    {
        var enemyRandomMode = Random.Range(0, 6);
        switch (enemyRandomMode)
        {
            case 1:
                Instantiate(Enemy, InstantiatePositions[0].position, Quaternion.identity);
                Instantiate(Enemy, InstantiatePositions[1].position, Quaternion.identity);
                break;
            case 2:
                Instantiate(Enemy, InstantiatePositions[1].position, Quaternion.identity);
                Instantiate(Enemy, InstantiatePositions[2].position, Quaternion.identity);
                break;
            default:
                Instantiate(Enemy, InstantiatePositions[Random.Range(0, 3)].position, Quaternion.identity);
                break;
        }
    }
}
