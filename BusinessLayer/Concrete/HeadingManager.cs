﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public Heading Belong(int writerID, int headingID)
        {
            return _headingDal.Get(x => x.HeadingID == headingID && x.WriterID == writerID);
        }

        public void DeleteHeading(Heading heading)
        {
            _headingDal.Update(heading);
        }

        public Heading GetByID(int id)
        {
            return _headingDal.Get(x => x.HeadingID == id);
        }

        public void HeadingAdd(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public void HeadingUpdate(Heading heading)
        {
            _headingDal.Update(heading);
        }

        public List<Heading> List()
        {
            return _headingDal.List().OrderByDescending(x => x.HeadingID).ToList();
        }

        public List<Heading> List(string word)
        {
            return _headingDal.List(x => x.HeadingName.Contains(word)).OrderByDescending(x=>x.HeadingID).ToList();
        }

        public List<Heading> ListActive()
        {
            return _headingDal.List(x=>x.HeadingStatus).OrderByDescending(x => x.HeadingID).ToList();
        }

        public List<Heading> ListByCategory(int categoryID)
        {
            return _headingDal.List(x => x.CategoryID == categoryID).OrderByDescending(x=>x.HeadingID).ToList();
        }
    }
}
