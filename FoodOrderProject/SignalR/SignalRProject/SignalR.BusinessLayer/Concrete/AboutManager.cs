﻿using SignalR.BusinessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using SignalRDataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About entity)
        {
            _aboutDal.Add(entity);
        }

        public void TDelete(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public List<About> TGetAllList()
        {
            return _aboutDal.GetAllList();
        }

        public About TGetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public void TUpdate(About entity)
        {
            return _aboutDal.Update(entity);
        }
    }
}
