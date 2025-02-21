mergeInto(LibraryManager.library, {
  Catoff_LogMessage: function(message) {
    console.log("[Catoff Mock] Log:", UTF8ToString(message));
  },

  Catoff_CreateChallenge: function(gameId, wager) {
    const challengeId = `MOCK_CHALLENGE_${Date.now()}`;
    console.log(`[Catoff Mock] Created Challenge: ${UTF8ToString(gameId)} (${wager} SOL)`);
    return challengeId;
  },

  Catoff_Authenticate: function() {
    const wallet = `MOCK_WALLET_${Math.floor(Math.random() * 1000)}`;
    console.log(`[Catoff Mock] Authenticated: ${wallet}`);
    return wallet;
  },

  Unity_LogToBrowser: function(message) {  
    console.log(`[Unity] ${UTF8ToString(message)}`);
  }
});
