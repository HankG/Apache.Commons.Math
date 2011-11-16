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
using System.Globalization;

namespace Apache.Commons.Math.Exceptions.Util
{
    /// <summary>
    /// Interface for localizable strings.
    /// </summary>
    public interface ILocalizable
    {
        /// <summary>
        /// Gets the source (non-localized) string.
        /// </summary>
        string SourceString { get; }

        /// <summary>
        /// Gets the localized string.
        /// </summary>
        /// <param name="cultureInfo">The culture info object for which gets the string.</param>
        /// <returns>The localized string or the source string if no localized version is available.</returns>
        string GetLocalizedString(CultureInfo cultureInfo);
    }
}
