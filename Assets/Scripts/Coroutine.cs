using System.Collections;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    public float normalSpeed = 3f;
    public float boostSpeed = 8f;

    private float currentSpeed;
    void Start()
    {
        currentSpeed = normalSpeed;
        StartCoroutine(SpeedBoost());
    }

    void Update()
    {
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
    }

    IEnumerator SpeedBoost()
    {
        Debug.Log("SpeedBoostApplied");
        currentSpeed = boostSpeed;
        yield return new WaitForSeconds(3f);
        Debug.Log("SpeedBoostEnd");
        currentSpeed = normalSpeed;
    }
}
