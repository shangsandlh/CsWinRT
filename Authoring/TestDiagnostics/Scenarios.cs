﻿using ABI.System.Numerics;
using ABI.Windows.ApplicationModel.Contacts;
using System;
using System.Runtime.ExceptionServices;
using Windows.Foundation;
using Windows.Foundation.Numerics;
using Windows.Web.Syndication;

namespace TestDiagnostics
{
  
    

    public sealed class SillyClass
    { 
        public double Identity(double d)
        {
            return d;
        }
    }

    /*  */
    public struct StructWithClass_Invalid
    {
        public SillyClass classField;
    }

    public struct StructWithDelegate_Invalid
    { 
        public delegate int ADelegate(int x);
    }

    public struct StructWithEvent_Invalid
    { 
        public event EventHandler<int> EventField;
    }

    public struct StructWithConstructor_Invalid
    {
        int X;
        StructWithConstructor_Invalid(int x)
        {
            X = x;
        }
    }
    
    public struct StructWithIndexer_Invalid
    {
        int[] arr;
        int this[int i] => arr[i];
    }
    
    public struct StructWithMethods_Invalid
    {
        int foo(int x)
        {
            return x;
        }
    }
    public struct StructWithConst_Invalid // really invalid ?
    {
        const int five = 5;
    }
    
    /*
    public enum BasicEnum
    { 
        First = 0,
        Second = 1
    }

    public struct Posn_Invalid 
    {
        BasicEnum enumField; 

        public int x { get; }
        public int y { get; }
    }
    */

    /*
    public struct StructWithPrivateField_Invalid
    {
        const int ci = 5;
        private int x;
    }
    */

    /*
    public struct StructWithAllValidFields
    {
        bool boolean;
        char character;
        decimal dec;
        double dbl;
        float flt;
        int i;
        uint nat;
        long lng;
        ulong ulng;
        short sh;
        ushort us;
        string str;
    }
    */

    /*
    public struct StructWithObjectField_Invalid // is this really invalid? 
    {
        object obj;

    }
    public struct StructWithDynamicField_Invalid // is this really invalid? 
    {
        dynamic dyn;
    }

    public struct StructWithByteField_Invalid // is this really invalid? 
    {
        byte b;
    }

    public struct StructWithWinRTStructField
    {
        public Matrix3x2 matrix;
    }
    */

    /*
    public sealed class ParameterNamedDunderRetVal
    {
        public int Identity(int __retval)
        {
            return __retval;
        }
    }
    */

    /*
    public sealed class SameArityConstructors
    {
        private int num;
        private string word;

        public SameArityConstructors(int i)
        {
            num = i;
            word = "dog";
        }
       
        public SameArityConstructors(string s)
        {
            num = 38;
            word = s;
        } 

        // Can test that multiple constructors are allowed (has been verified already, too)
        // as long as they have different arities by making one take none or 2 arguments 
    }
    */

    /* Would be nice to not have to comment out scenarios... perhaps a file for each case to test?  
    public sealed class AsyAction : IAsyncAction, IAsyncActionWithProgress<int>
    {
        public AsyncActionCompletedHandler Completed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Exception ErrorCode => throw new NotImplementedException();

        public uint Id => throw new NotImplementedException();

        public AsyncStatus Status => throw new NotImplementedException();

        AsyncActionProgressHandler<int> IAsyncActionWithProgress<int>.Progress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        AsyncActionWithProgressCompletedHandler<int> IAsyncActionWithProgress<int>.Completed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        Exception IAsyncInfo.ErrorCode => throw new NotImplementedException();

        uint IAsyncInfo.Id => throw new NotImplementedException();

        AsyncStatus IAsyncInfo.Status => throw new NotImplementedException();

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void GetResults()
        {
            throw new NotImplementedException();
        }

        void IAsyncInfo.Cancel()
        {
            throw new NotImplementedException();
        }

        void IAsyncInfo.Close()
        {
            throw new NotImplementedException();
        }

        void IAsyncActionWithProgress<int>.GetResults()
        {
            throw new NotImplementedException();
        }
    }
    */
   
    /*
    public class ActionWithProgress : IAsyncActionWithProgress<int>
    {
        AsyncActionProgressHandler<int> IAsyncActionWithProgress<int>.Progress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        AsyncActionWithProgressCompletedHandler<int> IAsyncActionWithProgress<int>.Completed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        Exception IAsyncInfo.ErrorCode => throw new NotImplementedException();

        uint IAsyncInfo.Id => throw new NotImplementedException();

        AsyncStatus IAsyncInfo.Status => throw new NotImplementedException();

        void IAsyncInfo.Cancel()
        {
            throw new NotImplementedException();
        }

        void IAsyncInfo.Close()
        {
            throw new NotImplementedException();
        }

        void IAsyncActionWithProgress<int>.GetResults()
        {
            throw new NotImplementedException();
        }
    }
    */

    /*
    public sealed class OpWithProgress : IAsyncOperationWithProgress<int, bool>
    {
        AsyncOperationProgressHandler<int, bool> IAsyncOperationWithProgress<int, bool>.Progress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        AsyncOperationWithProgressCompletedHandler<int, bool> IAsyncOperationWithProgress<int, bool>.Completed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        Exception IAsyncInfo.ErrorCode => throw new NotImplementedException();

        uint IAsyncInfo.Id => throw new NotImplementedException();

        AsyncStatus IAsyncInfo.Status => throw new NotImplementedException();

        void IAsyncInfo.Cancel()
        {
            throw new NotImplementedException();
        }

        void IAsyncInfo.Close()
        {
            throw new NotImplementedException();
        }

        int IAsyncOperationWithProgress<int, bool>.GetResults()
        {
            throw new NotImplementedException();
        }
    }

    public sealed class Op : IAsyncOperation<int>
    {
        AsyncOperationCompletedHandler<int> IAsyncOperation<int>.Completed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        Exception IAsyncInfo.ErrorCode => throw new NotImplementedException();

        uint IAsyncInfo.Id => throw new NotImplementedException();

        AsyncStatus IAsyncInfo.Status => throw new NotImplementedException();

        void IAsyncInfo.Cancel()
        {
            throw new NotImplementedException();
        }

        void IAsyncInfo.Close()
        {
            throw new NotImplementedException();
        }

        int IAsyncOperation<int>.GetResults()
        {
            throw new NotImplementedException();
        }
    } 
    */
}
