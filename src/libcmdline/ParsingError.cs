﻿#region License
//
// Command Line Library: ParsingError.cs
//
// Author:
//   Giacomo Stelluti Scala (gsscoder@gmail.com)
//
// Copyright (C) 2005 - 2013 Giacomo Stelluti Scala
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

namespace CommandLine
{
    /// <summary>
    /// Models a parsing error.
    /// </summary>
    public sealed class ParsingError
    {
        internal ParsingError()
        {
            this.BadOption = new BadOptionInfo();
        }

        internal ParsingError(char? shortName, string longName, bool format)
        {
            this.BadOption = new BadOptionInfo(shortName, longName);
            this.ViolatesFormat = format;
        }

        /// <summary>
        /// Gets or a the bad parsed option.
        /// </summary>
        /// <value>
        /// The bad option.
        /// </value>
        public BadOptionInfo BadOption { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CommandLine.ParsingError"/> violates required.
        /// </summary>
        /// <value>
        /// <c>true</c> if violates required; otherwise, <c>false</c>.
        /// </value>
        public bool ViolatesRequired { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CommandLine.ParsingError"/> violates format.
        /// </summary>
        /// <value>
        /// <c>true</c> if violates format; otherwise, <c>false</c>.
        /// </value>
        public bool ViolatesFormat { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CommandLine.ParsingError"/> violates mutual exclusiveness.
        /// </summary>
        /// <value>
        /// <c>true</c> if violates mutual exclusiveness; otherwise, <c>false</c>.
        /// </value>
        public bool ViolatesMutualExclusiveness { get; set; }
    }
}