﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{ 
    public class MockSet<T> where T : Mock
    {
        protected HashSet<T> mockSet;
        protected static readonly HashSet<T> emptyMockSet = new HashSet<T>();
        private int numbersMock;

        public MockSet()
        {
            this.numbersMock = 10;
            this.mockSet = emptyMockSet;
        }

        // --- PROPRIETA' ---
        public IEnumerable<T> List
        {
            get
            {
                return this.mockSet;
            }
        }

        public int NumbersMock
        {
            set { this.numbersMock = value; }
            get { return this.numbersMock; }
        }
        // -----------------------------------------------

        public void Add(T m)
        {
            #region Precondizioni
            if (m == null)
                throw new ArgumentNullException("mock == null");
            #endregion

            if (!this.List.Contains(m))
            {
                this.mockSet.Add(m);
            }
        }
        
        public void Remove(T m)
        {
            #region Precondizioni
            if (m == null)
                throw new ArgumentNullException("mock == null");
            #endregion

            Console.WriteLine("devo eliminare: " + m.ToString());

            T item = null;
            foreach (T mock in this.mockSet)
            {
                Console.WriteLine("ciclo: " + mock.ToString());
                if (mock.Equals(m))
                {
                    Console.WriteLine("trovato-elimino");
                    item = mock;
                    mockSet.Remove(item);
                    break;
                }
            }
        }

        public void RemoveAll()
        {
            if (this.mockSet == emptyMockSet)
                return;

            foreach (T m in mockSet)
            {
                this.Remove(m);
            }
        }

        public T Get()
        {
            if (this.Lenght() <= 0)
                throw new Exception("MockSet empty");

            T ret = this.mockSet.First();
            Remove(ret);
            return ret;
        }

        public int Lenght()
        {
            return this.mockSet.ToArray().Length;
        }
    }
}
