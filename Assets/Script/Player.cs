using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;       //プレイヤーの移動スピード
    private float distance = 1.0f;　　　//プレイヤーの移動距離
    private Vector2 move;
    private Vector2 targetPos; // Vector2に変更

    [SerializeField] private Vector2 initialPosition = new Vector2(0, 0);       //プレイヤーの初期値

    private void Start()
    {
        transform.position = initialPosition;
        targetPos = initialPosition;
    }

    void Update()
    {
        Vector2 move = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            move.y = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            move.y = -1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            move.x = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            move.x = 1;
        }

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

        if (move != Vector2.zero && (Vector2)transform.position == targetPos) // transform.positionをVector2にキャストして比較
        {
            targetPos += move * distance; // Vector2同士の加算に変更
        }
        Move(targetPos);
    }

    private void Move(Vector2 targetPosition) // 引数の型をVector2に変更
    {
        transform.position = Vector2.MoveTowards((Vector2)transform.position, targetPosition,
            _speed * Time.deltaTime); // transform.positionをVector2にキャストして使用
    }
}
