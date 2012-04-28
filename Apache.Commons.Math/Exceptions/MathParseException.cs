/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Apache.Commons.Math.Exceptions.Util;

namespace Apache.Commons.Math.Exceptions
{
    /// <summary>
    /// Class to signal parse failures.
    /// </summary>
    [Serializable]
    public class MathParseException: MathIllegalStateException
    {
        /// <summary>
        /// Simple constructor.
        /// </summary>
        /// <param name="wrong">Bad string representation of the object.</param>
        /// <param name="position">Index, in the <paramref name="wrong"/> string, that caused the parsing to fail.</param>
        /// <param name="type">Type of the object supposedly represented by the <paramref name="wrong"/> string.</param>
        public MathParseException(string wrong, int position, Type type) :
            base(LocalizedFormats.CANNOT_PARSE_AS_TYPE, wrong, position, type) { }

        /// <summary>
        /// Simple constructor.
        /// </summary>
        /// <param name="wrong">Bad string representation of the object.</param>
        /// <param name="position">Index, in the <paramref name="wrong"/> string, that caused the parsing to fail.</param>
        public MathParseException(string wrong, int position) :
            base(LocalizedFormats.CANNOT_PARSE, wrong, position) { }
    }
}
