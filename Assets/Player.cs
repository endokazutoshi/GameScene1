using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;       //�v���C���[�̈ړ��X�s�[�h
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
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
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
