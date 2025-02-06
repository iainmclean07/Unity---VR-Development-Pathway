using UnityEngine;

public class HourHand : MonoBehaviour
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
        float hours = timeManager.getHours();
        float minutes = timeManager.getMinutes();
        float seconds = timeManager.getSeconds();

        float hourAngle = (hours % 12) * 30 + minutes * 0.5f;
        transform.localRotation = Quaternion.Euler(hourAngle, 0, 0);
    }
}