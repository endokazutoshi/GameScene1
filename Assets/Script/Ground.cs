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
            for (int width= 0; width < _width; width++)
            {
                if (length >= 1 && length < 23) // 横の座標が0から22の範囲の場合
                {
                    Instantiate(_wallPrefab, new Vector3(length, width, 0), Quaternion.identity, transform);
                }
                else // それ以外の場合
                {
                    Instantiate(_tilePrefab, new Vector3(length, width, 0), Quaternion.identity, transform);
                    
                }
            }
        }
    }
}
