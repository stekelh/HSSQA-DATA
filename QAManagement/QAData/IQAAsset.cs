using System;
using QAData.Models;
using System.Collections.Generic;
using System.Text;

namespace QAData
{
    public interface IQAAsset
    {
        IEnumerable<QAAsset> GetAll();
        QAAsset GetById(int id);


        void Add(QAAsset newAsset);
        string GetAuthororDirector(int id);
        string GetQATCI(int id);
        string GetDataId(int id);
        string GetTitle(int id);
        string GetTcId(int id);
    
       QABranch GetCurrentLocation(int id);

    }
}
