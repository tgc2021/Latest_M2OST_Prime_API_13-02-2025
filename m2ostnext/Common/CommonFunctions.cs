﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Web;

namespace TGC_Game.Web
{
    internal static class CommonFunctions
    {
        //private static readonly string _encode32Chars = "0123456789ABCDEFGHIJKLMNOPQRSTUV";

        //private static long _lastId = DateTime.UtcNow.Ticks;

        //public static string GetNextId() => GenerateId(Interlocked.Increment(ref _lastId));

        //private static unsafe string GenerateId(long id)
        //{
        //    char* charBuffer = stackalloc char[6];

        //    charBuffer[0] = _encode32Chars[(int)(id >> 60) & 31];
        //    charBuffer[1] = _encode32Chars[(int)(id >> 55) & 31];
        //    charBuffer[2] = _encode32Chars[(int)(id >> 50) & 31];
        //    charBuffer[3] = _encode32Chars[(int)(id >> 45) & 31];
        //    charBuffer[4] = _encode32Chars[(int)(id >> 40) & 31];
        //    charBuffer[5] = _encode32Chars[(int)(id >> 35) & 31];
        //    //charBuffer[6] = _encode32Chars[(int)(id >> 30) & 31];
        //    //charBuffer[7] = _encode32Chars[(int)(id >> 25) & 31];
        //    //charBuffer[8] = _encode32Chars[(int)(id >> 20) & 31];
        //    //charBuffer[9] = _encode32Chars[(int)(id >> 15) & 31];
        //    //charBuffer[10] = _encode32Chars[(int)(id >> 10) & 31];
        //    //charBuffer[11] = _encode32Chars[(int)(id >> 5) & 31];
        //    //charBuffer[12] = _encode32Chars[(int)id & 31];

        //    return new string(charBuffer, 0, 6);
        //}

        public static int? ID_ORGANIZATION()
        {
            int? value = Convert.ToInt32(ConfigurationManager.AppSettings["ID_ORGANIZATION"]);
            return value;
        }

        enum Game
        {
            draganddropgame = 1,
            anagramgame = 2,
            angrybirdgame = 3,
            matchthetilegame = 4,
            truckdrivinggame =5,
            questionquizgame = 6
        }
    }
}