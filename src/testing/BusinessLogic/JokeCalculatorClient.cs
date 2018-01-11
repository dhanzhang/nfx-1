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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using NFX.Glue;
using NFX.Glue.Protocol;

namespace BusinessLogic
{

    //Written by hand. In future will be generated by "gluec"
    public class JokeCalculatorClient : ClientEndPoint, IJokeCalculator
    {
       public JokeCalculatorClient(string node, Binding binding = null) : base(node, binding) { ctor(); }
       public JokeCalculatorClient(Node node, Binding binding = null) : base(node, binding) { ctor(); }
       public JokeCalculatorClient(IGlue glue, string node, Binding binding = null) : base(glue, node, binding) { ctor(); }
       public JokeCalculatorClient(IGlue glue, Node node, Binding binding = null) : base(glue, node, binding) { ctor(); }


       private MethodInfo miInit;
       private MethodInfo miAdd;
       private MethodInfo miSub;
       private MethodInfo miDone;

       private void ctor()
       {
         var t = typeof(IJokeCalculator);
         miInit = t.GetMethod("Init");
         miAdd = t.GetMethod("Add");
         miSub = t.GetMethod("Sub");
         miDone = t.GetMethod("Done");

         //how to use client-level inspector injection
         //MsgInspectors.Register( new BusinessLogic.TextInfoReporter());
       }


       public override Type Contract
       {
           get { return typeof(IJokeCalculator); }
       }


      #region Contract Methods

        public void Init(int value)
        {
           Async_Init(value).GetValue<object>();
        }

        public CallSlot Async_Init(int value)
        {
          var request = new RequestAnyMsg(miInit, RemoteInstance, new object[]{ value });

          return DispatchCall(request);
        }


        public int Add(int value)
        {
          return Async_Add(value).GetValue<int>();
        }

        public CallSlot Async_Add(int value)
        {
          var request = new RequestAnyMsg(miAdd, RemoteInstance, new object[]{ value });

          return DispatchCall(request);
        }


        public int Sub(int value)
        {
          return Async_Sub(value).GetValue<int>();
        }

        public CallSlot Async_Sub(int value)
        {
          var request = new RequestAnyMsg(miSub, RemoteInstance, new object[]{ value });

          return DispatchCall(request);
        }


        public int Done()
        {
          return Async_Done().GetValue<int>();
        }

        public CallSlot Async_Done()
        {
          var request = new RequestAnyMsg(miDone, RemoteInstance, null);

          return DispatchCall(request);
        }




      #endregion
    }
}