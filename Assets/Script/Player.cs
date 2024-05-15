// Player.cs
using UnityEngine;

public class Player : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField] private float _speed; // �v���C���[�̈ړ��X�s�[�h
    private float distance = 1.0f; // �v���C���[�̈ړ�����
    private Vector2 move;
    private Vector2 targetPos; // �v���C���[�̖ڕW�ʒu

    [SerializeField] private Vector2 initialPosition = new Vector2(0, 0); // �v���C���[�̏����ʒu

    // �v���C���[�̌��݈ʒu���O������Q�Ƃł���悤�ɂ���v���p�e�B
    public Vector2 PlayerPosition => (Vector2)transform.position;
=======
    const float _speed = 5; // �v���C���[�̈ړ��X�s�[�h
    const float _distance = 1.0f; // �v���C���[�̈ړ�����
    private Vector2 _targetPos; // �v���C���[���ڎw���ʒu
    private Ground _ground; // Ground�X�N���v�g�ւ̎Q��

    [SerializeField] private Vector2 _initialPosition = new Vector2(0, 0); // �v���C���[�̏����ʒu
>>>>>>> ba6601ed8bcf24554b7ed4fd09e97f7e0f88f16b

    private void Start()
    {
        transform.position = _initialPosition;
        _targetPos = _initialPosition;

        // Ground�X�N���v�g�̎Q�Ƃ��擾
        _ground = FindObjectOfType<Ground>();
    }

    private void Update()
    {
        // Player�̈ړ�����
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
=======
    }

    // �v���C���[�̈ړ������݂�֐�
    private void TryMove(Vector2 direction)
    {
        // �ړ���̈ʒu���v�Z
        Vector2 newPosition = _targetPos + direction * _distance;

        // �ړ��悪�ړ��\�ȃ}�X���ǂ�����Ground�X�N���v�g�ɖ₢���킹��
        if (_ground.IsTileMoveable(newPosition))
        {
            _targetPos = newPosition;
        }
>>>>>>> ba6601ed8bcf24554b7ed4fd09e97f7e0f88f16b
    }
}
