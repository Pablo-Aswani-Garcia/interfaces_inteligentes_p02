using UnityEngine;

public class spawner : MonoBehaviour
{   public GameObject prefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 400 == 0)
        {
            
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
        
    }
}
