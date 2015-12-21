using System;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.Model
{
    public interface IModelPersister
    {
        IModelLoader GetLoader();

        void Save(Document model);
    }

    public interface IModelLoader
    {
        Mock GetMock();
    }
}
