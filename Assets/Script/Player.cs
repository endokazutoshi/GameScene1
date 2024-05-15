// Player.cs
using UnityEngine;

public class Player : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField] private float _speed; // プレイヤーの移動スピード
    private float distance = 1.0f; // プレイヤーの移動距離
    private Vector2 move;
    private Vector2 targetPos; // プレイヤーの目標位置

    [SerializeField] private Vector2 initialPosition = new Vector2(0, 0); // プレイヤーの初期位置

    // プレイヤーの現在位置を外部から参照できるようにするプロパティ
    public Vector2 PlayerPosition => (Vector2)transform.position;
=======
    const float _speed = 5; // プレイヤーの移動スピード
    const float _distance = 1.0f; // プレイヤーの移動距離
    private Vector2 _targetPos; // プレイヤーが目指す位置
    private Ground _ground; // Groundスクリプトへの参照

    [SerializeField] private Vector2 _initialPosition = new Vector2(0, 0); // プレイヤーの初期位置
>>>>>>> ba6601ed8bcf24554b7ed4fd09e97f7e0f88f16b

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
<<<<<<< HEAD

        if (move.x != 0 && move.y != 0)
        {
            if (Mathf.Abs(move.x) > Mathf.Abs(move.y))
            {
                move.y = 0; // 上下方向の移動を無効化
            }
            else
            {
                move.x = 0; // 左右方向の移動を無効化
            }
        }

        if (move != Vector2.zero && (Vector2)transform.position == targetPos)
        {
            targetPos += move * distance;
        }
        Move(targetPos);

        // 現在のプレイヤーの位置をデバッグログで表示
        Debug.Log("Player's position: " + PlayerPosition);
    }

    private void Move(Vector2 targetPosition)
    {
        transform.position = Vector2.MoveTowards((Vector2)transform.position, targetPosition,
            _speed * Time.deltaTime);
=======
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
>>>>>>> ba6601ed8bcf24554b7ed4fd09e97f7e0f88f16b
    }
}
