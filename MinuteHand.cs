using UnityEngine;

public class MinuteHand : MonoBehaviour
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
        float minutes = timeManager.getMinutes();
        float seconds = timeManager.getSeconds();

        float minuteAngle = minutes * 6 + seconds * 0.1f;
        transform.localRotation = Quaternion.Euler(minuteAngle, 0, 0);
    }
}
