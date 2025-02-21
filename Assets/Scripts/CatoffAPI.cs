using System.Runtime.InteropServices;
using UnityEngine;

public static class CatoffAPI {
#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void Catoff_LogMessage(string message);

    [DllImport("__Internal")]
    private static extern string Catoff_CreateChallenge(string gameId, double wager);

    [DllImport("__Internal")]
    private static extern string Catoff_Authenticate();
#endif

    public static void Log(string message) {
#if UNITY_WEBGL && !UNITY_EDITOR
        Catoff_LogMessage(message);
#else
        Debug.Log($"[Catoff Mock] {message}");
#endif
    }

    public static string CreateChallenge(string gameId, double wager) {
#if UNITY_WEBGL && !UNITY_EDITOR
        return Catoff_CreateChallenge(gameId, wager);
#else
        var challengeId = $"MOCK_CHALLENGE_{System.DateTime.Now.Ticks}";
        Debug.Log($"[Catoff Mock] Created Challenge: {gameId} ({wager} SOL)");
        return challengeId;
#endif
    }

    public static string Authenticate() {
#if UNITY_WEBGL && !UNITY_EDITOR
        return Catoff_Authenticate();
#else
        var wallet = $"MOCK_WALLET_{Random.Range(100, 999)}";
        Debug.Log($"[Catoff Mock] Authenticated: {wallet}");
        return wallet;
#endif
    }
}
