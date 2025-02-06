using UnityEngine;

public class SecondHand : MonoBehaviour
{

    TimeManager timeManager;

    void Start()
    {
        timeManager = FindObjectOfType<TimeManager>();
        if (timeManager == null)
        {
            Debug.LogError("TimeManager not found in the scene.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        float seconds = timeManager.getSeconds();
        float secondAngle = seconds * 6;
        transform.localRotation = Quaternion.Euler(secondAngle, 0, 0);
    }
}
