﻿using System;
using System.IO;
using JetBrains.Annotations;

namespace MotorsportManagerModLoader {
    internal static class Logger {
        // logging
        internal static string LogPath { get; set; }

        [StringFormatMethod("message")]
        internal static void Log(string message, params object[] formatObjects) {
            if (string.IsNullOrEmpty(LogPath)) return;
            using (var logWriter = File.AppendText(LogPath)) {
                logWriter.WriteLine(message, formatObjects);
            }
        }

        [StringFormatMethod("message")]
        internal static void LogWithDate(string message, params object[] formatObjects) {
            if (string.IsNullOrEmpty(LogPath)) return;
            using (var logWriter = File.AppendText(LogPath)) {
                logWriter.WriteLine(DateTime.Now.ToLongTimeString() + " - " + message, formatObjects);
            }
        }
    }
}