// *********************************************************************************
// <copyright file=Simple.cs company="Marcus Technical Services, Inc.">
//     Copyright @2019 Marcus Technical Services, Inc.
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
   /// <summary>
   ///    Interface IAmReallySimple
   /// </summary>
   public interface IAmReallySimple
   {
   }

   /// <summary>
   ///    Interface IAmSimple
   /// </summary>
   public interface IAmSimple
   {
   }

   /// <summary>
   ///    Interface IDerivedSimpleClass
   ///    Implements the <see cref="IAmSimple" />
   ///    Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IAmSimple" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IAmSimple" />
   /// <seealso cref="IAmSimple" />
   public interface IDerivedSimpleClass : IAmSimple
   {
   }

   /// <summary>
   ///    Class SimpleClass_Static.
   /// </summary>
   public static class SimpleClass_Static
   {
      /// <summary>
      ///    Creates the simple instance.
      /// </summary>
      /// <returns>IAmSimple.</returns>
      public static IAmSimple CreateSimpleInstance()
      {
         return new SimpleClass();
      }
   }

   /// <summary>
   ///    Class AnotherSimpleClass.
   ///    Implements the <see cref="IAmSimple" />
   ///    Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IAmSimple" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IAmSimple" />
   /// <seealso cref="IAmSimple" />
   public class AnotherSimpleClass : IAmSimple
   {
   }

   /// <summary>
   ///    Class DerivedSimpleClass.
   ///    Implements the <see cref="SimpleClass" />
   ///    Implements the <see cref="IDerivedSimpleClass" />
   ///    Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.SimpleClass" />
   ///    Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IDerivedSimpleClass" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.SimpleClass" />
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IDerivedSimpleClass" />
   /// <seealso cref="SimpleClass" />
   /// <seealso cref="IDerivedSimpleClass" />
   public class DerivedSimpleClass : SimpleClass, IDerivedSimpleClass
   {
   }

   /// <summary>
   ///    Class SimpleClass.
   ///    Implements the <see cref="IAmSimple" />
   ///    Implements the <see cref="IAmReallySimple" />
   ///    Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IAmSimple" />
   ///    Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IAmReallySimple" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IAmSimple" />
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IAmReallySimple" />
   /// <seealso cref="IAmSimple" />
   /// <seealso cref="IAmReallySimple" />
   public class SimpleClass : IAmSimple, IAmReallySimple
   {
      /// <summary>
      ///    Gets or sets a value indicating whether this instance has been set.
      /// </summary>
      /// <value><c>true</c> if this instance has been set; otherwise, <c>false</c>.</value>
      public bool HasBeenSet { get; set; }
   }
}