using System;

namespace L_09.Task_06
{
    public interface IReadable<T>
    {
        void Save(int index, T item);
        T Read(int index);
    }
}
