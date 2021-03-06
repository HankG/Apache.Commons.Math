﻿/*
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
    /// Exception to be thrown when a number is not finite.
    /// </summary>
    [Serializable]
    public class NotFiniteNumberException<T>: MathIllegalNumberException<T>
    {
        /// <summary>
        /// Construct the exception.
        /// </summary>
        /// <param name="wrong">Value that is infinite or NaN.</param>
        /// <param name="args">Optional arguments.</param>
        public NotFiniteNumberException(T wrong, params object[] args) : this(LocalizedFormats.NOT_FINITE_NUMBER, wrong, args) { }

        /// <summary>
        /// Construct the exception with a specific context.
        /// </summary>
        /// <param name="specific">Specific context pattern.</param>
        /// <param name="wrong">Value that is infinite or NaN.</param>
        /// <param name="args">Optional arguments.</param>
        public NotFiniteNumberException(ILocalizable specific, T wrong, params  object[] args): base(specific, wrong, args) { }
    }
}
