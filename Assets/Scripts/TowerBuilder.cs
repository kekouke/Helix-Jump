using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private int _levelCount;
    [SerializeField] private GameObject[] _platforms;
    [SerializeField] private GameObject _beam;

    void Start()
    {
        Build();
    }
    
    private void Build()
    {
        var beam = Instantiate(_beam, transform);
        var platform = CreatePlatform();
        platform.transform.position = new Vector3(0, 10, 0);
    }

    private GameObject CreatePlatform()
    {
        var platformObject = _platforms[Random.Range(0, _platforms.Length)];

        var platform = Instantiate(platformObject, transform);
        
        var rotation = new Vector3(0, Random.Range(0, 360), 0);
        platform.transform.Rotate(rotation);

        return platform;
    }
}
