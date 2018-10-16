using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class CircularBuffer<T>
    {
        private int _start;
        private int _end;
        private T[] _buffer;

        public CircularBuffer()
        {
            _start = 0;
            _end = 0;
            _buffer = new T[5];
        }
        public CircularBuffer(int capacity)
        {
            _start = 0;
            _end = 0;
            _buffer = new T[capacity];
        }

        public void Write(T item)
        {

            var l = new List<string>();

            _buffer[_end] = item;
            _end = (_end + 1) % _buffer.Length;

            if (_end == _start)
            {
                _start = (_start + 1) % _buffer.Length;
            }
        }

        public T Read()
        {
            var result = _buffer[_start];
            _start = (_start + 1) % _buffer.Length;
            return result;
        }
    }
}
