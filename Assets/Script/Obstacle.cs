using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab; // �ʉ߂ł��Ȃ��u���b�N�̃v���n�u
    [SerializeField] private Vector2Int[] _obstaclePositions; // �u���b�N��z�u����ʒu�̔z��

    private void Start()
    {
        GenerateObstacles();
    }

    private void GenerateObstacles()
    {
        foreach (Vector2Int position in _obstaclePositions)
        {
            Instantiate(_obstaclePrefab, new Vector3(position.x, position.y, 0), Quaternion.identity, transform);
        }
    }
}

