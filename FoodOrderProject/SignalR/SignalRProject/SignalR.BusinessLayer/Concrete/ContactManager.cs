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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact entity)
        {
            _contactDal.Add(entity);
        }

        public void TDelete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public List<Contact> TGetAllList()
        {
            return _contactDal.GetAllList();
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity); 
        }
    }
}
