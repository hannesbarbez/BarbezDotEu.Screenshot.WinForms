// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the MIT License.

using System;

namespace ScreenshotOnePro.Logic
{
    public static class Constants
    {
        public static string FileNameCompatibleDateTime = @"yyyyMMddHmmssfffffff";
        public static char[] CHARSNOTALLOWEDINFILENAMES = { '&', '\"', '<', '>', '*', '/', '\\', '\'', ':', '.', '#', '~', '|', '@', '?' };
        public const string THANKS = "Thank you for choosing Screenshot One Pro!";
        public static readonly string THIRDPARTY = "*** Third Party Notices ***" + Environment.NewLine + Environment.NewLine + "Screenshot One Pro incorporates components from the Open Source Software below. The original copyright notices and the licenses under which the author of Screenshot " +
            "One Pro received such components are set forth below for informational purposes." + Environment.NewLine + Environment.NewLine + "===============================================" +
            Environment.NewLine + "The article at https://www.codeproject.com/Articles/793687/Configuring-the-emulation-mode-of-an-Internet-Expl, along with any associated source code and files," +
            " used by Screenshot One Pro, is licensed under The MIT License." + Environment.NewLine + Environment.NewLine + "Terms of the MIT License:" + Environment.NewLine +
            "-------------------------------------------------------------------" + Environment.NewLine + "Copyright 2014 Richard James Moss" + Environment.NewLine + Environment.NewLine +
            "Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the \"Software\"), to deal in the Software without " +
            "restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom " +
            "the Software is furnished to do so, subject to the following conditions: " + Environment.NewLine + Environment.NewLine + "The above copyright notice and this permission notice shall " +
            "be included in all copies or substantial portions of the Software." + Environment.NewLine + Environment.NewLine + "THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY " +
            "OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL " +
            "THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN " +
            "CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE." + Environment.NewLine + "-------------------------------------------------------------------" +
            Environment.NewLine + "===============================================";
    }
}
