using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChallengeUI : MonoBehaviour {
    public Button challengeButton;
    public TMP_Text challengeStatus;

    void Start() {
        challengeButton.onClick.AddListener(OnCreateChallenge);
    }

    void OnCreateChallenge() {
        challengeStatus.text = "Creating challenge...";
        
        string challengeId = CatoffAPI.CreateChallenge("test_game", 1.5);
        if (string.IsNullOrEmpty(challengeId)) {
            challengeStatus.text = "⚠️ Challenge creation failed. Please try again!";
        } else {
            challengeStatus.text = $"✅ Challenge created: {challengeId}";
        }
    }
}
