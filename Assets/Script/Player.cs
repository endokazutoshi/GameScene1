// Player.cs
using UnityEngine;

public class Player : MonoBehaviour
{
    const float _speed = 5; // �v���C���[�̈ړ��X�s�[�h
    const float _distance = 1.0f; // �v���C���[�̈ړ�����
    private Vector2 _targetPos; // �v���C���[���ڎw���ʒu
    private Ground _ground; // Ground�X�N���v�g�ւ̎Q��

    [SerializeField] private Vector2 _initialPosition = new Vector2(0, 0); // �v���C���[�̏����ʒu

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
    }
}
