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
    [Serializable]
    public class ExceptionContext
    {
        /// <summary>
        /// The exception to which this context refers to.
        /// </summary>
        private Exception exception;

        /// <summary>
        /// Various informations that enrich the informative message.
        /// </summary>
        private IList<ILocalizable> messagePatterns;

        /// <summary>
        /// Various informations that enrich the informative message.
        /// <para>The arguments will replace the corresponding place-holders in <see cref="messagePatterns"/>.</para>
        /// </summary>
        private IList<object[]> messageArguments;

        /// <summary>
        /// Arbitrary context information.
        /// </summary>
        private IDictionary<string, object> context;

        /// <summary>
        /// Simple constructor.
        /// </summary>
        /// <param name="exception">The exception this context refers to.</param>
        public ExceptionContext(Exception exception)
        {
            this.exception = exception;
            this.messagePatterns = new List<ILocalizable>();
            this.messageArguments = new List<object[]>();
            this.context = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets a reference to the exception to which the context relates.
        /// </summary>
        /// <value>A reference to the exception to which the context relates.</value>
        public virtual Exception Exception
        {
            get { return this.exception; }
        }

        /// <summary>
        /// Adds a message.
        /// </summary>
        /// <param name="pattern">Message pattern.</param>
        /// <param name="arguments">Values for replacing the placeholders in the message patterns.</param>
        public virtual void AddMessage(ILocalizable pattern, params object[] arguments)
        {
            messagePatterns.Add(pattern);
            messageArguments.Add(arguments.Flatten());
        }

        /// <summary>
        /// Gets and sets the context pair.
        /// <para>Keys are assumed to be unique within an instance. If the same key is assigned a new value,
        /// the previous one will be lost.</para>
        /// </summary>
        /// <param name="key">The context key (not null).</param>
        /// <returns>The context value.</returns>
        public virtual object this[string key]
        {
            get { return context[key]; }
            set { context[key] = value; }
        }

        /// <summary>
        /// Gets all the keys stored in the exceptions.
        /// </summary>
        /// <value>The sets of keys.</value>
        public virtual ICollection<string> Keys
        {
            get { return context.Keys; }
        }

        /// <summary>
        /// Gets the default message.
        /// </summary>
        public virtual string Message
        {
            get { return GetMessage(CultureInfo.InvariantCulture); }
        }

        /// <summary>
        /// Gets the message in default locale
        /// </summary>
        public virtual string LocalizedMessage
        {
            get { return GetMessage(CultureInfo.CurrentCulture); }
        }

        /// <summary>
        /// Getsd the message in a specified locale.
        /// </summary>
        /// <param name="cultureInfo">The <c>CultureInfo</c> in which the message should be translated.</param>
        /// <param name="separator">The separator inserted between message parts.</param>
        /// <returns>The localized message.</returns>
        public virtual string GetMessage(CultureInfo cultureInfo, string separator = ": ")
        {
            return BuildMessage(cultureInfo, separator);
        }

        /// <summary>
        /// Builds a message string.
        /// </summary>
        /// <param name="cultureInfo">The culture info in which the message should be translated.</param>
        /// <param name="separator">The message separator.</param>
        /// <returns>A localized message string.</returns>
        private string BuildMessage(CultureInfo cultureInfo, string separator)
        {
            var sb = new StringBuilder();
            var count = 0;
            var length = messagePatterns.Count;
            for (int i = 0; i < length; i++)
            {
                var pattern = messagePatterns[i];
                var args = messageArguments[i];
                sb.AppendFormat(pattern.GetLocalizedString(cultureInfo), args);
                if (++count < length)
                    sb.Append(separator);
            }

            return sb.ToString();
        }
    }
}
