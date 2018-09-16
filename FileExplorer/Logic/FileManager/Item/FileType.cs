﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Logic.FileManager.Item
{
    public enum FileType
    {
        ReadOnly = 1,
        Hidden = 2,
        System = 4,
        Directory = 16,
        Archive = 32,
        Device = 64,
        Normal = 128,
        Temporary = 256,
        SparseFile = 512,
        ReparsePoint = 1024,
        Compressed = 2048,
        Offline = 4096,
        NotContentIndexed = 8192,
        Encrypted = 16384,
        IntegrityStream = 32768,
        NoScrubData = 131072
    }
}