

# Catoff WebGL Prototype

## 🚀 Overview
This is a WebGL-based gaming prototype that integrates a mock wallet authentication system, challenge creation, and performance optimizations.

## Setup Instructions

1. **Clone the Repository**  
   ```bash
   git clone <your-repo-url>
   cd <repo-name>
   ```

2. **Open in Unity**
   - Open Unity Hub
   - Select "Open Project" and choose this directory

3. **Build WebGL Version**
   - Open `File` → `Build Settings`
   - Select **WebGL** as the target platform
   - Click **Build & Run**

---

## 🎮 Features Implemented

- WebGL & Unity Message Passing
- Mock Wallet Authentication (Phantom)
- Challenge Creation & UI Flow
- FPS Counter for Performance Monitoring
- Object Pool for Transaction Notifications

---

## WebGL Build Instructions

1. **Switch Platform to WebGL**
   - Open `Build Settings`
   - Select **WebGL** and click **Switch Platform**

2. **Configure Player Settings**
   - Go to `Edit` → `Project Settings` → `Player`
   - In `WebGL`, ensure:
     - Compression Format: **Gzip**
     - WebGL Memory Size: **512MB or more**
     - Enable `Data Caching` for faster load times

3. **Build & Deploy**
   ```bash
   mkdir -p Builds/WebGL
   cd Builds/WebGL
   ```
   - Click **Build & Run** from Unity.

   ---

## API Reference

For a detailed API guide, check [`Docs/API_REFERENCE.md`](Docs/API_REFERENCE.md).
```