using WindowsFormsApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    public class Document
    {
        private readonly MockSet<Mock> mockSet;
        private static Document _instance;
        private IModelPersister mp;

        public static Document GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Document();
                return _instance;
            }
            else
            {
                return _instance;
            }
        }

        private Document()
        {
            this.mockSet = new MockSet<Mock>();
            this.mp = null;
            this.mockSet.quasiVuoto += update;
        }

        public MockSet<Mock> MockSet
        {
            get { return this.mockSet; }
        }
        
        public void Load(IModelPersister persister)
        {
            this.mp = persister;
            #region Precondizioni
            if (persister == null)
                throw new ArgumentNullException("persister == null");
            #endregion

            IModelLoader loader = persister.GetLoader();

            // E' qui che devo popolare 
            while(!this.mockSet.isFull())
                this.mockSet.Add(loader.GetMock());

            //OnChanged();
        }

        public void update(int num)
        {
            Console.WriteLine("UPDATE MOCKS");
            if (this.mp == null)
                throw new Exception("update fail, persiste == null");
            this.Load(this.mp);
        }

        public void Save(IModelPersister persister)
        {
            #region Precondizioni
            if (persister == null)
                throw new ArgumentNullException("persister == null");
            #endregion

            persister.Save(this);
        }
    }
}
