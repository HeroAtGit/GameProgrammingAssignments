using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0f;
        }
        else if(Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 1f;
        }
    }
}
