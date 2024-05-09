// Ground.cs
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private int _length; // �c�̈ړ��ł���}�X
    [SerializeField] private int _width; // ���̈ړ��ł���}�X
    const int _nLengthStart = 1; // �c�̈ړ��ł��Ȃ��}�X�n��
    const int _nLengthEnd = 22; // �c�̈ړ��ł��Ȃ��}�X�I���
    const int _nWidthStart = 1; // ���̈ړ��ł��Ȃ��}�X�n��
    const int _nWidthEnd = 9; // ���̈ړ��ł��Ȃ��}�X�I���
    const int midSpritPanel = 11; // �����̒l

    // �u���b�N�̐���
    [SerializeField] private GameObject _wallPrefab; // ������
    [SerializeField] private GameObject _tilePrefab; // �ړ��ł���}�X

    private void Start()
    {
        for (int width = 0; width < _length; width++) // ���̃}�X�̏o��
        {
            for (int length = 0; length < _width; length++) // �c�̃}�X�̏o��
            {
                if (length >= _nLengthStart && length < _nLengthEnd && width >= _nWidthStart && width < _nWidthEnd) // �c�̃}�X���P��22�A���̃}�X��1��9�̈��
                {
                    Instantiate(_tilePrefab, new Vector3(length, width, 0), Quaternion.identity, transform); // ���̃}�X���쐬
                }
                else // ����ȊO�̏ꍇ
                {
                    GameObject wall = Instantiate(_wallPrefab, new Vector3(length, width, 0), Quaternion.identity, transform); // ���̕ǂ��쐬
                    wall.GetComponent<SpriteRenderer>().color = Color.black;
                }

                if (length == midSpritPanel) // �^�񒆂̃}�X�̕���
                {
                    GameObject wall = Instantiate(_wallPrefab, new Vector3(length, width, 0), Quaternion.identity, transform); // ���̕ǂ��쐬
                    wall.GetComponent<SpriteRenderer>().color = Color.black;
                }
            }
        }
    }

    // �w�肵���ʒu�̃}�X���ړ��\���ǂ����𔻒肷��֐�
    public bool IsTileMoveable(Vector2 position)
    {
        // �ړ��\�ȃ}�X���ǂ����̏����������ɒǉ�
        // �Ⴆ�΁A����̍��W���ړ��s�\�ȏꍇ��false��Ԃ�

        // ���̗�ł́A�ړ���̈ʒu�� (-5, -5) �ȏ� (5, 5) �����͈͓̔��ł���Έړ��\�Ƃ��Ă��܂�
        if (position.x >= -5 && position.x < 5 && position.y >= -5 && position.y < 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}