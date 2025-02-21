mergeInto(LibraryManager.library, {
  Catoff_LogMessage: function(message) {
    console.log("[Catoff Mock] Log:", UTF8ToString(message));
  },

  Catoff_CreateChallenge: function(gameId, wager) {
    try {
      if (!gameId || wager <= 0) {
        throw new Error("Invalid gameId or wager amount.");
      }
      const challengeId = `MOCK_CHALLENGE_${Date.now()}`;
      console.log(`[Catoff Mock] Created Challenge: ${UTF8ToString(gameId)} (${wager} SOL)`);
      return allocate(intArrayFromString(challengeId), ALLOC_NORMAL);
    } catch (error) {
      console.error(`[Catoff ERROR] Challenge creation failed: ${error.message}`);
      return 0; // Return 0 to indicate failure
    }
  },

  Catoff_Authenticate: function() {
    try {
      const wallet = `MOCK_WALLET_${Math.floor(Math.random() * 1000)}`;
      console.log(`[Catoff Mock] Authenticated: ${wallet}`);
      return allocate(intArrayFromString(wallet), ALLOC_NORMAL);
    } catch (error) {
      console.error(`[Catoff ERROR] Authentication failed: ${error.message}`);
      return 0; // Return 0 on failure
    }
  },

  Unity_LogToBrowser: function(message) {
    console.log(`[Unity] ${UTF8ToString(message)}`);
  }
});
