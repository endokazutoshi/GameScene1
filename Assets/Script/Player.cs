using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;       //�v���C���[�̈ړ��X�s�[�h
    private float distance = 1.0f;�@�@�@//�v���C���[�̈ړ�����
    private Vector2 move;
    private Vector2 targetPos; // Vector2�ɕύX

    [SerializeField] private Vector2 initialPosition = new Vector2(0, 0);       //�v���C���[�̏����l

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
                move.y = 0; // �㉺�����̈ړ��𖳌���
            }
            else
            {
                move.x = 0; // ���E�����̈ړ��𖳌���
            }
        }

        if (move != Vector2.zero && (Vector2)transform.position == targetPos) // transform.position��Vector2�ɃL���X�g���Ĕ�r
        {
            targetPos += move * distance; // Vector2���m�̉��Z�ɕύX
        }
        Move(targetPos);
    }

    private void Move(Vector2 targetPosition) // �����̌^��Vector2�ɕύX
    {
        transform.position = Vector2.MoveTowards((Vector2)transform.position, targetPosition,
            _speed * Time.deltaTime); // transform.position��Vector2�ɃL���X�g���Ďg�p
    }
}
