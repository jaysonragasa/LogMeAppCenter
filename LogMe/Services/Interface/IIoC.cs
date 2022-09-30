using System;

namespace LogMe.Services.Interface
{
    public interface IIoC
    {
        void Reg<T>() where T : class;
        void Reg<T, TImp>(bool createInstanceImmediately = false) where T : class where TImp : class, T;
        void Reg<T>(Func<T> factory) where T : class;
        T GI<T>() where T : class;
    }
}
