using System;
using System.Collections.Generic;
using QAData;
using QAData.Models;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace QAServices
{
    public class QAAssetService : IQAAsset
    {
        private QADataContext _context;
        public QAAssetService(QADataContext context)
        {
            _context = context;
        }
        public void Add(QAAsset newAsset)
        {
           _context.Add(newAsset);
           _context.SaveChanges();
        }

        public IEnumerable<QAAsset> GetAll()
        {
          return _context.QAAssets
          .Include(asset => asset.Status)
          .Include(asset => asset.Location);
        }

        public QAAsset GetById(int id)
        {
           return _context.QAAssets
          .Include(asset => asset.Status)
          .Include(asset => asset.Location)
          .FirstOrDefault(asset => asset.Id == id);
        
        public QAAsset GetById(int id)
        {
           return 
           GetAll()
          .FirstOrDefault(asset => asset.Id == id);
        }

        public QABranch GetCurrentLocation(int id)
        {
            return GetById(id).Location;

        }

        public string GetDataId(int id)
        {
           var DataSet = _context.QAAssets.OfType<DataSets>()
            .Where(d => d.Id == id);
            
            return DataSet.Any() ? "DataSet" : "Video";
        }

        public string GetQATCI(int id)
        {
                //Descriminator  column 
            if (_context.DataSet.Any(DataSets => DataSets.Id == id)) 
             {
                    return _context.DataSet
                    .FirstOrDefault(DataSets => DataSets.Id == id).QATCI;
             }
             else return "";
        }

        public string GetTcId(int id)
        {
                if (_context.DataSet.Any(DataSets => DataSets.Id == id))
                {
                     return _context.DataSet
                    .FirstOrDefault(DataSets => DataSets.Id == id)
                    .TcId;
                }
                else return "";
        }

        public string GetTitle(int id)
        {
           return _context.QAAssets
           .FirstOrDefault(a => a.Id == id)
           .Title;

        }
        public string GetAuthororDirector(int id)
        {
          var isDataSets =  _context.DataSet.OfType<DataSets>()
          .Where(asset => asset.Id == id).Any();
          var isVideo = _context.DataSet.OfType<Video>()
          .Where(asset => asset.Id == id).Any();

    return isDataSets?
    _context.DataSet.FirstOrDefault(DataSets => DataSets.Id == id).Author :
    _context.Videos.FirstOrDefault(Video = Video.Id == id).Director
    ?? "Unknown";
    }
 