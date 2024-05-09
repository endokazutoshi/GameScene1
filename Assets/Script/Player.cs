// Player.cs
using UnityEngine;

public class Player : MonoBehaviour
{
    const float _speed = 5; // プレイヤーの移動スピード
    const float _distance = 1.0f; // プレイヤーの移動距離
    private Vector2 _targetPos; // プレイヤーが目指す位置
    private Ground _ground; // Groundスクリプトへの参照

    [SerializeField] private Vector2 _initialPosition = new Vector2(0, 0); // プレイヤーの初期位置

    private void Start()
    {
        transform.position = _initialPosition;
        _targetPos = _initialPosition;

        // Groundスクリプトの参照を取得
        _ground = FindObjectOfType<Ground>();
    }

    private void Update()
    {
        // Playerの移動処理
        if (Input.GetKeyDown(KeyCode.W))
        {
            TryMove(Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            TryMove(Vector2.down);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            TryMove(Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            TryMove(Vector2.right);
        }
    }

    // プレイヤーの移動を試みる関数
    private void TryMove(Vector2 direction)
    {
        // 移動先の位置を計算
        Vector2 newPosition = _targetPos + direction * _distance;

        // 移動先が移動可能なマスかどうかをGroundスクリプトに問い合わせる
        if (_ground.IsTileMoveable(newPosition))
        {
            _targetPos = newPosition;
        }
    }
}
