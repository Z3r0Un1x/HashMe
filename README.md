![](https://img.shields.io/badge/priority-low-lightgrey.svg) 
![](https://img.shields.io/badge/status-active-green.svg)
![](https://img.shields.io/badge/release-v0.1-blue.svg)

# Hash Me

`hashme` is a very simple CLI tool build in C# with .NET Framework and also .NET Core for multi-platform support. The tool is designed to **compute multiple hashing methods at a time** (including MD5, SHA1 and SHA256).

## Installation
You can build it yourself with the source code provided in `Source` folder, or  just download the compatible PE and run it.

All you have to do is to enter the location of the file needed to be computed.

Ex: `hashme.exe "path\to\file.exe"`

And you should see the expected output, which is the `file.exe`'s hashes. 

## Integrity

|Files|Version| MD5 Hash | 
|--|--|--|
| hashme.exe |0.1| 04629C8B2F71B6A9B8BBD6DE88AD8344 |
| hashme.dll | 0.1 | 6396788F9424E8EBF5D17FF4F4619D6C |

## FAQs
**Q:** *Has this tool been already made a lot?*

Yes, I just want to make myself a version as my journey of learning C# (this also the first project I do with C#, though).

**Q:** *Will there be any GUI version?*

Maybe, if I am not ~~lazy~~ busy with other projects.

**Q:** *I want to contribute!*

Of course, open an issue or make a pull request if you have any idea.
