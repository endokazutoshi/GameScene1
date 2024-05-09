using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private GameObject _wallPrefab;
    [SerializeField] private GameObject _tilePrefab;
    [SerializeField] private int _length;
    [SerializeField] private int _width;
    private void Start()
    {
        for (int length = 0; length < _length; length++)
        {
            for (int width = 0; width < _width; width++)
            {
                if (length >= 1 && length < 22 && width >= 1 && width < 9) // ���̍��W��0����22�͈̔͂̏ꍇ
                {
                    Instantiate(_wallPrefab, new Vector3(length, width, 0), Quaternion.identity, transform);
                }
                else // ����ȊO�̏ꍇ
                {
                    Instantiate(_tilePrefab, new Vector3(length, width, 0), Quaternion.identity, transform);

                }
                if (length >= 11 && length < 12)
                {
                    Instantiate(_tilePrefab, new Vector3(length, width, 0), Quaternion.identity, transform);
                }
                
            }
        }
    }
}
