using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChallengeUI : MonoBehaviour {
    public Button challengeButton;
    public TMP_Text challengeStatus;

    void Start() {
        challengeButton.onClick.AddListener(OnChallengeClicked);
    }

    void OnChallengeClicked() {
        string challengeId = CatoffAPI.CreateChallenge("test_game", 1.5);
        challengeStatus.text = $"Challenge Created: {challengeId}";
    }
}
