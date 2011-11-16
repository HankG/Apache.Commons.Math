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
    /// Exception triggered when something that shouldn't happen does happen.
    /// </summary>
    [Serializable]
    public class MathInternalError: MathIllegalStateException
    {
        private const string REPORT_URL = "https://github.com/maurofranceschini/Apache.Commons.Math/issues";

        /// <summary>
        /// Simple constructor.
        /// </summary>
        public MathInternalError(): base(LocalizedFormat.INTERNAL_ERROR, REPORT_URL) { }

        /// <summary>
        /// Simple constructor.
        /// </summary>
        /// <param name="inner">The root cause of this exception.</param>
        public MathInternalError(Exception inner) : base(inner, LocalizedFormat.INTERNAL_ERROR, REPORT_URL) { }

        /// <summary>
        /// Constructor accepting a localized message.
        /// </summary>
        /// <param name="pattern">Message pattern explaining the cause of the error.</param>
        /// <param name="args">Arguments.</param>
        public MathInternalError(ILocalizable pattern, params object[] args) : base(pattern, args) { }
    }
}
