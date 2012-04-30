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
    /// Base class for all unsupported features.
    /// <para>It is used for all the exceptions that have the semantics of the standard
    /// <see cref="NotSupportedException"/>, but must also provide a localized message.</para>
    /// </summary>
    [Serializable]
    public class MathNotSupportedException: NotSupportedException, IExceptionContextProvider
    {
        /// <summary>
        /// Context.
        /// </summary>
        private readonly ExceptionContext context;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public MathNotSupportedException() : this(LocalizedFormats.UNSUPPORTED_OPERATION) { }

        /// <summary>
        /// Simple constructor.
        /// </summary>
        /// <param name="pattern">Message pattern providing the specific context of the error.</param>
        /// <param name="args">Arguments</param>
        public MathNotSupportedException(ILocalizable pattern, params object[] args)
        {
            this.context = new ExceptionContext(this);
            this.context.AddMessage(pattern, args);
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
