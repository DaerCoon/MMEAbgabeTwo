using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform parent;
    private void Start()
    {
        for (int i= 0;i< 5;i++) 
        {
            Vector3 position = new Vector3(Random.Range(-5, 5), Random.Range(1, 2), Random.Range(-5, 5));
            var ball = Instantiate(ballPrefab, position, Quaternion.identity);
            ball.transform.parent = parent;
        };
    }
}
