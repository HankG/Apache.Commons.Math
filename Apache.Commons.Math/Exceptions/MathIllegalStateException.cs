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
    /// Base class for all the exceptions that signal a mismatch between the current state
    /// and the user's expectations.
    /// </summary>
    [Serializable]
    public class MathIllegalStateException: MathException, IExceptionContextProvider
    {
        /// <summary>
        /// The context.
        /// </summary>
        private readonly ExceptionContext context;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public MathIllegalStateException(): this(LocalizedFormats.ILLEGAL_STATE) { }

        /// <summary>
        /// Simple constructor.
        /// </summary>
        /// <param name="pattern">Message pattern explaining the cause of the error.</param>
        /// <param name="args">Arguments.</param>
        public MathIllegalStateException(ILocalizable pattern, params object[] args)
        {
            context = new ExceptionContext(this);
            context.AddMessage(pattern, args);
        }

        /// <summary>
        /// Simple constructor.
        /// </summary>
        /// <param name="inner">The root cause.</param>
        /// <param name="pattern">Message pattern explaining the cause of the error.</param>
        /// <param name="args">Arguments.</param>
        public MathIllegalStateException(Exception inner, ILocalizable pattern, params object[] args):
            base("", inner)
        {
            context = new ExceptionContext(this);
            context.AddMessage(pattern, args);
        }

        public virtual ExceptionContext Context
        {
            get { return context; }
        }

        public override string Message
        {
            get
            {
                return context.LocalizedMessage;
            }
        }
    }
}
