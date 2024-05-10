using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed; // �v���C���[�̈ړ��X�s�[�h
    private float distance = 1.0f; // �v���C���[�̈ړ�����
    private Vector2 move;
    private Vector2 targetPos; // �v���C���[�̖ڕW�ʒu

    [SerializeField] private Vector2 initialPosition = new Vector2(0, 0); // �v���C���[�̏����ʒu

    // �v���C���[�̌��݈ʒu���O������Q�Ƃł���悤�ɂ���v���p�e�B
    public Vector2 PlayerPosition => (Vector2)transform.position;

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

        if (move != Vector2.zero && (Vector2)transform.position == targetPos)
        {
            targetPos += move * distance;
        }
        Move(targetPos);

        // ���݂̃v���C���[�̈ʒu���f�o�b�O���O�ŕ\��
        Debug.Log("Player's position: " + PlayerPosition);
    }

    private void Move(Vector2 targetPosition)
    {
        transform.position = Vector2.MoveTowards((Vector2)transform.position, targetPosition,
            _speed * Time.deltaTime);
    }
}
