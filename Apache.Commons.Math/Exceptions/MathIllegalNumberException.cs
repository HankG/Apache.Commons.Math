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
    /// Base class for exceptions raised by a wrong number.
    /// <para>This class is not intended to be instantiated directly: it should serve as a
    /// base class to create all the exceptions that are raised because some precondition is
    /// violated by a number argument.</para>
    /// </summary>
    [Serializable]
    public class MathIllegalNumberException<T>: MathIllegalArgumentException
    {
        /// <summary>
        /// The argument.
        /// </summary>
        public T Argument { get; private set; }

        /// <summary>
        /// Creates the exceptions.
        /// </summary>
        /// <param name="pattern">The message pattern.</param>
        /// <param name="wrong">The wrong number</param>
        /// <param name="arguments">The arguments</param>
        protected MathIllegalNumberException(ILocalizable pattern, T wrong, params object[] arguments):
            base(pattern, arguments)
        {
            this.Argument = wrong;
        }
    }
}
