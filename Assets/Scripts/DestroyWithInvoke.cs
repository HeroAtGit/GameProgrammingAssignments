using UnityEngine;

public class DestroyWithInvoke : MonoBehaviour
{
    public GameObject Orb;
    void Start()
    {
        Invoke("DestroyObj", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestroyObj()
    {
        Destroy(gameObject);
    }
}
