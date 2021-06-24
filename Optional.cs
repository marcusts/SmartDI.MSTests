// *********************************************************************************
// Copyright @2021 Marcus Technical Services, Inc.
// <copyright
// file=Optional.cs
// company="Marcus Technical Services, Inc.">
// </copyright>
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// *********************************************************************************

namespace Com.MarcusTS.SmartDI.MSTests
{
   public class RequiredParam1
   {
   }

   public class RequiredParam2
   {
   }

   public class OptionalParam1
   {
   }

   public class OptionalParam2
   {
   }

   public class ClassWithOptionalParameters
   {
      public RequiredParam1 InjectedRequiredParam1 { get; set; }
      public RequiredParam2 InjectedRequiredParam2 { get; set; }
      public OptionalParam1 InjectedOptionalParam1 { get; set; }
      public OptionalParam2 InjectedOptionalParam2 { get; set; }

      public ClassWithOptionalParameters(RequiredParam1 requiredParam1, RequiredParam2 requiredParam2, OptionalParam1 optionalParam1 = null, OptionalParam2 optionalParam2 = null )
      {
         InjectedRequiredParam1 = requiredParam1;
         InjectedRequiredParam2 = requiredParam2;
         InjectedOptionalParam1 = optionalParam1;
         InjectedOptionalParam2 = optionalParam2;
      }
   }
}
