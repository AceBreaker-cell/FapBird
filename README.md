# FapBird (Flappy Bird Replica Unity)

Replika game **Flappy Bird** yang dibuat menggunakan **Unity 6 (6000.4.0f1)**, dengan karakter utama berupa pesawat tempur pixel-art yang terbang melewati rintangan pipa.

Project ini merupakan **tugas individu** untuk mata kuliah **Pengenalan Pemrograman Game**.

## 🎮 Preview

<img width="1920" height="1032" alt="Screenshot 2026-07-26 103507" src="https://github.com/user-attachments/assets/b5a6709f-1199-44a8-aeb9-dfbfd469d0ff" />


Game menampilkan tampilan portrait (9:16) dengan latar kota pixel-art saat senja, sistem skor (Score & Best), pesawat yang bisa dikendalikan untuk terbang, serta rintangan berupa pipa yang muncul secara berkala.

## ✨ Fitur

- Kontrol terbang sederhana (flap / naik-turun)
- Spawner rintangan pipa otomatis (`SpawnerPipa`)
- Sistem skor & skor terbaik (Score / Best) menggunakan TextMesh Pro
- Game Over screen (`GameOverCanvas`) saat karakter menabrak rintangan
- Animasi karakter pesawat
- Manajemen state game terpusat lewat `GameManager`

## 🛠️ Dibuat Dengan

- **Engine:** Unity 6 (6000.4.0f1), platform Windows/Mac/Linux
- **Bahasa:** C#
- **UI Text:** TextMesh Pro
- **Input:** Unity Input System (`InputSystem_Actions`)

## 📁 Struktur Folder (Assets)

```
Assets/
├── Animations/     # Animasi karakter pesawat & objek lain
├── Prefabs/        # Prefab pipa, karakter, dsb.
├── Scenes/         # Scene utama game
├── Scripts/        # Seluruh script C# (GameManager, PipeSpawner, dll.)
├── Sounds/         # Efek suara & musik
├── Sprites/        # Aset visual pixel-art
└── TextMesh Pro/   # Resource font untuk UI
```

## 🚀 Cara Menjalankan Project

1. Clone repository ini:
   ```bash
   git clone https://github.com/AceBreaker-cell/FapBird/
   ```
2. Buka project menggunakan **Unity Hub**, pastikan versi Unity yang terpasang **6000.4.0f1** (atau versi Unity 6 yang kompatibel).
3. Buka scene utama di folder `Assets/Scenes`.
4. Tekan tombol **Play** di Unity Editor untuk mencoba game.

## 🕹️ Kontrol

- **Klik / Tap / Tombol lompat** → membuat pesawat terbang naik
- Hindari menabrak pipa atau batas layar agar skor terus bertambah

*(Sesuaikan bagian ini jika skema kontrolmu berbeda.)*

## 📦 Bebas Digunakan

Seluruh **assets dan source code** di repository ini bebas digunakan, dimodifikasi, dan dikembangkan lebih lanjut — baik untuk belajar, tugas, maupun project pribadi. Tidak perlu izin khusus, cukup fork/clone dan gunakan sesuai kebutuhan.

## 🙏 Kredit & Inspirasi

Project ini dibuat dengan mengikuti tutorial dari video berikut:
[Referensi Tutorial YouTube](https://www.youtube.com/watch?v=hKGzSYXPQwY)

Terima kasih kepada pembuat tutorial atas ilmu yang dibagikan.

## 📚 Konteks Akademik

Dibuat sebagai bagian dari tugas individu mata kuliah **Pengenalan Pemrograman Game**.
