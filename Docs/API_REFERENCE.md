

# 📖 API Reference: Catoff WebGL Prototype

This document provides details on the available API functions.

---

## CatoffAPI.cs

### **1. Authenticate()**
**Description:**  
Mock authentication function that generates a wallet ID.

**Usage:**
```csharp
string walletId = CatoffAPI.Authenticate();
```
**Returns:**  
- `string` → Wallet ID (mocked)

---

### **2. CreateChallenge(string gameId, double wager)**
**Description:**  
Creates a challenge with a unique challenge ID.

**Usage:**
```csharp
string challengeId = CatoffAPI.CreateChallenge("game_123", 1.5);
```
**Returns:**  
- `string` → Challenge ID (mocked)

---

### **3. Log(string message)**
**Description:**  
Logs messages from Unity to the browser console.

**Usage:**
```csharp
CatoffAPI.Log("Test message");
```
**Returns:**  
- `void` (No return value)



