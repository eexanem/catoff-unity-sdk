using UnityEngine;

public class TestCatoff : MonoBehaviour {
    void Start() {
        var wallet = CatoffAPI.Authenticate();
        CatoffAPI.Log($"Wallet {wallet} connected!");

        var challengeId = CatoffAPI.CreateChallenge("test_game", 1.5);
        CatoffAPI.Log($"Challenge created: {challengeId}");
    }
}
