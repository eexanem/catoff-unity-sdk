using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class TXNotificationPool : MonoBehaviour {
    public GameObject notificationPrefab;
    public Transform notificationParent;
    private Queue<GameObject> pool = new Queue<GameObject>();

    void Start() {
        for (int i = 0; i < 5; i++) {
            GameObject obj = Instantiate(notificationPrefab, notificationParent);
            obj.SetActive(false);
            pool.Enqueue(obj);
        }
        ShowNotification("Test Notification!");
    }

    public void ShowNotification(string message) {
        Debug.Log("ShowNotification called: " + message);

        GameObject notification = pool.Count > 0 ? pool.Dequeue() : Instantiate(notificationPrefab, notificationParent);
        if (notification == null) {
            Debug.LogError("Notification prefab is null!");
            return;
        }

        var textComponent = notification.GetComponentInChildren<TextMeshProUGUI>();  // Use GetComponentInChildren
        if (textComponent == null) {
            Debug.LogError("TextMeshProUGUI component missing!");
            return;
        }

        textComponent.text = message;
        notification.SetActive(true);

        StartCoroutine(HideAfterDelay(notification, 3f));
    }

    private IEnumerator<UnityEngine.WaitForSeconds> HideAfterDelay(GameObject obj, float delay) {
        yield return new WaitForSeconds(delay);
        obj.SetActive(false);
        pool.Enqueue(obj);
    }
}
