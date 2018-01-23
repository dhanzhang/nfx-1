/*<FILE_LICENSE>
* NFX (.NET Framework Extension) Unistack Library
* Copyright 2003-2018 Agnicore Inc. portions ITAdapter Corp. Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
</FILE_LICENSE>*/


/* NFX by ITAdapter
 * Originated: 2006.01
 * Revision: NFX 0.3  2009.10.12
 */
using System;
using System.Runtime.Serialization;

using NFX.ApplicationModel;
using NFX.Serialization.BSON;

namespace NFX.Scripting
{
  /// <summary>
  /// Base exception thrown scripting framework
  /// </summary>
  [Serializable]
  public class ScriptingException : NFXException
  {
    public ScriptingException() {}
    public ScriptingException(string message) : base(message) {}
    public ScriptingException(string message, Exception inner) : base(message, inner) {}
    protected ScriptingException(SerializationInfo info, StreamingContext context) : base(info, context) { }
  }


  /// <summary>
  /// Base exception thrown Runner
  /// </summary>
  [Serializable]
  public class RunnerException : ScriptingException
  {
    public RunnerException() {}
    public RunnerException(string message) : base(message) {}
    public RunnerException(string message, Exception inner) : base(message, inner) {}
    protected RunnerException(SerializationInfo info, StreamingContext context) : base(info, context) { }
  }


  /// <summary>
  /// Thrown when run method parameters can not be bound
  /// </summary>
  [Serializable]
  public class RunMethodBinderException : RunnerException
  {
    public RunMethodBinderException() {}
    public RunMethodBinderException(string message) : base(message) {}
    public RunMethodBinderException(string message, Exception inner) : base(message, inner) {}
    protected RunMethodBinderException(SerializationInfo info, StreamingContext context) : base(info, context) { }
  }

}