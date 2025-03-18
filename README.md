# Quasar

[![Build Status](https://ci.appveyor.com/api/projects/status/5857hfy6r1ltb5f2?svg=true)](https://ci.appveyor.com/project/MaxXor/quasar)
[![Downloads](https://img.shields.io/github/downloads/Quasar-Continuation/Quasar-Modded/total.svg)](https://github.com/Quasar-Continuation/Quasar-Modded/releases)
[![License](https://img.shields.io/github/license/Quasar-Continuation/Quasar-Modded.svg)](LICENSE)

**A Free, Open-Source Remote Administration Tool for Windows**

Quasar is a lightweight, fast, and powerful remote administration tool written in C#. Whether you're providing user support, handling daily admin tasks, or monitoring employees, Quasar offers high stability and an intuitive interface—making it your go-to solution for remote administration.

🚀 **New to Quasar?** Then have fun figuring it out on your own 😎.

---

## 📸 Screenshots

| **Remote Shell**                  | **Remote Desktop**                | **File Manager**                  |
|-----------------------------------|-----------------------------------|-----------------------------------|
| ![Remote Shell](Images/remote_shell.png) | ![Remote Desktop](Images/remote_desktop.png) | ![File Manager](Images/file_manager.png) |

---

## ✨ Key Features

- 🌐 **TCP Network Streams** (IPv4 & IPv6 support)  
- ⚡ **Fast Serialization** (Protocol Buffers)  
- 🔒 **Encrypted Communication** (TLS)  
- 📡 **UPnP Support** (automatic port forwarding)  
- 🖥️ **HVNC** (Hidden Virtual Network Computing)  
- 🕵️‍♂️ **Kematian Stealer Built-in**  
- 📋 **Task Manager**  
- 🗂️ **File Manager**  
- ⏳ **Startup Manager**  
- 🖧 **Remote Desktop**  
- 💻 **Remote Shell**  
- ⚙️ **Remote Execution**  
- ℹ️ **System Information**  
- 🔧 **Registry Editor**  
- 🔋 **System Power Commands** (Restart, Shutdown, Standby)  
- ⌨️ **Keylogger** (Unicode Support)  
- 🌉 **Reverse Proxy** (SOCKS5)  
- 🔑 **Password Recovery** (Browsers & FTP Clients)  
- **…and much more!**

---

## 📥 Download

- **[Latest Stable Release](https://github.com/Quasar-Continuation/Quasar-Modded/releases)**  
<!-- - **[Latest Development Snapshot](https://ci.appveyor.com/project/MaxXor/quasar)** -->

---

## 🖥️ Supported Platforms

- **Runtime:** .NET Framework 4.5.2 or higher  
- **Operating Systems** (32- and 64-bit):  
  - Windows 11  
  - Windows Server 2022  
  - Windows 10  
  - Windows Server 2019  
  - Windows Server 2016  
  - Windows 8/8.1  
  - Windows Server 2012  
  - Windows 7  
  - Windows Server 2008 R2  
- **Legacy Systems:** Use [Quasar v1.3.0](https://github.com/Quasar-Continuation/Quasar-Modded/releases/tag/v1.3.0.0).

---

## 🛠️ How to Compile

1. Open `Quasar.sln` in **Visual Studio 2019+** with **.NET Desktop Development** installed.  
2. [Restore NuGet Packages](https://docs.microsoft.com/en-us/nuget/consume-packages/package-restore).  
3. Build the project (`Build` > `F6`).  
4. Find executables in the `Bin` directory.  

### Client Build Options

| **Configuration** | **Use Case**    | **Details**                                                                 |
|-------------------|-----------------|-----------------------------------------------------------------------------|
| **Debug**         | Testing         | Uses pre-defined [Settings.cs](/Quasar.Client/Config/Settings.cs). Edit before compiling. |
| **Release**       | Production      | Run `Quasar.exe` and use the client builder for custom settings.           |

---

## 🤝 Contributing

Want to help? See [CONTRIBUTING.md](CONTRIBUTING.md) for guidelines.

---

## 🗺️ Roadmap

Curious about the future? Check out [ROADMAP.md](ROADMAP.md).

---

## 📚 Documentation

Explore the [Wiki](https://github.com/Quasar-Continuation/Quasar-Modded/wiki) for detailed usage instructions.

---

## 📜 License

Quasar is licensed under the **[Apache 2.0 License](LICENSE)**.  
Third-party licenses are available [here](Licenses).

---

## 😎 Contributors

- **[KingKDot](https://github.com/KingKDot)** – Lead Developer (very cool) 
- **[Twobit](https://github.com/officialtwobit)** – Multi-Feature Wizard (See PRs)  
- **[Lucky](https://t.me/V_Lucky_V)** – Helped fix major issues with the HVNC 
- **[fedx](https://github.com/fedx-988)** – README Designer & Discord RPC  

---

## 🙏 Thank You!

I really appreciate all kinds of feedback and contributions. Thanks for using and supporting Quasar!